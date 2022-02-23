using FactureManagement.App;
using FactureManagement.Datas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FactureManagement.Forms
{
    public partial class FormCompte : MetroFramework.Forms.MetroForm
    {
        #region variables
        DataContext db = new DataContext();
        Compte compte = new Compte();
        #endregion
        public FormCompte()
        {
            InitializeComponent();
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.None;
        }
        private void cleanField()
        {
            TextIntitule.Text = "";
            TextDepot.Text = "";
            cbDevise.Text = null;
        }

        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            string[] field = { TextIntitule.Text, TextDepot.Text, cbDevise.Text};
            app.checkFields(field);
            if (app.FieldsEmpty) return;
            compte.createCompte(
                TextIntitule.Text,
                double.Parse(TextDepot.Text),
                cbDevise.Text
            );
            cleanField();
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            cleanField();
        }
    }
}
