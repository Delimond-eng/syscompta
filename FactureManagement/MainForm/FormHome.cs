using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FactureManagement.Datas;
using FactureManagement.Forms;
using System.Data.SQLite;

namespace FactureManagement.MainForm
{
    public partial class FormHome : MetroFramework.Forms.MetroForm
    {
        Statistique stat = new Statistique();
        DataContext db = new DataContext();
        public FormHome()
        {
            InitializeComponent();
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.None;
            count();
            refreshTaux();
            GetAlert();

            //DateTime start = new DateTime(2021, 1, 18);
            //DateTime end = new DateTime(2021, 01, 19);

            //TimeSpan difference = end - start; //create TimeSpan object

            //Console.WriteLine("Difference in days: " + difference.Days);
        }

        private void count()
        {
            lbClient.Text = "0" + stat.count("CLIENT", "idCli");
            lbFacEtabli.Text = "0" + stat.count("FACTURE", "numFac");
            lbFacJour.Text = "0" + stat.countWhereDate();
            lbFacPaie.Text = "0" + stat.countWhere("FACTURE", "numFac", "statut", "Payé");
            lbFacAttente.Text = "0" + stat.countOrWhere("FACTURE","numFac","statut", "En_Attente", "Paiement partiel");
        }

        private void refreshTaux()
        {
            try
            {
                db.connect();
                db.req = new SQLiteCommand("SELECT * FROM TAUX", db.con);
                db.dr = db.req.ExecuteReader();
                while (db.dr.Read())
                {
                    lbTaux.Text = db.dr["montantTaux"].ToString();
                }
                db.disconnect();
            }
            catch (SQLiteException ex){
                Console.WriteLine(ex.Message);
                Console.ReadLine();
            }
        }

        private void btnActualiserTaux_Click(object sender, EventArgs e)
        {
            stat.changeTaux(double.Parse(TextTaux.Text));
            refreshTaux();
            TextTaux.Text = "";
        }

        private void GetAlert()
        {
            try
            {
                db.connect();
                db.req = new SQLiteCommand("SELECT idconfig FROM CONFIG", db.con);
                db.dr = db.req.ExecuteReader();
                if (db.dr.HasRows)
                {
                    lbAlert.Visible = false;
                    db.disconnect();
                }
                else
                {
                    lbAlert.Visible = true;
                    lbAlert.ForeColor = Color.Crimson;
                    db.disconnect();
                }
            }
            catch (Exception){}
        }

        private void guna2ShadowPanel3_Click(object sender, EventArgs e)
        {
            FormFactureEnCours  frm = new FormFactureEnCours();
            frm.ShadowType = MetroFramework.Forms.MetroFormShadowType.Flat;
            frm.Style = MetroFramework.MetroColorStyle.Blue;
            frm.ShowDialog();
        }

        private void guna2ShadowPanel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2ShadowPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gunaTileButton3_Click(object sender, EventArgs e)
        {
            FormFactureEnCours frm = new FormFactureEnCours();
            frm.ShadowType = MetroFramework.Forms.MetroFormShadowType.Flat;
            frm.Style = MetroFramework.MetroColorStyle.Blue;
            frm.ShowDialog();
        }

        private void gunaTileButton2_Click(object sender, EventArgs e)
        {
            new FormFacturePayer().ShowDialog();
        }

        private void guna2ShadowPanel2_Click(object sender, EventArgs e)
        {
            new FormFacturePayer().ShowDialog();
        }
    }
}
