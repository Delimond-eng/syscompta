using FactureManagement.App;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FactureManagement.Datas
{
    class UserManager : DataContext
    {
        public void register(string username, string password,string profil)
        {
            reset("admin");
            try
            {
                connect();
                req = new SQLiteCommand("INSERT INTO USER_MANAGER(username,pwd,profil) VALUES(@user,@pwd,@profil)",con);
                req.Parameters.AddWithValue("@user", username);
                req.Parameters.AddWithValue("@pwd", app.Encrypt(password));
                req.Parameters.AddWithValue("@profil", profil);
                req.ExecuteNonQuery();
                disconnect();
                MessageBox.Show("L'utilisateur a été créé avec succès!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void login(string username, string password,object inner, object form)
        {
            try
            {
                connect();
                req = new SQLiteCommand("SELECT username,pwd FROM USER_MANAGER WHERE username='"+ username + "' AND pwd='"+password+"'",con);
                dr = req.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        Form frm = form as Form;
                        Form innerForm = inner as Form;
                        innerForm.Hide();
                        frm.Show();
                        break;
                    }
                    disconnect();
                }
                else
                {
                    MessageBox.Show("Les identifiants inserés sont invalides, veuillez reessayer d'autres identifiants", "INVALIDE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    disconnect();
                }
            }
            
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void reset(string username)
        {
            try
            {
                connect();
                req = new SQLiteCommand("DELETE FROM USER_MANAGER WHERE username=@user", con);
                req.Parameters.AddWithValue("@user", username);
                req.ExecuteNonQuery();
                disconnect();
            }
            catch (Exception ex)
            {
                Console.Write(ex.Message);
            }
        }
    }
}
