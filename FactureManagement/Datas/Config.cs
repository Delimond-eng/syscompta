using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace FactureManagement.Datas
{
    class Config : DataContext
    {
       public void createConfig(string design, string Idnat, string rccm, string adress, string mail, string phone,Image logo)
        {
            byte[] ImageByteArray = new byte[] { };
            Image temp = new Bitmap(logo);
            MemoryStream strm = new MemoryStream();
            temp.Save(strm, System.Drawing.Imaging.ImageFormat.Png);
            ImageByteArray = strm.ToArray();
            try
            {
                connect();
                req = new SQLiteCommand("INSERT INTO CONFIG(Esename,idnat,rccm,adresseconfig,email,phone,logo) VALUES(@designEse,@idnat,@rccm,@adress,@email,@phone,@logo)", con);
                req.Parameters.AddWithValue("@designEse",design);
                req.Parameters.AddWithValue("@idnat", Idnat);
                req.Parameters.AddWithValue("@rccm",rccm);
                req.Parameters.AddWithValue("@adress", adress);
                req.Parameters.AddWithValue("@email", mail);
                req.Parameters.AddWithValue("@phone", phone);
                SQLiteParameter param = req.Parameters.AddWithValue("@logo", ImageByteArray);
                param.DbType = System.Data.DbType.Binary;
                req.ExecuteNonQuery();
                disconnect();
                MessageBox.Show("la configuration a été effectuée avec succès");
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show(ex.Message);
                disconnect();
            }
        }

        //public static byte [] getPhoto(string filepath)
        //{
        //    FileStream stream = new FileStream(filepath, FileMode.Open, FileAccess.Read);
        //    BinaryReader reader = new BinaryReader(stream);
        //    byte[] photo = reader.ReadBytes((int)stream.Length);

        //    reader.Close();
        //    stream.Close();
        //    return photo;
        //}
    }
}
