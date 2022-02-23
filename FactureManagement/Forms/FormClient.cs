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
using FactureManagement.App;
using MetroFramework.Forms;
using System.Data.SQLite;

namespace FactureManagement.Forms
{
    public partial class FormClient : MetroFramework.Forms.MetroForm
    {
        //instance de la classe de connexion aux données
        #region variables
            DataContext db = new DataContext();
            Client client = new Client();
            private string nom = "";
        #endregion
        public FormClient()
        {
            InitializeComponent();
            this.ShadowType = MetroFormShadowType.None;
            Guna.UI.Lib.GraphicsHelper.DrawLineShadow(this, Color.Black, 20, 5, Guna.UI.WinForms.VerHorAlign.HoriziontalTop);
            //initializeGrid
            refreshGrid();
        }

        //refresh list
        private void refreshGrid()
        {
            try
            {
                DGV.Rows.Clear();
                db.connect();
                db.req = new SQLiteCommand("SELECT * FROM CLIENT", db.con);
                db.dr = db.req.ExecuteReader();
                int order = 0;
                //Loop
                while (db.dr.Read())
                {
                    DGV.Rows.Add(order+=1,
                                 db.dr["nomCli"].ToString(),
                                 db.dr["adresse"].ToString(),
                                 db.dr["tel"].ToString(),
                                 db.dr["Email"].ToString(),
                                 Convert.ToDateTime(db.dr["datecreate"].ToString()).ToShortDateString()
                                 );
                }
                db.disconnect();
            }
            catch (Exception)
            {}
        }

        private void FiltrerClient()
        {
            try
            {
                DGV.Rows.Clear();
                db.connect();
                db.req = new SQLiteCommand("SELECT * FROM CLIENT WHERE nomCli LIKE '%" + TextSearch.Text + "%'", db.con);
                db.dr = db.req.ExecuteReader();
                int order = 0;
                //Loop
                while (db.dr.Read())
                {
                    DGV.Rows.Add(order +=1,
                                 db.dr["nomCli"].ToString(),
                                 db.dr["adresse"].ToString(),
                                 db.dr["tel"].ToString(),
                                 db.dr["Email"].ToString(),
                                 Convert.ToDateTime(db.dr["datecreate"].ToString()).ToShortDateString()
                    );
                }
                db.disconnect();
            }
            catch (Exception)
            {}
        }

        private void TextSearch_TextChanged(object sender, EventArgs e)
        {
            FiltrerClient();
        }

        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            string[] field = { TextNom.Text,TextPhone.Text };
            app.checkFields(field);
            if (app.FieldsEmpty) return;

            nom = TextNom.Text;
            client.Create(
                nom,
                TextAdresse.Text,
                TextPhone.Text,
                TextEmail.Text
            );
            refreshGrid();
            clean();
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            //initializ attributes
            string[] field = { lbId.Text, TextNom.Text, TextPhone.Text };
            app.checkFields(field);
            if (app.FieldsEmpty) return;

            client.Update(lbId.Text,
                TextNom.Text,
                TextAdresse.Text,
                TextPhone.Text,
                TextEmail.Text
            );
            refreshGrid();
            clean();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //initializ attributes
            string[] field = { lbId.Text };
            app.checkFields(field);
            if (app.FieldsEmpty) return;

            client.Delete(lbId.Text);
            refreshGrid();
            clean();
        }

        private void clean()
        {
            lbId.Text = "";
            TextNom.Text = "";
            TextPhone.Text = "";
            TextEmail.Text = "";
            TextAdresse.Text = "";
            TextNom.Focus();
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            clean();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            try
            {
                db.connect();
                db.req = new SQLiteCommand("SELECT idcli FROM CLIENT WHERE nomcli=@name", db.con);
                db.req.Parameters.AddWithValue("@name", DGV.CurrentRow.Cells[1].Value.ToString());
                string idclient = db.req.ExecuteScalar().ToString();
                Console.WriteLine(idclient);
                db.disconnect();
                if (DGV.SelectedRows.Count > 0)
                    lbId.Text = idclient;
                    TextNom.Text = DGV.CurrentRow.Cells[1].Value.ToString();
                    TextAdresse.Text= DGV.CurrentRow.Cells[2].Value.ToString();
                    TextPhone.Text= DGV.CurrentRow.Cells[3].Value.ToString();
                    TextEmail.Text= DGV.CurrentRow.Cells[4].Value.ToString();
            }
            catch (System.NullReferenceException)
            {
                MessageBox.Show("Veuillez sélectionner une ligne dans le Grid avant d'afficher les infomations");
            }
          

        }
    }
}
