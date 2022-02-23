using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FactureManagement.Datas;
using System.Data.SQLite;

namespace FactureManagement.Forms.userController
{
    public partial class CardFacture : UserControl
    {
        private string numFacture;
        private string montantFacture;
        private string status;

        DataContext db = new DataContext();

        public string NumFacture
        {
            get
            {
                return numFacture;
            }

            set
            {
                numFacture = value;
                lbNumFacture.Text = value;
            }
        }

        public string MontantFacture
        {
            get
            {
                return montantFacture;
             
            }

            set
            {
                montantFacture = value;
                lbMontant.Text = value.ToString();
            }
        }

        public string Status
        {
            get
            {
                return status;
            }

            set
            {
                status = value;
                lbStatus.Text = value;
            }
        }


        public CardFacture()
        {
            InitializeComponent();
        }

        private void guna2ShadowPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                db.connect();
                db.req = new SQLiteCommand("DELETE FROM FACTURE WHERE numFac=@numfac", db.con);
                db.req.Parameters.AddWithValue("@numFac", NumFacture);
                DialogResult dlg = MessageBox.Show("Etes-vous sûr de vouloir supprimer définitiviment cette facture ?", "Avertissement", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dlg == DialogResult.Yes)
                {
                    if(Status == "Paiement partiel") {
                        MessageBox.Show("Vous ne pouvez pas supprimer une facture déjà payée partiellement", "Restriction de suppression", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    else
                    {
                        db.req.ExecuteNonQuery();
                        db.disconnect();
                        MessageBox.Show("la facture a été supprimée !");
                    }
                }
                else return;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
