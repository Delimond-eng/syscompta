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
using System.Data.SQLite;
using FactureManagement.App;
using FactureManagement.Forms;

namespace FactureManagement.Forms
{
    public partial class FormCreationFacture : MetroFramework.Forms.MetroForm
    {
        #region Variables instances
            DataContext db = new DataContext();
            Facture facture = new Facture();
        #endregion
        public FormCreationFacture()
        {
            InitializeComponent();
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.None;
            LoadClient();
            TextDate.Value = DateTime.Now;
        }


        private void onclose(object sender, FormClosedEventArgs e)
        {
            lbfac.Text = "";
            lbTva.Text = "0,00";
            lbTtc.Text = "0,00";
            lbTotCumule.Text = "0,00";
            lbCdfAmount.Text = "0,00";
            DGVDetail.Rows.Clear();
            cleanFieldsDetail();
            cleanFieldsFacture();
            btnPrint.Enabled = false;
            GpItems.Enabled = false;
            GbFacture.Enabled = true;

        }

        private void cleanFieldsFacture()
        {
            cbClient.Text = null;
            TextNom.Text = "";
            DGVDetail.Rows.Clear();
            GbFacture.Enabled = true;
        }
        private void cleanFieldsDetail()
        {
            TextDesign.Text = "";
            TextQte.Text = "";
            TextPu.Text = "";
        }

