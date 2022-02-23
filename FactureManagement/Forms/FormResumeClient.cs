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
    public partial class FormResumeClient : MetroFramework.Forms.MetroForm
    {
        #region variables instance
        Paiement paiement = new Paiement();
        DataContext db = new DataContext();
        #endregion
        public FormResumeClient()
        {
            InitializeComponent();
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.None;
            refreshGrid();
        }
        private string totatMontant(string nomcli)
        {
            string Sum = "0,00";
            try
            {
                db.connect();
                db.req = new SQLiteCommand("SELECT SUM(montantFac) AS Amount FROM FACTURE INNER JOIN CLIENT ON FACTURE.idcli=CLIENT.idcli WHERE CLIENT.nomcli=@nomclient", db.con);
                db.req.Parameters.AddWithValue("@nomclient", nomcli);
                db.dr = db.req.ExecuteReader();
                while (db.dr.Read())
                {
                    Sum = app.currency(double.Parse(db.dr["Amount"].ToString()));
                }
                db.disconnect();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return Sum;
        }
        private string totalMontPaie(string nomcli)
        {
            string Sum = "0,00";
            try
            {
                db.connect();
                db.req = new SQLiteCommand("SELECT SUM(montantpaie) AS Amount FROM PAIEMENT INNER JOIN FACTURE ON PAIEMENT.numFac=FACTURE.numFac INNER JOIN CLIENT ON FACTURE.idcli=CLIENT.idcli WHERE CLIENT.nomcli=@nomclient", db.con);
                db.req.Parameters.AddWithValue("@nomclient", nomcli);
                db.dr = db.req.ExecuteReader();
                while (db.dr.Read())
                {
                    Sum = app.currency(double.Parse(db.dr["Amount"].ToString()));
                }
                db.disconnect();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return Sum;
        }
        private void refreshGrid()
        {
            try
            {
                DGV.Rows.Clear();
                db.connect();
                db.req = new SQLiteCommand("SELECT CLIENT.nomcli,CLIENT.idcli FROM CLIENT INNER JOIN FACTURE ON CLIENT.idcli = FACTURE.idcli INNER JOIN PAIEMENT ON FACTURE.numFac = PAIEMENT.numFac GROUP BY CLIENT.nomcli", db.con);
                db.dr = db.req.ExecuteReader();
                //Loop
                var nums = new List<KeyValuePair<int, string>>();

                while (db.dr.Read())
                {
                    nums.Add(new KeyValuePair<int, string>(int.Parse(db.dr["idcli"].ToString()), db.dr["nomcli"].ToString()));
                }
                int order = 0;
                foreach (var Client in nums)
                {
                    string nomcli = Client.Value;
                    double restAmount = Convert.ToDouble(totatMontant(nomcli)) - Convert.ToDouble(totalMontPaie(nomcli));
                    DGV.Rows.Add(
                        order += 1,
                        Client.Value,
                        totatMontant(nomcli) + " $",
                        totalMontPaie(nomcli) + " $",
                        app.currency(restAmount) + " $"
                    );
                }

                db.disconnect();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void filter()
        {
            try
            {
                DGV.Rows.Clear();
                db.connect();
                db.req = new SQLiteCommand("SELECT CLIENT.nomcli, CLIENT.idcli FROM CLIENT INNER JOIN FACTURE ON CLIENT.idcli = FACTURE.idcli INNER JOIN PAIEMENT ON FACTURE.numFac = PAIEMENT.numFac WHERE CLIENT.nomcli LIKE '%" + TextSearch.Text+"%' GROUP BY CLIENT.nomcli", db.con);
                db.dr = db.req.ExecuteReader();
                //Loop
                //Loop
                var nums = new List<KeyValuePair<int, string>>();

                while (db.dr.Read())
                {
                    nums.Add(new KeyValuePair<int, string>(int.Parse(db.dr["idcli"].ToString()), db.dr["nomcli"].ToString()));
                }
                int order = 0;

                foreach (var Client in nums)
                {
                    string nomcli = Client.Value;
                    double restAmount = Convert.ToDouble(totatMontant(nomcli)) - Convert.ToDouble(totalMontPaie(nomcli));
                    DGV.Rows.Add(
                        order += 1,
                        nomcli,
                        totatMontant(nomcli) + " $",
                        totalMontPaie(nomcli) + " $",
                        restAmount+ " $"
                    );
                }

                db.disconnect();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void viewDetail()
        {
            try
            {
                string nomcli = DGV.CurrentRow.Cells[1].Value.ToString();
                FormDetailClient detail = new FormDetailClient(nomcli);
                detail.lbClient.Text ="Client : "+ nomcli.ToUpper();
                detail.ShowDialog();
            }
            catch (Exception){}
            
        }

        private void btnAfficher_Click(object sender, EventArgs e)
        {
            viewDetail();
        }

        private void DGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            viewDetail();
        }

        private void TextSearch_TextChanged(object sender, EventArgs e)
        {
            filter();
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            new FormPrintDetail().ShowDialog();
        }
    }
}
