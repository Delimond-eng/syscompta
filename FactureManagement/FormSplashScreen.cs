using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FactureManagement.MainForm;
using Database;
using FactureManagement.Datas;
using System.Data.SQLite;
using FactureManagement.App;

namespace FactureManagement
{
    public partial class FormSplashScreen : Form
    {
        #region instance
        DataContext db = new DataContext();
        #endregion
        public FormSplashScreen()
        {
            InitializeComponent();
            guna2ShadowForm1.SetShadowForm(this);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            PGB.Value = PGB.Value + 1;
            if (PGB.Value == 100)
            {
                timer1.Stop();
                startSyscompta();
            }
        }

        private void FormSplashScreen_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void startSyscompta()
        {
            try
            {
                Database.Database.createDatabase();
                Database.Database.createTables();

                db.connect();
                db.req = new SQLiteCommand("SELECT * FROM ACTIVATION", db.con);
                db.dr = db.req.ExecuteReader();

                if (db.dr.Read())
                {
                    DateTime date_activation = Convert.ToDateTime(db.dr["date_activation"].ToString());
                    DateTime dateNow = DateTime.Now;
                    int appDelay = app.dateInterval(dateNow, date_activation);
                    int delay = int.Parse(db.dr["delay"].ToString());
                    Console.WriteLine(appDelay);
                    //compare delay
                    if (appDelay < delay)
                    {
                        db.disconnect();
                        this.Hide();
                        new FormLogin().Show();
                    }
                    else
                    {
                        db.req.Dispose();
                        MessageBox.Show("vous devez activer Syscompta! votre licence d'exploitation est expirée!", "ACTIVATION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        this.Hide();
                        new FormActivation().Show();
                    }
                }
                else
                {
                    db.disconnect();
                    this.Hide();
                    new FormActivation().Show();
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
