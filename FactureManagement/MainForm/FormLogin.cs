using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FactureManagement.App;
using FactureManagement.Datas;

namespace FactureManagement.MainForm
{
    public partial class FormLogin : MetroFramework.Forms.MetroForm
    {
        #region variable
        UserManager user = new UserManager();
        #endregion
        public FormLogin()
        {
            InitializeComponent();
        }
        
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(TextUsername.Text =="" || TextPwd.Text == "")
            {
                MessageBox.Show("Vous devez insérer le nom d'utilisateur et le mot de passe pour vous connecter!", "Nom d'utilisateur et le mot de passe obligatoire", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                Menuprincipal frm = new Menuprincipal();
                user.login(
                    TextUsername.Text,
                    app.Encrypt(TextPwd.Text),
                    this,
                    frm
                );
            } 
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
