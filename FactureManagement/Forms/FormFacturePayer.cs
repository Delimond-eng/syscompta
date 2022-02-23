using FactureManagement.Datas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FactureManagement.Forms
{
    public partial class FormFacturePayer : MetroFramework.Forms.MetroForm
    {
        DataContext db = new DataContext();
        public FormFacturePayer()
        {
            InitializeComponent();
            voirFacturePayes();
        }


        private void voirFacturePayes()
        {
            try
            {
                db.connect();
                db.req = new SQLiteCommand("SELECT FACTURE.numFac AS num, FACTURE.montantFac AS amount,FACTURE.devisefac AS currency, PAIEMENT.datepaie AS datep, CLIENT.nomcli AS costumer FROM FACTURE INNER JOIN PAIEMENT ON FACTURE.numFac = PAIEMENT.numFac INNER JOIN CLIENT ON FACTURE.idcli = CLIENT.idcli WHERE FACTURE.statut = 'Payé' GROUP BY FACTURE.numFac", db.con);
                db.dr = db.req.ExecuteReader();

                while (db.dr.Read())
                {
                    DGV.Rows.Add(
                        db.dr["num"].ToString(),
                        Convert.ToDateTime(db.dr["datep"].ToString()).ToShortDateString(),
                        db.dr["costumer"].ToString(),
                        db.dr["amount"].ToString() + " "+ db.dr["currency"].ToString()
                    );
                }
                db.req.Dispose();
                db.disconnect();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
