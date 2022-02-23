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

namespace FactureManagement.Forms
{
    public partial class FormDetailFacture : MetroFramework.Forms.MetroForm
    {
        DataContext db = new DataContext();

        public string NumFacure { get; set; }
        public FormDetailFacture(string num)
        {
            NumFacure = num;
            InitializeComponent();
            viewFactureDetail();
            Console.WriteLine(NumFacure);
        }


        private void viewFactureDetail()
        {
            DGVDetail.Rows.Clear();
            try
            {
                db.connect();
                db.req = new SQLiteCommand("SELECT * FROM FACTURE_DETAIL WHERE numFac='" + NumFacure + "' ", db.con);
                db.dr = db.req.ExecuteReader();
                while (db.dr.Read())
                {
                    DGVDetail.Rows.Add(
                        db.dr["numFac"].ToString(),
                        db.dr["designation"].ToString(),
                        db.dr["qte"].ToString(),
                        db.dr["pu"].ToString() + "$"
                    );
                }
                db.disconnect();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
