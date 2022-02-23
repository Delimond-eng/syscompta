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
    class Facture : DataContext
    {

        public void addDetail(string numFac, string design, decimal qte, double pu, string devise)
        {
            try
            {
                
                connect();
                req = new SQLiteCommand("INSERT INTO FACTURE_DETAIL(numFac,designation,qte,pu,devisedetail) VALUES(@num,@designation,@qte,@pu,@devise)", con);
                req.Parameters.AddWithValue("@num", numFac);
                req.Parameters.AddWithValue("@designation", design);
                req.Parameters.AddWithValue("@qte", Convert.ToDouble(qte));
                req.Parameters.AddWithValue("@pu", pu);
                req.Parameters.AddWithValue("@devise", devise);
                req.ExecuteNonQuery();
                disconnect();

            }
            catch (SQLiteException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void updateAmount(string numFacture, double pu, decimal qte, string devise, Guna.UI.WinForms.GunaCheckBox chk,Label TotAmount, Label lTva, Label lTtc)
        {
            try
            {
                connect();
                req = new SQLiteCommand("SELECT montantFac FROM FACTURE WHERE numFac='" + numFacture + "'", con);
                double LastAmount = double.Parse(req.ExecuteScalar().ToString());
                double Amount = Convert.ToDouble(qte) * pu;
                double currentAmount = LastAmount + Amount;
                double tva = currentAmount * 16 / 100;
                double TTC = currentAmount + tva;
                double arrountTtc = Math.Round(TTC);
                double arroundCurrentAmount = currentAmount;
                TotAmount.Text = arroundCurrentAmount.ToString() + " $";
                req = new SQLiteCommand("UPDATE FACTURE SET montantFac=@montant, deviseFac=@devise WHERE numFac='" + numFacture + "'", con);
                if (chk.Checked==true)
                {
                    req.Parameters.AddWithValue("@montant", arrountTtc);
                    req.Parameters.AddWithValue("@devise", "usd");
                    req.ExecuteNonQuery();
                    disconnect();
                    lTva.Text ="$ "+ tva.ToString();
                    lTtc.Text ="$ "+ arrountTtc.ToString();

                }
                else
                {
                    req.Parameters.AddWithValue("@montant", arroundCurrentAmount);
                    req.Parameters.AddWithValue("@devise", "usd");
                    req.ExecuteNonQuery();
                    disconnect();
                    lTva.Text = "$ "+ "0,00";
                    lTtc.Text = "$ " + arroundCurrentAmount.ToString();
                }
                
            }
            catch (Exception) { }
           
        }
        public void modifyDetail(string id, string design, int qte, double pu, string devise)
        {
            try
            {
                connect();
                req = new SQLiteCommand("UPDATE FACTURE_DETAIL SET designation=@designation,qte=@qte,pu=@pu, devisedetail=@devise WHERE id=@id", con);
                req.Parameters.AddWithValue("@pu", pu);
                req.Parameters.AddWithValue("@designation", design);
                req.Parameters.AddWithValue("@qte", qte);
                req.Parameters.AddWithValue("@devise", devise);
                req.Parameters.AddWithValue("@id", id);

                DialogResult dlg = MessageBox.Show("Etes-vous sûr de vouloir modifier l'item sélectionné?", "MODIFICATION", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dlg == DialogResult.Yes)
                {
                    req.ExecuteNonQuery();
                    disconnect();
                    MessageBox.Show("Effectué avec succès!");
                }
                else return;
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void CreateFacture(string client,DateTime datecreate, Label lb)
        {
            try
            {
                string numFacture = app.GenerateRandomCode();
                connect();
                req = new SQLiteCommand("SELECT idcli FROM CLIENT WHERE nomcli='" + client + "'", con);
                string idclient = req.ExecuteScalar().ToString();
                req = new SQLiteCommand("SELECT idconfig FROM CONFIG ORDER BY idconfig DESC", con);
                int id = int.Parse(req.ExecuteScalar().ToString());
                req = new SQLiteCommand("INSERT INTO FACTURE(numFac,datecreateFac,montantFac,devisefac,idcli,idconfig) VALUES(@num,@datecreate,@amount,@devise,@idclient,@config)", con);
                req.Parameters.AddWithValue("@num", numFacture);
                req.Parameters.AddWithValue("@datecreate", datecreate.ToString("yyyy-MM-dd"));
                req.Parameters.AddWithValue("@amount", 0);
                req.Parameters.AddWithValue("@devise", "usd");
                req.Parameters.AddWithValue("@idclient", idclient);
                req.Parameters.AddWithValue("@config", id);
                req.ExecuteNonQuery();
                disconnect();
                lb.Text = numFacture;
                MessageBox.Show("Effectué avec succès!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void SelectMontantFacture(string numFac, Label lb)
        {
            try
            {
                connect();
                req = new SQLiteCommand("SELECT montantFac FROM FACTURE WHERE numFac='" + numFac + "'", con);
                double Amount =(double) req.ExecuteScalar();
                disconnect();
                double cdfAmount = app.convertDollarsToCdf(Amount);
                lb.Text = "cdf "+ app.currency(cdfAmount);
            }
            catch (Exception){ }
        }
    }
}
