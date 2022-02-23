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

namespace FactureManagement.core
{
    public partial class TaskCard : UserControl
    {
        DataContext db = new DataContext();
        private int _taskId;
        private string _taskDesignation;
        private string _taskDate;
        private string _taskHoure;

        public TaskCard()
        {
            InitializeComponent();
            getHashTask();
        }
        public int TaskId
        {
            get
            {
                return _taskId;
            }

            set
            {
                _taskId = value;
                lbId.Text =Convert.ToString(value);
            }
        }

        public string TaskDesignation
        {
            get
            {
                return _taskDesignation;
            }

            set
            {
                _taskDesignation = value;
                lbDesignTask.Text = value;
            }
        }

        public string TaskDate
        {
            get
            {
                return _taskDate;
            }

            set
            {
                _taskDate = value;
                lbDateTask.Text = value;
            }
        }

        public string TaskHoure
        {
            get
            {
                return _taskHoure;
            }

            set
            {
                _taskHoure = value;
                lbHoureTask.Text = value;
            }
        }

        private void checkedTask_CheckedChanged(object sender, EventArgs e)
        {
            if (checkedTask.Checked == true)
            {
                lbDesignTask.Font = new Font(lbDesignTask.Font.Name, lbDesignTask.Font.SizeInPoints, FontStyle.Strikeout);
            }
            else
            {
                lbDesignTask.Font = new Font(lbDesignTask.Font.Name, lbDesignTask.Font.SizeInPoints, FontStyle.Regular);
            }

        }

        private void getHashTask()
        {
            try
            {
                if (checkedTask.Checked == true)
                {
                    lbDesignTask.Font = new Font(lbDesignTask.Font.Name, lbDesignTask.Font.SizeInPoints, FontStyle.Strikeout | FontStyle.Bold);
                }
                else
                {
                    lbDesignTask.Font = new Font(lbDesignTask.Font.Name, lbDesignTask.Font.SizeInPoints, FontStyle.Regular);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCompleted_Click(object sender, EventArgs e)
        {
            checkedTask.Checked = true;
            btnCompleted.Enabled = false;
            try
            {
                db.connect();
                db.req = new SQLiteCommand("UPDATE TASKS SET status=@status WHERE idTask=@id", db.con);
                db.req.Parameters.AddWithValue("@status", "0");
                db.req.Parameters.AddWithValue("@id", TaskId);
                db.req.ExecuteNonQuery();
                db.disconnect();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            checkedTask.Enabled = false;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                db.connect();
                db.req = new SQLiteCommand("DELETE FROM TASKS WHERE idTask = @id", db.con);
                db.req.Parameters.AddWithValue("@id", TaskId);
                DialogResult dlg = MessageBox.Show("Etes-vous sûr de vouloir suprimer cette tâche?", "SUPRESSION", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dlg == DialogResult.Yes)
                {
                    db.req.ExecuteNonQuery();
                    db.disconnect();
                    MessageBox.Show("Tâche supprimée!");
                }
                else return;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadLine();
            }
        }
    }
}
