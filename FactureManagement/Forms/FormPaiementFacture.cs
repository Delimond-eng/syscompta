using FactureManagement.App;
using FactureManagement.Datas;
using System;
using System.Data.SQLite;
using System.Windows.Forms;

namespace FactureManagement.Forms
{
    public partial class FormPaiementFacture : MetroFramework.Forms.MetroForm
    {
        #region variables instance
            Paiement paiement = new Paiement();
            DataContext db = new DataContext();
        #endregion
        public FormPaiementFacture()
        {
            InitializeComponent();
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.None;
            viewAllOrder();
            paiement.AddItemsCombo(cbClient,"SELECT nomcli FROM CLIENT", "nomcli");
            paiement.AddItemsCombo(cbCompte, "SELECT intitule FROM COMPTE", "intitule");
        }

        private void cbClient_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbFacture.Items.Clear();
            paiement.AddItemsCombo(cbFacture,"SELECT numFac FROM FACTURE INNER JOIN CLIENT ON FACTURE.idcli=CLIENT.idcli WHERE CLIENT.nomcli='"+cbClient.Text+ "' ORDER BY FACTURE.idcli DESC", "numFac");
        }

        private void cbFacture_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbAmountPay.Text = "";lbClient.Text = ""; lbMontant.Text = "";lbRestToPay.Text = "";
            lbStatut.Text = "";
            try
            {
                db.connect();
                db.req = new SQLiteCommand("SELECT nomcli,montantFac,devisefac,statut FROM FACTURE INNER JOIN CLIENT ON FACTURE.idcli=CLIENT.idcli WHERE FACTURE.numFac='" + cbFacture.Text + "' ", db.con);
                db.dr = db.req.ExecuteReader();
                string devise = "";
                if (db.dr.Read())
                {
                    lbClient.Text = db.dr["nomcli"].ToString();
                    if (db.dr["devisefac"].ToString() == "usd")
                    {
                        devise = " $";
                    }
                    else { devise = db.dr["devisefac"].ToString(); }
                    lbMontant.Text = (double)db.dr["montantFac"] + " " + devise;
                    lbStatut.Text = db.dr["statut"].ToString();
                }
                db.dr.Close();
                db.disconnect();
                selectSumPaie();
                SelectRecentRestAmount();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            
        }
        private void selectSumPaie()
        {
            try
            {
                db.connect();
                db.req = new SQLiteCommand("SELECT SUM(montantpaie) AS payAmount FROM PAIEMENT WHERE numFac='" + cbFacture.Text + "' GROUP BY numFac", db.con);
                db.dr = db.req.ExecuteReader();
                while (db.dr.Read())
                {
                    lbAmountPay.Text = (double)db.dr["payAmount"] + " $";
                }
                db.dr.Close();
                db.disconnect();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        private void SelectRecentRestAmount()
        {
            try
            {
                db.connect();
                db.req = new SQLiteCommand("SELECT montantres FROM PAIEMENT WHERE numFac='" + cbFacture.Text + "' ORDER BY numpaie ASC", db.con);
                db.dr = db.req.ExecuteReader();
                double restAmount = 0;
                while (db.dr.Read())
                {
                    lbRestToPay.Text = (double)db.dr["montantres"] + " $";
                    restAmount = double.Parse(db.dr["montantres"].ToString());

                    if (restAmount == 0 && lbRestToPay.Text != "")
                    {
                        btnEffectuerPaie.Enabled = false;
                    }
                }
                db.dr.Close();
                db.disconnect();

                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void btnEffectuerPaie_Click(object sender, EventArgs e)
        {
            try
            {
                string[] fields = { cbClient.Text, cbFacture.Text, TextMontant.Text, cbCompte.Text, cbDevise.Text, cbModePaie.Text };
                app.checkFields(fields);
                if (app.FieldsEmpty) return;
                paiement.EffectuerPaiement(
                    Convert.ToDecimal(TextMontant.Text),
                    cbDevise.Text,
                    cbModePaie.Text,
                    cbFacture.Text,
                    cbCompte.Text
                );
                viewAllOrder();
                cleanField();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadLine();
            }
            
        }

        private void viewAllOrder()
        {
            DGVPaiement.Rows.Clear();
            try
            {
                db.connect();
                db.req = new SQLiteCommand("SELECT * FROM CLIENT INNER JOIN FACTURE ON CLIENT.idcli = FACTURE.idcli INNER JOIN PAIEMENT ON FACTURE.numFac = PAIEMENT.numFac ORDER BY PAIEMENT.numpaie DESC", db.con);
                db.dr = db.req.ExecuteReader();
                int order = 0;
                while (db.dr.Read())
                {
                    DGVPaiement.Rows.Add(order += 1,
                        Convert.ToDateTime(db.dr["datepaie"].ToString()).ToShortDateString(),
                        db.dr["nomcli"].ToString(),
                        db.dr["numFac"].ToString(),
                        app.currency((double)db.dr["montantpaie"]) + " "+ db.dr["devisepaie"].ToString(),
                        app.currency((double)db.dr["montantres"]) + " " + db.dr["devisepaie"].ToString(),
                        db.dr["modepaie"].ToString()
                    );
                }
                db.disconnect();
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); Console.ReadLine(); }
        }

        private void cleanField()
        {
            cbClient.Text = null;
            cbDevise.Text = null;
            cbFacture.Text = null;
            cbModePaie.Text = null;
            cbCompte.Text = null;
            TextMontant.Text = "";
            lbClient.Text = "";
            lbMontant.Text = "";
            lbAmountPay.Text = "";
            lbRestToPay.Text = "";
            lbStatut.Text = "";

        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            cleanField();
        }
    }
}
