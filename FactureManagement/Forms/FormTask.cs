using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Windows.Forms;
using FactureManagement.core;
using FactureManagement.Datas;

namespace FactureManagement.Forms
{
    public partial class FormTask : Form
    {
        DataContext db = new DataContext();
        Guna.UI.Lib.ScrollBar.PanelScrollHelper cardScrool;
        int id = 0;
        public FormTask()
        {
            InitializeComponent();
            cardScrool = new Guna.UI.Lib.ScrollBar.PanelScrollHelper(PanelLayout,Tscrool, true);
            viewTask();
        }

        void viewTask()
        {
            string status = "";
            PanelLayout.Controls.Clear();
            try
            {
                db.connect();
                db.req = new SQLiteCommand("SELECT COUNT(idTask) FROM TASKS", db.con);
                int count = int.Parse(db.req.ExecuteScalar().ToString());
                db.req = new SQLiteCommand("SELECT * FROM TASKS ORDER BY idTask DESC", db.con);
                db.dr = db.req.ExecuteReader();
                TaskCard[] cardTask = new TaskCard[count];
                int i = 0;
                while (db.dr.Read())
                {
                    cardTask[i] = new TaskCard();
                    cardTask[i].TaskId = int.Parse(db.dr["idTask"].ToString());
                    id = cardTask[i].TaskId;
                    cardTask[i].TaskDesignation = db.dr["designTask"].ToString();
                    cardTask[i].TaskDate = Convert.ToDateTime(db.dr["dateTask"].ToString()).ToLongDateString();
                    cardTask[i].TaskHoure = Convert.ToDateTime(db.dr["houreTask"].ToString()).ToShortTimeString();
                    status = db.dr["status"].ToString();
                    cardTask[i].checkedTask.Checked = (status == "0") ? true : false;
                    cardTask[i].btnCompleted.Enabled = (status == "0") ? false : true;
                    cardTask[i].btnDelete.Click += new EventHandler(refreshView);
                    PanelLayout.Controls.Add(cardTask[i]);
                    i++;
                }
                db.disconnect();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Console.ReadLine();
        }
        private void refreshView(object sender, EventArgs e)
        {
            viewTask();
        }
        private void refreshTask(object sender, FormClosedEventArgs e)
        {
            viewTask();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            FormTaskAdd frm = new FormTaskAdd();
            frm.FormClosed += new FormClosedEventHandler(refreshTask);
            frm.ShowDialog();
        }
    }
}
