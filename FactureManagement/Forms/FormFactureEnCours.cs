using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FactureManagement.Forms.userController;
using FactureManagement.Datas;
using System.Data.SQLite;

namespace FactureManagement.Forms
{
    public partial class FormFactureEnCours : MetroFramework.Forms.MetroForm
    {
        Guna.UI.Lib.ScrollBar.PanelScrollHelper cardScrool;
        DataContext db = new DataContext();
        public FormFactureEnCours()
        {
            InitializeComponent();
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.None;
            cardScrool = new Guna.UI.Lib.ScrollBar.PanelScrollHelper(PanelLayout, Tscrool, true);
            viewAll();
        }


        void viewAll()
        {
            PanelLayout.Controls.Clear();
            try
            {
                db.connect();
                db.req = new SQLiteCommand("SELECT COUNT(numFac) FROM FACTURE WHERE statut='En_Attente' OR statut='Paiement partiel'", db.con);
                int count = int.Parse(db.req.ExecuteScalar().ToString());
                db.req = new SQLiteCommand("SELECT * FROM FACTURE WHERE statut='En_Attente' OR statut='Paiement partiel'", db.con);
                db.dr = db.req.ExecuteReader();
                CardFacture[] cardItem = new CardFacture[count];
                int i = 0;
                while (db.dr.Read())
                {
                    cardItem[i] = new CardFacture();
                    cardItem[i].NumFacture = db.dr["numFac"].ToString();
                    cardItem[i].MontantFacture = db.dr["montantFac"].ToString()+" "+ db.dr["devisefac"].ToString();
                    cardItem[i].Status = db.dr["statut"].ToString();
                    cardItem[i].btnDelete.Click += new EventHandler(refreshView);
                    PanelLayout.Controls.Add(cardItem[i]);
                    i++;
                }
                db.disconnect();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void refreshView(object sender, EventArgs e)
        {
            viewAll();
        }
    }
}
