using FactureManagement.App;
using FactureManagement.Datas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FactureManagement.Forms
{
    public partial class FormDetailCompte : MetroFramework.Forms.MetroForm
    {
        #region variables
        DataContext db = new DataContext();
        Compte compte = new Compte();
        #endregion
        public FormDetailCompte(int numCompte)
        {
            InitializeComponent();
            refreshGrid(numCompte);
            selectSolde(numCompte);
            
        }

        private void selectSolde(int num)
        {
            try
            {
                db.connect();
                db.req = new SQLiteCommand("SELECT DISTINCT soldeCompte,deviseCompte FROM COMPTE WHERE numCompte="+num+"", db.con);
                db.dr = db.req.ExecuteReader();
                //Loop
                string devise = "";
                while (db.dr.Read())
                {
                    if (db.dr["deviseCompte"].ToString() == "usd")
                    {
                        devise = "$";
                    }
                    else devise = db.dr["devise"].ToString();
                    lbSolde.Text = "Solde : " + app.currency(double.Parse(db.dr["soldeCompte"].ToString())) + " " + devise;
                }
                db.disconnect();
            }
            catch (Exception ex)
            { Console.WriteLine(ex.Message); }
        }

        private void refreshGrid(int num)
        {
            DGVDetail.Rows.Clear();
            try
            {
                db.connect();
                db.req = new SQLiteCommand("SELECT * FROM OPERATION INNER JOIN COMPTE ON OPERATION.numCompte = COMPTE.numCompte WHERE OPERATION.numCompte="+num+"", db.con);
                db.dr = db.req.ExecuteReader();
                int order = 0;
                //Loop
                string devise = "";
                while (db.dr.Read())
                {
                    if (db.dr["deviseCompte"].ToString() == "usd")
                    {
                        devise = "$";
                    }
                    else devise = db.dr["deviseCompte"].ToString();
                    DGVDetail.Rows.Add(
                        order += 1,
                        Convert.ToDateTime(db.dr["dateOp"].ToString()).ToShortDateString(),
                        db.dr["designOp"].ToString(),
                        app.currency(double.Parse(db.dr["montantOp"].ToString())) + " " + devise,
                        db.dr["Type"].ToString()
                    );
                }
                db.disconnect();
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); ; }
        }

    }

   
}
