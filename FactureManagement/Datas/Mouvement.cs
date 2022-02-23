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
    class Mouvement : DataContext
    {

        public void ValidateOperation(string type, string designation, double montantOperation, string devise, int numCompte, string obs=null, string numFac =null)
        {
            double montantInitial = 0;
            string deviseCompte = "";
            try
            {
                connect();
                try
                {
                    //recuperation du montant initial du compte
                    req = new SQLiteCommand("SELECT soldeCompte FROM COMPTE WHERE numCompte =" + numCompte + "", con);
                    montantInitial = double.Parse(req.ExecuteScalar().ToString());

                    //recuperation de la devise du compte selectionné
                    req = new SQLiteCommand("SELECT deviseCompte FROM COMPTE WHERE numCompte=" + numCompte + "", con);
                    deviseCompte = req.ExecuteScalar().ToString();
                }
                catch (Exception)
                {}

                //Conversion du montant cdf en dollars si le compte est en dollars
                double montantconverti = 0; /*(deviseCompte == "cdf" && devise == "usd") ? app.convertDollarsToCdf(montantOperation) : (deviseCompte == "usd" && devise == "cdf") ? montantOperation : montantOperation;*/
                if (deviseCompte == "cdf" && devise == "usd")
                {
                    montantconverti = app.convertDollarsToCdf(montantOperation);
                }
                else if(deviseCompte == "usd" && devise == "cdf")
                {
                    montantconverti = app.convertCdfToDollars(montantOperation);
                }
                else
                {
                    montantconverti = montantOperation;
                }
               
                double solde = 0;
                if (type == "Entrée") {
                    
                    solde = montantInitial + montantconverti;

                    //Validation de d'operation entrée
                    req = new SQLiteCommand("INSERT INTO OPERATION(Type, designOp,dateOp,montantOp,deviseOp,numCompte,soldeOp,numFac,Obs) VALUES(@type,@design,@date,@montant,@devise,@compte,@solde,'"+numFac+"',@obs)", con);
                    req.Parameters.AddWithValue("@type", type);
                    req.Parameters.AddWithValue("@design", designation);
                    req.Parameters.AddWithValue("@date", DateTime.Now.ToString("yyyy-MM-dd"));
                    req.Parameters.AddWithValue("@montant", montantconverti);
                    req.Parameters.AddWithValue("@devise", devise);
                    req.Parameters.AddWithValue("@compte", numCompte);
                    req.Parameters.AddWithValue("@solde", solde);
                    req.Parameters.AddWithValue("@obs", obs);
                    req.ExecuteNonQuery();

                    //mise à jour de solde du compte principal
                    req = new SQLiteCommand("UPDATE COMPTE SET soldeCompte=@solde, datecreateCompte=@date WHERE numCompte=@num", con);
                    req.Parameters.AddWithValue("@solde", solde);
                    req.Parameters.AddWithValue("@date", DateTime.Now.ToString("yyyy-MM-dd"));
                    req.Parameters.AddWithValue("@num", numCompte);
                    req.ExecuteNonQuery();
                    disconnect();
                    MessageBox.Show("l'opération a été effectuée avec succès!");
                }
                else if (type == "Sortie")
                {
                    if (montantInitial < montantconverti)
                    {
                        MessageBox.Show("Le montant spécifié est supérieur au montant du compte!! cette opération ne peut être réalisée!", "AVERTISSEMENT", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        solde = montantInitial - montantconverti;
                        //Validation de d'operation entrée
                        req = new SQLiteCommand("INSERT INTO OPERATION(Type, designOp,dateOp,montantOp,deviseOp,numCompte,soldeOp,Obs) VALUES(@type,@design,@date,@montant,@devise,@compte,@solde,@obs)", con);
                        req.Parameters.AddWithValue("@type", type);
                        req.Parameters.AddWithValue("@design", designation);
                        req.Parameters.AddWithValue("@date", DateTime.Now.ToString("yyyy-MM-dd"));
                        req.Parameters.AddWithValue("@montant", montantconverti);
                        req.Parameters.AddWithValue("@devise", devise);
                        req.Parameters.AddWithValue("@compte", numCompte);
                        req.Parameters.AddWithValue("@solde", solde);
                        req.Parameters.AddWithValue("@obs", obs);
                        req.ExecuteNonQuery();

                        //mise à jour de solde du compte principal
                        req = new SQLiteCommand("UPDATE COMPTE SET soldeCompte=@solde, datecreateCompte=@date WHERE numCompte=@num", con);
                        req.Parameters.AddWithValue("@solde", solde);
                        req.Parameters.AddWithValue("@date", DateTime.Now.ToString("yyyy-MM-dd"));
                        req.Parameters.AddWithValue("@num", numCompte);
                        req.ExecuteNonQuery();
                        disconnect();
                        MessageBox.Show("l'opération a été effectuée avec succès!");
                    }
                        
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
