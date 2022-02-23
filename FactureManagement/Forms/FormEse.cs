using FactureManagement.App;
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
using System.IO;
using System.Data.SQLite;

namespace FactureManagement.Forms
{
    public partial class FormEse : MetroFramework.Forms.MetroForm
    {
        Config config = new Config();
        DataContext db = new DataContext();
        public FormEse()
        {
            InitializeComponent();
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.None;
            pLogo.Image = Properties.Resources.upload;
        }

        private void pLogo_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Filter = "Fichier Images (*.jpg;*.jpeg;*.gif;*.png ) |*.jpg;*.jpeg;*.gif;*.png";
            if (op.ShowDialog() == DialogResult.OK)
            {
                pLogo.Image = new Bitmap(op.FileName);
                pLogo.SizeMode = PictureBoxSizeMode.Zoom;
            }
        }

        private void clean()
        {
            TextDesign.Text = "";
            TextIdNat.Text = "";
            Textrccm.Text = "";
            TextAdress.Text = "";
            TextMail.Text = "";
            TextPhone.Text = "";
            pLogo.Image = Properties.Resources.upload;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            clean();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            Image logo = (pLogo.Image == Properties.Resources.upload) ? null : pLogo.Image;

            string[] field = {
                TextDesign.Text,
                TextAdress.Text,
                TextPhone.Text,
            };
            app.checkFields(field);
            if (app.FieldsEmpty) return;

            try
            {
                config.createConfig(
                    TextDesign.Text,
                    TextIdNat.Text,
                    Textrccm.Text,
                    TextAdress.Text,
                    TextMail.Text,
                    TextPhone.Text,
                    logo
                );
            }
            catch (Exception)
            {}
            try
            {
                db.connect();
                db.req = new SQLiteCommand("SELECT id FROM CONFIG WHERE Esename='" + TextDesign.Text + "'", db.con);
                int id = int.Parse(db.req.ExecuteScalar().ToString());
                db.req = new SQLiteCommand("UPDATE FACTURE SET idconfig=@id", db.con);
                db.req.Parameters.AddWithValue("@id", id);
                db.req.ExecuteNonQuery();
                db.disconnect();
            }
            catch {} 
            clean();
        }
    }
}
