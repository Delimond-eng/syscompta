using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FactureManagement.Datas;
using System.Data.SQLite;
using System.Drawing;
using System.Security.Cryptography;

namespace FactureManagement.App
{
    public static class app 
    {
        static DataContext db = new DataContext();
        public static bool FieldsEmpty = false;

        static string Cle { get; set; } = "A!9HHhi%XjjYY44YP2@Nob009X";

        public static string[] checkFields(string[] fields)
        {
            for (int i = 0; i < fields.Length; i++)
            {
                if (fields[i] == "")
                {
                    MessageBox.Show("Vous devez remplir toutes les zones de saisie avant d'effectuer cette opération!");
                    FieldsEmpty = true;
                    break;
                }
                else if (fields[i] != "")
                {
                    FieldsEmpty = false;
                }
            }

            return fields;
        }

        public static bool isConfiguration()
        {
            bool isConfigurated = false;
            try
            {
                db.connect();
                db.req = new SQLiteCommand("SELECT idconfig FROM CONFIG", db.con);
                db.dr = db.req.ExecuteReader();
                if (db.dr.HasRows)
                {
                    isConfigurated = true;
                    db.disconnect();
                }
                else
                {
                    isConfigurated = false;
                    db.disconnect();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return isConfigurated;
        }

        public static double convertCdfToDollars(double Amount)
        {
            
            db.connect();
            db.req = new SQLiteCommand("SELECT montantTaux FROM TAUX", db.con);
            double TauxCDF = double.Parse(db.req.ExecuteScalar().ToString());
            db.disconnect();
            double dollars = Amount / TauxCDF;
            return dollars;
        }

        public static double convertDollarsToCdf(double dollars)
        {
            db.connect();
            db.req = new SQLiteCommand("SELECT montantTaux FROM TAUX WHERE num=1", db.con);
            double TauxCDF = double.Parse(db.req.ExecuteScalar().ToString());
            db.disconnect();
            double cdf = dollars * TauxCDF;
            return cdf;
        }

        public static string GenerateRandomCode()
        {
            string guid = Guid.NewGuid().ToString("N");
            List<char> lst = new List<char>();
            int count = 1;

            foreach (char c in guid)
            {
                if (count == 7) break;
                if (count % 2 == 0)
                {
                    lst.Add(Guid.NewGuid().ToString().ToCharArray()[1]);
                }
                else
                {
                    lst.Add(c);
                }
                count++;
            }
            return string.Join("", lst.ToArray());
        }

        public static void Ergonomy(Object form)
        {
            Form frm = form as Form;
            frm.Location = new Point(0,0);
            frm.Size = Screen.PrimaryScreen.WorkingArea.Size;
        }

        public static string Encrypt(string text)
        {
            using(var md5 = new MD5CryptoServiceProvider())
            {
                using(var tdes = new TripleDESCryptoServiceProvider())
                {
                    tdes.Key = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(Cle));
                    tdes.Mode = CipherMode.ECB;
                    tdes.Padding = PaddingMode.PKCS7;

                    using(var transform = tdes.CreateEncryptor())
                    {
                        byte[] textBytes = UTF8Encoding.UTF8.GetBytes(text);
                        byte[] bytes = transform.TransformFinalBlock(textBytes, 0, textBytes.Length);
                        return Convert.ToBase64String(bytes, 0, bytes.Length);
                    }
                }
            }
        }

        public static string Decrypt(string text)
        {
            using (var md5 = new MD5CryptoServiceProvider())
            {
                using (var tdes = new TripleDESCryptoServiceProvider())
                {
                    tdes.Key = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(Cle));
                    tdes.Mode = CipherMode.ECB;
                    tdes.Padding = PaddingMode.PKCS7;

                    using (var transform = tdes.CreateDecryptor())
                    {
                        byte[] encrypText = Convert.FromBase64String(text);
                        byte[] bytes = transform.TransformFinalBlock(encrypText, 0, encrypText.Length);
                        return UTF8Encoding.UTF8.GetString(bytes);
                    }
                }
            }
        }

        public static string currency(double number)
        {
            string dec = string.Format("{0:0.00}", number);
            return dec;
        }

        public static void activated(string code, int delay, string status)
        {
            try
            {
                db.connect();
                db.req = new SQLiteCommand("SELECT id_activation FROM ACTIVATION", db.con);
                db.dr = db.req.ExecuteReader();
                if (db.dr.HasRows)
                {
                    db.dr.Close();
                    db.req.Dispose();
                    db.req = new SQLiteCommand("UPDATE ACTIVATION SET code_activation=@code, delay=@delay,date_activation=@date, status=@status", db.con);
                    db.req.Parameters.AddWithValue("@code", code);
                    db.req.Parameters.AddWithValue("@delay", delay);
                    db.req.Parameters.AddWithValue("@date", DateTime.Now.ToString("yyyy-MM-dd"));
                    db.req.Parameters.AddWithValue("status", status);
                    db.req.ExecuteNonQuery();
                    db.disconnect();
                }
                else
                {
                    db.dr.Close();
                    db.req.Dispose();
                    db.req = new SQLiteCommand("INSERT INTO ACTIVATION(code_activation,delay,date_activation,status) VALUES(@code,@delay,@date,@status)", db.con);
                    db.req.Parameters.AddWithValue("@code", code);
                    db.req.Parameters.AddWithValue("@delay", delay);
                    db.req.Parameters.AddWithValue("@date", DateTime.Now.ToString("yyyy-MM-dd"));
                    db.req.Parameters.AddWithValue("status", status);
                    db.req.ExecuteNonQuery();
                    db.disconnect();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadLine();
            }
           
        }
        public static void desactivated()
        {
            try
            {
                db.connect();
                db.req = new SQLiteCommand("SELECT id_activation FROM ACTIVATION", db.con);
                db.dr = db.req.ExecuteReader();
                if (db.dr.HasRows)
                {
                    db.dr.Close();
                    db.req.Dispose();
                    db.req = new SQLiteCommand("UPDATE ACTIVATION SET delay=@delay, status=@status", db.con);
                    db.req.Parameters.AddWithValue("@delay", 0);
                    db.req.Parameters.AddWithValue("status", "expired");
                    db.req.ExecuteNonQuery();
                    db.disconnect();
                }
            }
            catch (Exception) { }
        }
        public static int dateInterval(DateTime dateNow, DateTime dateLast)
        {
            TimeSpan nbreDay = dateNow - dateLast;
            int interval = (int)nbreDay.TotalDays;
            return interval;
        }

    }

}
