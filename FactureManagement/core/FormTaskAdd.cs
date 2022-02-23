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

namespace FactureManagement.core
{
    public partial class FormTaskAdd : MetroFramework.Forms.MetroForm
    {
        DataContext db = new DataContext();
        public FormTaskAdd()
        {
            InitializeComponent();
            inputDate.Value = DateTime.Now;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (inputDesignTask.Text == "" || inputTime.Text =="")
            {
                MessageBox.Show("vous devez entrer la désignation de votre tâche ainsi que l'heure", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                try
                {
                    db.connect();
                    db.req = new SQLiteCommand("INSERT INTO TASKS(designTask,dateTask,houreTask,status) VALUES(@design,@date,@houre,@status)", db.con);
                    db.req.Parameters.AddWithValue("@design" ,inputDesignTask.Text);
                    db.req.Parameters.AddWithValue("@date" ,inputDate.Value.ToString("yyyy-MM-dd"));
                    db.req.Parameters.AddWithValue("@houre" ,Convert.ToDateTime(inputTime.Text).ToShortTimeString());
                    db.req.Parameters.AddWithValue("@status", "1");
                    db.req.ExecuteNonQuery();
                    db.disconnect();
                    MessageBox.Show("Votre Tâche est créée!");
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void FormTaskAdd_Load(object sender, EventArgs e)
        {
            inputDate.Value = DateTime.Now;
        }
    }
}
