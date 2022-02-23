using FactureManagement.Datas;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FactureManagement.App;
using System.Data.SQLite;

namespace FactureManagement.Forms
{
    public partial class FormSyntheseCompte : MetroFramework.Forms.MetroForm
    {

        #region variables
        DataContext db = new DataContext();
        Compte compte = new Compte();
        #endregion
        public FormSyntheseCompte()
        {
            InitializeComponent();
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.None;
            refreshGrid();
        }

        private string viewSum(string type, int num)
        {
            string somme = "0,00";
            try
            {
                db.connect();
                db.req = new SQLiteCommand("SELECT SUM(montantOp) as Montant FROM OPERATION INNER JOIN COMPTE ON OPERATION.numCompte=COMPTE.numCompte WHERE Type='"+type+"' AND OPERATION.numCompte="+num+" GROUP BY COMPTE.numCompte", db.con);
                db.dr = db.req.ExecuteReader();
                while (db.dr.Read())
                {
                    somme = app.currency(double.Parse(db.dr["Montant"].ToString()));
                }
               
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return somme;
        }

        string devise = "";
        private string viewSolde(int num)
        {
            string solde = "";
            
            try
            {
                db.connect();
                db.req = new SQLiteCommand("SELECT DISTINCT soldeCompte,deviseCompte FROM COMPTE WHERE numCompte=" + num + "", db.con);
                db.dr = db.req.ExecuteReader();
                
                while (db.dr.Read())
                {

                    if (db.dr["deviseCompte"].ToString() == "usd")
                    {
                        devise = "$";
                    }
                    else { devise = db.dr["deviseCompte"].ToString(); }
                    solde = app.currency((double)db.dr["soldeCompte"]) +" "+ devise;
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return solde;
        }

        private void refreshGrid()
        {
            try
            {
                DGV.Rows.Clear();
                db.connect();
                db.req = new SQLiteCommand("SELECT DISTINCT COMPTE.numCompte,intitule,deviseCompte FROM COMPTE INNER JOIN OPERATION ON COMPTE.numCompte=OPERATION.numCompte", db.con);
                db.dr = db.req.ExecuteReader();
                //Loop

                var nums = new List<KeyValuePair<string, int>>();
                
                while (db.dr.Read())
                {
                    int numCompte = int.Parse(db.dr["numCompte"].ToString());
                    nums.Add(new KeyValuePair<string, int>(db.dr["intitule"].ToString(), numCompte));

                }
                int order = 0;

                foreach (var numCompte in nums)
                {
                   
                    DGV.Rows.Add(
                        order += 1,
                        numCompte.Key,
                        viewSum("Entrée", numCompte.Value),
                        viewSum("Sortie", numCompte.Value),
                        viewSolde(numCompte.Value)
                    );
                }

                db.disconnect();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        private void filter()
        {
            try
            {
                DGV.Rows.Clear();
                db.connect();
                db.req = new SQLiteCommand("SELECT DISTINCT numCompte,intitule FROM COMPTE INNER JOIN OPERATION ON COMPTE.numCompte=OPERATION.numCompte WHERE COMPTE.intitule LIKE '%" + TextSearch.Text+"%'", db.con);
                db.dr = db.req.ExecuteReader();
                
                var nums = new List<KeyValuePair<string, int>>();
                //Loop
                while (db.dr.Read())
                {
                    int numCompte = (int)db.dr["COMPTE.numCompte"];
                    nums.Add(new KeyValuePair<string, int>(db.dr["intitule"].ToString(), numCompte));

                }
                int order = 0;

                foreach (var numCompte in nums)
                {

                    DGV.Rows.Add(
                        order += 1,
                        numCompte.Key,
                        viewSum("Entrée", numCompte.Value),
                        viewSum("Sortie", numCompte.Value),
                        viewSolde(numCompte.Value)
                    );
                }

                db.disconnect();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void DGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            viewDetail();
        }

        private void viewDetail()
        {
            try
            {
                string intitule = DGV.CurrentRow.Cells[1].Value.ToString();
                db.connect();
                db.req = new SQLiteCommand("SELECT numCompte FROM COMPTE WHERE intitule='" + intitule + "' ", db.con);
                int numC = int.Parse(db.req.ExecuteScalar().ToString());
                FormDetailCompte detail = new FormDetailCompte(numC);
                detail.lbCount.Text = intitule.ToUpper();
                detail.ShowDialog();
                db.disconnect(); 
            }
            catch (Exception ex)
            { Console.WriteLine(ex.Message); }

        }

        private void btnAfficher_Click(object sender, EventArgs e)
        {
            viewDetail();
        }

        private void TextSearch_TextChanged(object sender, EventArgs e)
        {
            filter();
        }
    }
}
