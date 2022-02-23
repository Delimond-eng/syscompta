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
using Newtonsoft.Json.Linq;
using FactureManagement.Datas;
using System.Data.SQLite;

namespace FactureManagement.MainForm
{
    public partial class FormActivation : MetroFramework.Forms.MetroForm
    {
        DataContext db = new DataContext();
        public FormActivation()
        {
            InitializeComponent();
            
        }
        private async void btnActivate_Click(object sender, EventArgs e)
        {
            btnActivate.Enabled = false;
            try
            {
                var inputData = new List<KeyValuePair<string, string>>();
                inputData.Add(new KeyValuePair<string, string>("code", TextActivation.Text));
                var response = await RequestHelper.Post(
                    "activation/code",
                    inputData
                );

                JToken token = JObject.Parse(response);
                string status = token.SelectToken("reponse").SelectToken("status").ToString();
                int delay = (int)token.SelectToken("reponse").SelectToken("delai");

                try
                {
                    if (status == "success")
                    {
                        app.activated(TextActivation.Text, delay, status);
                        MessageBox.Show("l'activation du syscompta est effectuée pour " + delay+" jours", "syscompta activé", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Hide();
                        new FormSplashScreen().Show();
                    }
                    else
                    {
                        MessageBox.Show("le code d'activation est invalide!", "Echec d'activation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btnActivate.Enabled = true;
                        return;
                    }
                }
                catch (Exception)
                {
                    btnActivate.Enabled = true;
                    this.Hide();
                }
            }
            catch (Exception ex)
            {
                btnActivate.Enabled = true;
                this.Hide();
                Console.WriteLine(ex.Message);
                Console.ReadLine();
            }
        }
    }
}
