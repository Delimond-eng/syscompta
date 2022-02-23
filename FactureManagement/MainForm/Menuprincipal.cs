using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FactureManagement.Forms;
using FactureManagement.App;
using System.Threading;
using FactureManagement.Datas;
using System.Data.SQLite;

namespace FactureManagement.MainForm
{
    public partial class Menuprincipal : Form
    {
        //Instance
        DataContext db = new DataContext();
        public Menuprincipal()
        {
            InitializeComponent();
            showhome();
            customizeDesing();
            shadow.SetShadowForm(this);
        }
        
        private void customizeDesing()
        {
            panelSubFacture.Visible = false;
            panelSubMouv.Visible = false;
            panelSubUser.Visible = false;
            panelSubConfig.Visible = false;
        }

        private void hideSubmenu()
        {
            if (panelSubMouv.Visible == true)
                panelSubMouv.Visible = false;
            if (panelSubFacture.Visible == true)
                panelSubFacture.Visible = false;
            if (panelSubConfig.Visible == true)
                panelSubConfig.Visible = false;
            if (panelSubUser.Visible == true)
                panelSubUser.Visible = false;  
        }

        private void showSubmenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubmenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }
        private void showhome()
        {
            FormHome frm = new FormHome();
            AppendForm(frm);
        }
        DateTime currentDate = DateTime.Now;

        private void AppendForm(Object form)
        {
            try
            {
                if (this.ContainerPanel.Controls.Count > 0)

                    this.ContainerPanel.Controls.RemoveAt(0);
                    Form frm = form as Form;
                    frm.TopLevel = false;
                    frm.Dock = DockStyle.Fill;
                    frm.TopMost = false;
                    this.ContainerPanel.Controls.Add(frm);
                    this.ContainerPanel.Tag = frm;
                    frm.Show();
            }
            catch (Exception){}
        }

        private void AppendAfterClose(object sender, FormClosedEventArgs e)
        {
            showhome();
        }


        private void BtnHome_Click(object sender, EventArgs e)
        {
            showhome();
        }

        private void BtnFacture_Click(object sender, EventArgs e)
        {
            showSubmenu(panelSubFacture);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnReserve_Click(object sender, EventArgs e)
        {
            showSubmenu(panelSubMouv);
        }

        private void iconMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnFac_Click(object sender, EventArgs e)
        {
            if (app.isConfiguration() == false)
            {
                MessageBox.Show("SVP vous devez configurer SYSCOMPTA en fonction de votre entreprise", "configuration du logiciel requise", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                FormEse frm = new FormEse();
                frm.FormClosed += new FormClosedEventHandler(AppendAfterClose);
                AppendForm(frm);
            }
            else if (app.isConfiguration() == true)
            {
                FormCreationFacture facture = new FormCreationFacture();
                facture.FormClosed += new FormClosedEventHandler(AppendAfterClose);
                AppendForm(facture);
            }
        }

        private void gunaAdvenceButton7_Click(object sender, EventArgs e)
        {
            FormPaiementFacture frm = new FormPaiementFacture();
            frm.FormClosed += new FormClosedEventHandler(AppendAfterClose);
            AppendForm(frm);
        }

        private void gunaAdvenceButton5_Click(object sender, EventArgs e)
        {
            FormClient frm = new FormClient();
            frm.FormClosed += new FormClosedEventHandler(AppendAfterClose);
            AppendForm(frm);
        }

        private void gunaAdvenceButton3_Click(object sender, EventArgs e)
        {
            
        }

        private void gunaAdvenceButton4_Click(object sender, EventArgs e)
        {
            FormSyntheseCompte frm = new FormSyntheseCompte();
            frm.FormClosed += new FormClosedEventHandler(AppendAfterClose);
            AppendForm(frm);
        }

        private void gunaAdvenceButton3_Click_1(object sender, EventArgs e)
        {
            FormOperation frm = new FormOperation();
            frm.FormClosed += new FormClosedEventHandler(AppendAfterClose);
            AppendForm(frm);
        }
       
        private void gunaAdvenceButton1_Click_1(object sender, EventArgs e)
        {
            FormTirage frm = new FormTirage();
            frm.FormClosed += new FormClosedEventHandler(AppendAfterClose);
            AppendForm(frm);
        }

        private void gunaAdvenceButton2_Click(object sender, EventArgs e)
        {
            showSubmenu(panelSubUser);
        }

        private void gunaAdvenceButton10_Click(object sender, EventArgs e)
        {
            showSubmenu(panelSubConfig);
        }

        private void gunaAdvenceButton9_Click(object sender, EventArgs e)
        {
            FormUser frm = new FormUser();
            frm.FormClosed += new FormClosedEventHandler(AppendAfterClose);
            AppendForm(frm);
        }

        private void gunaAdvenceButton13_Click(object sender, EventArgs e)
        {
            FormEse frm = new FormEse();
            frm.FormClosed += new FormClosedEventHandler(AppendAfterClose);
            AppendForm(frm);
        }

        private void gunaAdvenceButton14_Click(object sender, EventArgs e)
        {
            FormCompte frm = new FormCompte();
            frm.FormClosed += new FormClosedEventHandler(AppendAfterClose);
            AppendForm(frm);
        }

        private void gunaAdvenceButton15_Click(object sender, EventArgs e)
        {
            FormResumeClient frm = new FormResumeClient();
            frm.FormClosed += new FormClosedEventHandler(AppendAfterClose);
            AppendForm(frm);
        }

        private void Menuprincipal_Load(object sender, EventArgs e)
        {
            //taskRemind();
        }

        private void gunaAdvenceButton6_Click(object sender, EventArgs e)
        {
            FormTask frm = new FormTask();
            frm.FormClosed += new FormClosedEventHandler(AppendAfterClose);
            AppendForm(frm);
        }

        private void gunaAdvenceButton8_Click(object sender, EventArgs e)
        {
            FormFactureEnCours frm = new FormFactureEnCours();
            frm.FormClosed += new FormClosedEventHandler(AppendAfterClose);
            AppendForm(frm);
        }

        private void gunaAdvenceButton6_Click_1(object sender, EventArgs e)
        {
            FormTask frm = new FormTask();
            frm.FormClosed += new FormClosedEventHandler(AppendAfterClose);
            AppendForm(frm);
        }
    }
}
