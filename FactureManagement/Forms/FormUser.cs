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
using FactureManagement.App;

namespace FactureManagement.Forms
{
    public partial class FormUser : MetroFramework.Forms.MetroForm
    {
        #region variables instances
        UserManager user = new UserManager();
        #endregion
        public FormUser()
        {
            InitializeComponent();
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.None;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string[] field = { TextUsername.Text, TextPwd.Text, cbProfil.Text };
            app.checkFields(field);
            if (app.FieldsEmpty) return;

            user.register(
                TextUsername.Text,
                TextPwd.Text,
                cbProfil.Text    
            );
            clean();
        }

        private void clean()
        {
            TextUsername.Text = "";
            TextPwd.Text = "";
            cbProfil.Text = null;
        }
    }
}
