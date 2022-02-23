using FactureManagement.App;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FactureManagement.Datas
{
    class Paiement : DataContext
    {
        Mouvement operation = new Mouvement();
        string statut = "";
        public void AddItemsCombo(ComboBox cb, string queries, string item)
        {
            cb.Items.Clear();
            try
            {
                connect();
                req = new SQLiteCommand(queries, con);
                dr = req.ExecuteReader();

                while (dr.Read())
                {
                    cb.Items.Add(dr[item].ToString());
                }
                disconnect();
            }
            catch { }
        }

        public void payer(double montantPayement, string devise, double montantRes, string modePaie, string numFac)
        {
            connect();
            req = new SQLiteCommand("INSERT INTO PAIEMENT(montantpaie,devisepaie,montantres,modepaie,datepaie,numFac) VALUES(@montantPaie,@devise,@montantres,@modepaie,@datepaie,@numFacture)", con);
            req.Parameters.AddWithValue("@montantPaie", montantPayement);
            req.Parameters.AddWithValue("@devise", devise);
            req.Parameters.AddWithValue("@montantres", montantRes);
            req.Parameters.AddWithValue("@modepaie", modePaie);
            req.Parameters.AddWithValue("@datePaie", DateTime.Now.ToString("yyyy-MM-dd"));
            req.Parameters.AddWithValue("@numFacture", numFac);
            req.ExecuteNonQuery();
            disconnect();
            MessageBox.Show("ok");
        }

        public void EffectuerPaiement(decimal montantPaie, string devise, string modePaie, string numFac, string compte)
        {
            try
            {
                connect();
                req = new SQLiteCommand("SELECT montantFac FROM FACTURE WHERE numFac='" + numFac + "'", con);
                double montantFacture = double.Parse(req.ExecuteScalar().ToString());
                double LastPayAmount = 0;
                double restAmount = 0;
                double montantPaieRes = 0;
                string currentStatus = "";
                req = new SQLiteCommand("SELECT montantpaie,montantres FROM PAIEMENT WHERE numFac='" + numFac + "' ORDER BY numpaie DESC", con);
                dr = req.ExecuteReader();
                if (dr.Read())
                {
                    LastPayAmount = double.Parse(dr["montantpaie"].ToString());
                    restAmount = double.Parse(dr["montantres"].ToString());
                    Console.WriteLine(LastPayAmount + "" + restAmount);
                }
                dr.Close();
                req = new SQLiteCommand("SELECT statut FROM FACTURE WHERE numFac='" + numFac + "'", con);
                currentStatus = req.ExecuteScalar().ToString();
                //Conversion du montant cdf en dollars si le compte est en dollars
                double montantconverti = 0;

                Console.WriteLine(currentStatus);
                if(currentStatus == "Payé")
                {
                    MessageBox.Show("Cette facture a été déjà payée à la totalité!", "Facture déjà payée", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else
                {
                    if (devise == "cdf")
                    {
                        montantconverti = app.convertCdfToDollars(Convert.ToDouble(montantPaie));
                        devise = "usd";
                    }
                    else
                    {
                        montantconverti = Convert.ToDouble(montantPaie);
                    }

                    if (restAmount==0  || restAmount.ToString()==null && currentStatus ==null || currentStatus=="")
                    {
                        montantPaieRes = montantFacture - montantconverti;
                    }
                    else if (restAmount > 0 && currentStatus == "Paiement partiel" && montantconverti <= restAmount )
                    {
                        montantPaieRes = restAmount - montantconverti;
                    }
                    else
                    {
                        MessageBox.Show("Le montant entré est supérieur au montant à payer, veuillez verifier le montant restant de la facture", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    if (montantconverti > montantFacture || montantPaieRes > montantFacture)
                    {
                        MessageBox.Show("Le montant entré est supérieur au montant à payer, veuillez verifier le montant restant de la facture", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    if (montantPaieRes == 0 && LastPayAmount != 0)
                    {
                        statut = "Payé";
                    }
                    else
                    {
                        statut = "Paiement partiel";
                    }

                    req = new SQLiteCommand("INSERT INTO PAIEMENT(montantpaie,devisepaie,montantres,modepaie,datepaie,numFac) VALUES(@montantPaie,@devise,@montantres,@modepaie,@datepaie,@numFacture)", con);
                    req.Parameters.AddWithValue("@montantPaie", Math.Round(montantconverti, 2));
                    req.Parameters.AddWithValue("@devise", devise);
                    req.Parameters.AddWithValue("@montantres", Math.Round(montantPaieRes, 2));
                    req.Parameters.AddWithValue("@modepaie", modePaie);
                    req.Parameters.AddWithValue("@datePaie", DateTime.Now.ToString("yyyy-MM-dd"));
                    req.Parameters.AddWithValue("@numFacture", numFac);
                    req.ExecuteNonQuery();
                    disconnect();

                    
                    connect();
            
                    //return numCompte
                    req = new SQLiteCommand("SELECT numCompte FROM COMPTE WHERE intitule='" + compte + "'", con);
                    int numcompte = int.Parse(req.ExecuteScalar().ToString());
                    //end numero compte
                    
                    //return compte devise
                    req = new SQLiteCommand("SELECT deviseCompte FROM COMPTE WHERE numCompte=" + numcompte + "", con);
                    string deviseAccount = req.ExecuteScalar().ToString();
                    //end compte devise

                    //update facture status
                    req = new SQLiteCommand("UPDATE FACTURE SET statut=@statut WHERE numFac='" + numFac + "'", con);
                    req.Parameters.AddWithValue("@statut", statut);
                    req.ExecuteNonQuery();
                    //end update status facture
                    disconnect();


                    double validAccountAmount = 0;
                    if (deviseAccount == "cdf")
                    {
                        validAccountAmount = app.convertDollarsToCdf(montantconverti);
                    }
                    else
                    {
                        validAccountAmount = montantconverti;
                    }
                    string type = "Entrée";
                    string designation = "Paiement facture";
                    operation.ValidateOperation(type, designation, Math.Round(validAccountAmount, 2), deviseAccount, numcompte, "", numFac);
                }
                //fin de la conversion
                

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

    }
}
