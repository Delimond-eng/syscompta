using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FactureManagement.App;
using System.Data.SQLite;

namespace FactureManagement.Datas
{
    class Client : DataContext
    {

        public void Create(string nom, string adress, string phone, string email)
        {
            try
            {
                connect();
                req = new SQLiteCommand("INSERT INTO CLIENT(nomcli,adresse,tel,Email, datecreate) VALUES(@nom,@adresse,@tel,@email,@date)",con);
                req.Parameters.AddWithValue("@nom", nom);
                req.Parameters.AddWithValue("@adresse", adress);
                req.Parameters.AddWithValue("@tel", phone);
                req.Parameters.AddWithValue("@email", email);
                req.Parameters.AddWithValue("@date", DateTime.Now.ToString("yyyy-MM-dd"));
                req.ExecuteNonQuery();
                MessageBox.Show("Effectué avec succès!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void Update(string id, string nom, string adress, string phone, string email)
        {
            try
            {
                connect();
                req = new SQLiteCommand("UPDATE CLIENT SET nomCli=@nom, adresse=@adresse,tel=@tel, Email=@email,datecreate=@date WHERE idCli=@id", con);
                req.Parameters.AddWithValue("@nom", nom);
                req.Parameters.AddWithValue("@adresse", adress);
                req.Parameters.AddWithValue("@tel", phone);
                req.Parameters.AddWithValue("@email", email);
                req.Parameters.AddWithValue("@date", DateTime.Now.ToString("yyyy-MM-dd"));
                req.Parameters.AddWithValue("@id", id);

                DialogResult dlg = MessageBox.Show("Etes-vous sûr de vouloir modifier ce client ?", "MODIFICATION", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dlg == DialogResult.Yes)
                {
                    req.ExecuteNonQuery();
                    MessageBox.Show("Effectué avec succès!");
                }
                else return;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        
        public void Delete(string id)
        {
            try
            {
                connect();
                req = new SQLiteCommand("DELETE FROM CLIENT WHERE idcli=@id", con);
                req.Parameters.AddWithValue("@id", id);

                DialogResult dlg = MessageBox.Show("Etes-vous sûr de vouloir supprimer définitivement ce client ?", "SUPPRESSION", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dlg == DialogResult.Yes)
                {
                    req.ExecuteNonQuery();
                    MessageBox.Show("Effectué avec succès!");
                }
                else return;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
