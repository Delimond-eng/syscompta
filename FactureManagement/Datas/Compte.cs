using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Windows.Forms;

namespace FactureManagement.Datas
{
    class Compte: DataContext
    {
        Mouvement operation = new Mouvement();
        public void createCompte(string intitule, double montant,string devise)
        {
            try
            { 
                connect();
                req = new SQLiteCommand("INSERT INTO COMPTE(intitule,depotInit,soldeCompte,deviseCompte,datecreateCompte) VALUES(@intitule, @depot,@solde,@devise,@date)", con);
                req.Parameters.AddWithValue("@intitule", intitule);
                req.Parameters.AddWithValue("@depot", montant);
                req.Parameters.AddWithValue("@solde", montant);
                req.Parameters.AddWithValue("@devise", devise);
                req.Parameters.AddWithValue("@date", DateTime.Now.ToString("yyyy-MM-dd"));
                int row = req.ExecuteNonQuery();
                req = new SQLiteCommand("SELECT last_insert_rowid()", con);
                int numCompte = int.Parse(req.ExecuteScalar().ToString());

                req = new SQLiteCommand("INSERT INTO OPERATION(Type,designOp,dateOp,montantOp,deviseOp,numCompte,soldeOp) VALUES(@type,@designation,@dateOperation,@montant,@devise,@num,@solde)", con);
                req.Parameters.AddWithValue("@type", "Entrée");
                req.Parameters.AddWithValue("@designation", "dépôt initial");
                req.Parameters.AddWithValue("@dateOperation", DateTime.Now.ToString("yyyy-MM-dd"));
                req.Parameters.AddWithValue("@montant", montant);
                req.Parameters.AddWithValue("@devise", devise);
                req.Parameters.AddWithValue("@num", numCompte);
                req.Parameters.AddWithValue("@solde", montant);
                req.ExecuteNonQuery();
                disconnect();
                MessageBox.Show("Effectué avec succès!");

            }
            catch (SQLiteException ex)
           
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void updateCompte(int num, string intitule, double montant,string devise)
        {
            try
            {
                connect();
                req = new SQLiteCommand("UPDATE COMPTE SET intitule=@intitule,depotInit=@depot,deviseCompte=@devise,datecreateCompte=@date WHERE numCompte=@num", con);
                req.Parameters.AddWithValue("@intitule", intitule);
                req.Parameters.AddWithValue("@depot", montant);
                req.Parameters.AddWithValue("@devise", devise);
                req.Parameters.AddWithValue("@date", DateTime.Now.ToString("yyyy-MM-dd"));
                req.Parameters.AddWithValue("@num", num);
                DialogResult dlg = MessageBox.Show("Etes-vous sûr de vouloir modifier ce compte ?", "MODIFICATION", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dlg == DialogResult.Yes)
                {
                    req.ExecuteNonQuery();
                    MessageBox.Show("Effectué avec succès!");
                }
                else return;

            }
            catch (SQLiteException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void deleteCompte(int num)
        {
            try
            {
                connect();
                req = new SQLiteCommand("DELETE FROM COMPTE WHERE numCompte=@num", con);
                req.Parameters.AddWithValue("@num", num);
                DialogResult dlg = MessageBox.Show("Etes-vous sûr de vouloir supprimer définitivement ce compte ?", "SUPPRESSION", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dlg == DialogResult.Yes)
                {
                    req.ExecuteNonQuery();
                    MessageBox.Show("la suppression est effectuée avec succès!");
                }
                else return;

            }
            catch (SQLiteException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
