using FactureManagement.App;
using FactureManagement.Datas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FactureManagement.Forms
{
    public partial class FormOperation : MetroFramework.Forms.MetroForm
    {
        #region variables
        DataContext db = new DataContext();
        Compte compte = new Compte();
        Mouvement operation = new Mouvement();
        #endregion
        public FormOperation()
        {
            InitializeComponent();
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.None;
            viewAllAccount();
            GpAction.Visible = false;
            GpWrite.Visible = false;
        }

        private void viewAllAccount()
        {
            try
            {
                cbCompte.Items.Clear();
                db.connect();
                db.req = new SQLiteCommand("SELECT intitule FROM COMPTE", db.con);
                db.dr = db.req.ExecuteReader();
                //Loop
                while (db.dr.Read())
                {
                    cbCompte.Items.Add(
                        db.dr[0].ToString()
                    );
                }
                db.disconnect();
            }
            catch (Exception) {}
        }

        private void SelectCompte()
        {
            try
            {
                db.connect();
                db.req = new SQLiteCommand("SELECT * FROM COMPTE WHERE intitule='"+ cbCompte.Text+"'", db.con);
                db.dr = db.req.ExecuteReader();
                //Loop
                while (db.dr.Read())
                {
                    lbNumCompte.Text = db.dr["numCompte"].ToString();
                    lbIntitule.Text = db.dr["intitule"].ToString();
                }
                db.disconnect();
            }
            catch (Exception) { }
        }

        private void clearField()
        {
            TextDesign.Text = "";
            TextMontant.Text = "";
            TextObs.Text = "";
            cbDevise.Text = null;
        }

        private void viewOperation(int num, string type)
        {
            DGVTirage.Rows.Clear();
            try
            {
                db.connect();
                db.req = new SQLiteCommand("SELECT * FROM OPERATION INNER JOIN COMPTE ON OPERATION.numCompte = COMPTE.numCompte WHERE OPERATION.numCompte="+num+ " AND OPERATION.Type='"+type+"' ", db.con);
                db.dr = db.req.ExecuteReader();
                int order = 0;
                //Loop
                while (db.dr.Read())
                {
                    DGVTirage.Rows.Add(
                        order += 1,
                        Convert.ToDateTime(db.dr["dateOp"].ToString()).ToShortDateString(),
                        db.dr["designOp"].ToString(),
                        app.currency((double)db.dr["montantOp"]) +" "+ db.dr["deviseCompte"].ToString(),
                        app.currency((double)db.dr["soldeOp"])+" "+ db.dr["deviseCompte"].ToString(),
                        db.dr["Obs"].ToString()
                    );
                }
                db.disconnect();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            string[] field = { lbNumCompte.Text, GpWrite.Text, TextMontant.Text,cbDevise.Text };
            app.checkFields(field);
            if (app.FieldsEmpty) return;
            operation.ValidateOperation(
                GpWrite.Text, 
                TextDesign.Text,
                double.Parse(TextMontant.Text),
                cbDevise.Text,
                int.Parse(lbNumCompte.Text),
                TextObs.Text
            );
            clearField();
            int numCompte = int.Parse(lbNumCompte.Text);
            string typeOperation = GpWrite.Text;
            viewOperation(numCompte, typeOperation);
        }

        private void btnEntree_Click_1(object sender, EventArgs e)
        {

            GpWrite.LineColor = Color.FromArgb(72, 152, 207);
            GpWrite.BorderColor = Color.FromArgb(72, 152, 207);
            TextDesign.BorderColor = Color.FromArgb(72, 152, 207);
            TextMontant.BorderColor = Color.FromArgb(72, 152, 207);
            cbDevise.BorderColor = Color.FromArgb(72, 152, 207);
            TextObs.BorderColor = Color.FromArgb(72, 152, 207);
            btnValider.BaseColor = Color.FromArgb(72, 152, 207);
            btnValider.OnHoverBaseColor = Color.SkyBlue;
            DGVTirage.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(72, 152, 207);
            DGVTirage.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            GpWrite.Text = "Entrée";
            SelectCompte();
            int numCompte = int.Parse(lbNumCompte.Text);
            string typeOperation = GpWrite.Text;
            GpWrite.Visible = true;
            viewOperation(numCompte, typeOperation);
        }

        private void btnSortie_Click_1(object sender, EventArgs e)
        {
            GpWrite.LineColor = Color.LightCoral;
            GpWrite.BorderColor = Color.LightCoral;
            TextDesign.BorderColor = Color.LightCoral;
            TextMontant.BorderColor = Color.LightCoral;
            cbDevise.BorderColor = Color.LightCoral;
            TextObs.BorderColor = Color.LightCoral;
            btnValider.BaseColor = Color.LightCoral;
            btnValider.OnHoverBaseColor = Color.FromArgb(255,192,192);
            DGVTirage.ColumnHeadersDefaultCellStyle.BackColor = Color.LightCoral;
            DGVTirage.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            GpWrite.Text = "Sortie";
            SelectCompte();
            int numCompte = int.Parse(lbNumCompte.Text);
            string typeOperation = GpWrite.Text;
            GpWrite.Visible = true;
            viewOperation(numCompte, typeOperation);
        }

        private void cbCompte_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbIntitule.Text = cbCompte.Text;
            GpAction.Visible = true;
        }
    }
}