        private void LoadClient()
        {
            try
            {
                db.connect();
                db.req = new SQLiteCommand("SELECT nomCli FROM CLIENT", db.con);
                db.dr = db.req.ExecuteReader();

                while (db.dr.Read())
                {
                    cbClient.Items.Add(db.dr[0].ToString());
                }
                db.disconnect();
            }
            catch (Exception) { }
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {

        }

        private void btnCreateFacture_Click(object sender, EventArgs e)
        {
            string[] fields = { cbClient.Text };
            app.checkFields(fields);
            if (app.FieldsEmpty) return;
            try
            {
                db.connect();
                db.req = new SQLiteCommand("SELECT montantTaux FROM TAUX", db.con);
                double taux = Convert.ToDouble(db.req.ExecuteScalar().ToString());
                db.disconnect();
                if (taux <= 0)
                {
                    MessageBox.Show("vous devez mettre à jour le taux du jour dans la section tableau de bord pour effectuer cette opération", "Désolé !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.Close();
                }
                else
                {
                    facture.CreateFacture(cbClient.Text, TextDate.Value, lbfac);
                    cbClient.Text = null;
                    label2.Visible = true;
                    GbFacture.Enabled = false;
                    DGVDetail.Rows.Clear();
                    GpItems.Enabled = true;
                    btnPrint.Enabled = false;
                }
            }
            catch (Exception) { }

        }
            
        private void ShowDetail()
        {
            DGVDetail.Rows.Clear();
            try
            {
                db.connect();
                db.req = new SQLiteCommand("SELECT * FROM FACTURE_DETAIL WHERE numFac='" + lbfac.Text+"' ",db.con);
                db.dr = db.req.ExecuteReader();
                int order = 0;
                while (db.dr.Read())
                {
                    decimal qte = Convert.ToDecimal(db.dr["qte"].ToString());
                    double pu = double.Parse(db.dr["pu"].ToString());
                    string devise = "";

                    if(db.dr["devisedetail"].ToString() == "usd") { devise = " $"; }
                    else { devise = " cdf"; }
                    double pt = Convert.ToDouble(qte) * pu;
                    DGVDetail.Rows.Add(order += 1, db.dr["designation"].ToString(), qte,pu.ToString() + " " + devise, pt.ToString() + " " + devise);
                }
                db.disconnect();
            }
            catch (Exception){ }
        }

        private void btnAddDetail_Click(object sender, EventArgs e)
        {
            if (lbfac.Text == "")
            {
                MessageBox.Show("Vous devez créer la facture avant d'ajouter des détails");
                return;
            }
            string[] fields = { TextDesign.Text, TextQte.Text, TextPu.Text };
            app.checkFields(fields);
            if (app.FieldsEmpty) return;
            try
            {
                facture.addDetail(lbfac.Text, TextDesign.Text, decimal.Parse(TextQte.Text), double.Parse(TextPu.Text), cbDevise.Text);
                double converPuTodollars = app.convertCdfToDollars(double.Parse(TextPu.Text));
                if (cbDevise.Text == "cdf")
                {
                    facture.updateAmount(lbfac.Text,
                        converPuTodollars,
                        int.Parse(TextQte.Text),
                        cbDevise.Text,
                        chkTva,
                        lbTotCumule,
                        lbTva, lbTtc
                    );
                }
                else
                {
                    facture.updateAmount(lbfac.Text,
                        double.Parse(TextPu.Text),
                        decimal.Parse(TextQte.Text),
                        cbDevise.Text,
                        chkTva,
                        lbTotCumule,
                        lbTva, lbTtc
                    );
                }
                cleanFieldsDetail();
                ShowDetail();
                facture.SelectMontantFacture(lbfac.Text, lbCdfAmount);
                btnPrint.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        

       
        private void btnPrint_Click(object sender, EventArgs e)
        {
            btnPrint.Enabled = false;
            if (TextFonction.Text=="" && TextNom.Text=="")
            {
                MessageBox.Show("vous devez insérer le nom et la fonction du signataire de la facture avant d'effectuer cette opération", "le nom et la fonction du signataire de la facture sont requises", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TextNom.Focus();
                btnPrint.Enabled = true;
            }
            else
            {
                if (chkTva.Checked)
                {
                    FormReportFacture frm = new FormReportFacture(lbfac.Text, TextNom.Text, TextFonction.Text, lbTva.Text, lbTotCumule.Text);
                    frm.FormClosed += new FormClosedEventHandler(onclose);
                    frm.ShowDialog();
                }
                else
                {
                    FormReportFacture frm = new FormReportFacture(lbfac.Text, TextNom.Text, TextFonction.Text, " $ 0,00", lbTotCumule.Text);
                    frm.FormClosed += new FormClosedEventHandler(onclose);
                    frm.ShowDialog();
                }
            }
            
            
        }

        private void btnAnnuler_Click_1(object sender, EventArgs e)
        {
            cbClient.Text = null;
        }

        string idDetail = "";
        private void DGVDetail_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DGVDetail.SelectedRows.Count > 0)
            {
                TextDesign.Text = DGVDetail.CurrentRow.Cells[1].Value.ToString();
                TextQte.Text = DGVDetail.CurrentRow.Cells[2].Value.ToString();
                TextPu.Text = DGVDetail.CurrentRow.Cells[3].Value.ToString().Replace("$","");

                db.connect();
                db.req = new SQLiteCommand("SELECT id FROM FACTURE_DETAIL WHERE designation='" + DGVDetail.CurrentRow.Cells[1].Value.ToString() + "' AND numFac='"+lbfac.Text+"'", db.con);
                int id = int.Parse(db.req.ExecuteScalar().ToString());
                idDetail = id.ToString();
            }
        }

        private void btnEditDetail_Click(object sender, EventArgs e)
        {
          
            //string[] fields = { idDetail, TextDesign.Text, TextPu.Text, cbDevise.Text };
            //app.checkFields(fields);
            //if (app.FieldsEmpty) return;
            //facture.modifyDetail(idDetail, TextDesign.Text, int.Parse(TextQte.Text), double.Parse(TextPu.Text), cbDevise.Text);
            //double converPuTodollars = app.convertCdfToDollars(double.Parse(TextPu.Text));
            //if (cbDevise.Text == "cdf")
            //{
            //    facture.updateAmount(lbfac.Text,
            //        converPuTodollars,
            //        int.Parse(TextQte.Text),
            //        cbDevise.Text,
            //        chkTva,
            //        lbTotCumule,
            //        lbTva, lbTtc
            //    );
            //}
            //else
            //{
            //    facture.updateAmount(lbfac.Text,
            //        double.Parse(TextPu.Text),
            //        int.Parse(TextQte.Text),
            //        cbDevise.Text,
            //        chkTva,
            //        lbTotCumule,
            //        lbTva, lbTtc
            //    );
            //}
            //cleanFieldsDetail();
            //ShowDetail();
            //facture.SelectMontantFacture(lbfac.Text, lbCdfAmount);
            //btnPrint.Enabled = true;
        }

        private void FormCreationFacture_Load(object sender, EventArgs e)
        {

        }
    }
}
