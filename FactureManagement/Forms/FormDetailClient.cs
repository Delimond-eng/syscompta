using FactureManagement.App;
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
    public partial class FormDetailClient : MetroFramework.Forms.MetroForm
    {
        #region variables instance
        DataContext db = new DataContext();
        #endregion
        public FormDetailClient(string nomclient)
        {
            InitializeComponent();
            viewDetail(nomclient);
        }

        private void viewDetail(string nameCli)
        {
            DGVDetail.Rows.Clear();
            try
            {
                db.connect();
                db.req = new SQLiteCommand("SELECT * FROM FACTURE INNER JOIN PAIEMENT ON FACTURE.numFac=PAIEMENT.numFac INNER JOIN CLIENT ON CLIENT.idcli = FACTURE.idcli WHERE CLIENT.nomcli='"+nameCli+"' ", db.con);
                db.dr = db.req.ExecuteReader();
                while (db.dr.Read())
                {
                    DGVDetail.Rows.Add(
                        Convert.ToDateTime(db.dr["datepaie"]).ToShortDateString(),
                        db.dr["numFac"].ToString(),
                        app.currency(double.Parse(db.dr["montantFac"].ToString())) +" $",
                        app.currency(double.Parse(db.dr["montantpaie"].ToString())) +" $",
                        app.currency(double.Parse(db.dr["montantres"].ToString())) +" $"
                    );
                }
                db.disconnect();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void DGVDetail_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string numFacture = DGVDetail.CurrentRow.Cells[1].Value.ToString();
            FormDetailFacture frm = new FormDetailFacture(numFacture);
            frm.ShowDialog();
        }
    }
}
