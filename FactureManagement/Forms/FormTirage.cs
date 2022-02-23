using FactureManagement.App;
using FactureManagement.Datas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FactureManagement.Forms
{
    public partial class FormTirage : MetroFramework.Forms.MetroForm
    {
        #region variables
        DataContext db = new DataContext();
        Compte compte = new Compte();
        #endregion
        string typeSelect = "";
        string deviseCompte = "";
        public FormTirage()
        {
            InitializeComponent();
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.None;
            textDate.Value = DateTime.Now;
            TextDateBegin.Value = DateTime.Now;
            TextDateEnd.Value = DateTime.Now;
            viewAllAccount();
        }

        private void viewAllAccount()
        {
            try
            {
                cbCompte.Items.Clear();
                db.connect();
                db.req = new SQLiteCommand("SELECT intitule FROM COMPTE", db.con);
                db.dr = db.req.ExecuteReader();
                //Loop
                while (db.dr.Read())
                {
                    cbCompte.Items.Add(
                        db.dr[0].ToString()
                    );
                }
                db.disconnect();
            }
            catch (Exception) { }
        }

        private void SelectCompte()
        {
            try
            {
                db.connect();
                db.req = new SQLiteCommand("SELECT * FROM COMPTE WHERE intitule='" + cbCompte.Text + "'", db.con);
                db.dr = db.req.ExecuteReader();
                //Loop
                string devise = "";
                if (db.dr.Read())
                {
                    lbNumCompte.Text = db.dr["numCompte"].ToString();
                    lbCompte.Text = db.dr["intitule"].ToString();
                    if (db.dr["deviseCompte"].ToString()=="usd")
                    {
                        devise = " $";
                    }
                    else { devise = " $"; }
                    lbSolde.Text = app.currency(double.Parse(db.dr["soldeCompte"].ToString())) + " " +devise;
                    deviseCompte = devise;
                }
               
                db.disconnect();
            }
            catch (Exception) { }
        }

        private void viewOperation(int num, string type)
        {
            DGVTirage.Rows.Clear();
            try
            {
                db.connect();
                db.req = new SQLiteCommand("SELECT * FROM OPERATION INNER JOIN COMPTE ON OPERATION.numCompte = COMPTE.numCompte WHERE OPERATION.numCompte=" + num + " AND OPERATION.Type='" + type + "' ", db.con);
                db.dr = db.req.ExecuteReader();
                int order = 0;
                string devise = "";
                //Loop
                while (db.dr.Read())
                {
                    if (db.dr["deviseCompte"].ToString() == "usd")
                    {
                        devise = "$";
                    }
                    else { devise = db.dr["deviseCompte"].ToString(); }
                    DGVTirage.Rows.Add(
                        order += 1,
                        Convert.ToDateTime(db.dr["dateOp"].ToString()).ToShortDateString(),
                        db.dr["designOp"].ToString(),
                        db.dr["Type"].ToString(),
                        app.currency((double)db.dr["montantOp"]) + " " + devise,
                        db.dr["Obs"].ToString()
                    );
                }
                db.disconnect();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btnEntree_Click(object sender, EventArgs e)
        {
            string type = "Entrée";
            if (lbNumCompte.Text == "")
            {
                MessageBox.Show("Vous devez créer sélectionner un compte pour effectuer cette opération!", "Sélection du compte obligatoire", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                lbSelectInfo.Text = "SITUATION SUR LES ENTREES";
                labelTitleSolde.Text = "SOLDE DES ENTREES";
                lbSelectInfo.ForeColor = Color.FromArgb(72, 150, 189);
                int num = int.Parse(lbNumCompte.Text);
                viewOperation(num, type);
                lbCompte.ForeColor = Color.SeaGreen;
                typeSelect = "Entrée";
                voirSoldeOperation(type, false, false);
            }

            
        }

        private void voirSoldeOperation(string type, bool isDateSelected = false, bool isDateBetween = false) 
        {
            int numCompte = int.Parse(lbNumCompte.Text.Trim());
            db.connect();
            if (isDateBetween == true)
            {

                try
                {
                    db.req = new SQLiteCommand("SELECT SUM(montantOp) FROM OPERATION WHERE numCompte=" + numCompte + "  AND Type='" + type + "' AND dateOp BETWEEN @dateBegin AND @dateEnd ORDER BY numCompte", db.con);
                    db.req.Parameters.AddWithValue("@dateBegin", TextDateBegin.Value.ToString("yyyy-MM-dd"));
                    db.req.Parameters.AddWithValue("@dateEnd", TextDateEnd.Value.ToString("yyyy-MM-dd"));


                    double solde = 0;
                    solde= double.Parse(db.req.ExecuteScalar().ToString());
                    db.req.Dispose();

                    db.disconnect();
                    labelSolde.Text = solde.ToString() + " " + deviseCompte;
                    labelTitleSolde.Text = "SOLDE Du : " + TextDateBegin.Value.ToString("yyyy-MM-dd") + "  Au : " + TextDateEnd.Value.ToString("yyyy-MM-dd") + "";
                    labelTitleSolde.Visible = true;
                    labelSolde.Visible = true;
                }
                catch (Exception)
                {
                    MessageBox.Show("Aucune donnée liée à cette requête");
                    labelSolde.Text = "0 " + deviseCompte;
                }

            }
            else if (isDateSelected == true)
            {
                try
                {
                    db.req = new SQLiteCommand("SELECT SUM(montantOp) FROM OPERATION WHERE numCompte=" + numCompte + " AND dateOp=@dateOperation ORDER BY numCompte", db.con);
                    db.req.Parameters.AddWithValue("@dateOperation", textDate.Value.ToString("yyyy-MM-dd"));


                    double solde = 0;
                    solde = double.Parse(db.req.ExecuteScalar().ToString());
                    db.req.Dispose();

                    db.disconnect();
                    labelSolde.Text = solde.ToString() + " " + deviseCompte;
                    labelTitleSolde.Text = "SOLDE Du : " + textDate.Value.ToString("yyyy-MM-dd") + "";
                    labelTitleSolde.Visible = true;
                    labelSolde.Visible = true;
                }
                catch (Exception)
                {
                    MessageBox.Show("Aucune donnée liée à cette requête");
                    labelSolde.Text = "0 " + deviseCompte;
                }
            }
            else
            {
                try
                {
                    db.req = new SQLiteCommand("SELECT SUM(montantOp) FROM OPERATION WHERE numCompte=" + numCompte + "  AND Type='" + type + "' ORDER BY numCompte", db.con);

                    double solde = 0;
                    solde = double.Parse(db.req.ExecuteScalar().ToString());
                    db.req.Dispose();

                    db.disconnect();
                    labelSolde.Text = solde.ToString() + " " + deviseCompte;
                    labelTitleSolde.Text = type == "Entrée" ? "SOLDE GENERAL DES ENTREES" : "SOLDE GENERAL DES SORTIES";
                    labelTitleSolde.Visible = true;
                    labelSolde.Visible = true;
                }
                catch (Exception)
                {
                    MessageBox.Show("Aucune donnée liée à cette requête");
                    labelSolde.Text = "0 " + deviseCompte;
                }
            }
        }

        private void btnSortie_Click(object sender, EventArgs e)
        {
            string type = "Sortie";
           
            if (lbNumCompte.Text == "")
            {
                MessageBox.Show("Vous devez créer sélectionner un compte pour effectuer cette opération!", "Sélection du compte obligatoire", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                lbSelectInfo.Text = "SITUATION SUR LES SORTIES";
                labelTitleSolde.Text = "SOLDE DES SORTIES";
                lbSelectInfo.ForeColor = Color.Crimson;
                int num = int.Parse(lbNumCompte.Text);
                viewOperation(num, type);
                DGVTirage.RowsDefaultCellStyle.BackColor = Color.FromArgb(255, 192, 192);
                lbCompte.ForeColor = Color.Crimson;
                typeSelect = "Sortie";
                voirSoldeOperation(type, false,false);
            }
        }

        
        private void selectBetweenDate(int num, string type)
        {
            DGVTirage.Rows.Clear();
            try
            {
                if (typeSelect == "Entrée" || typeSelect =="Sortie")
                {
                    db.connect();
                    db.req = new SQLiteCommand("SELECT * FROM OPERATION INNER JOIN COMPTE ON OPERATION.numCompte = COMPTE.numCompte WHERE OPERATION.numCompte=" + num + "  AND OPERATION.Type='"+type+ "' AND OPERATION.dateOp BETWEEN @dateBegin AND @dateEnd ORDER BY OPERATION.numCompte ", db.con);
                    db.req.Parameters.AddWithValue("@dateBegin", TextDateBegin.Value.ToString("yyyy-MM-dd"));
                    db.req.Parameters.AddWithValue("@dateEnd", TextDateEnd.Value.ToString("yyyy-MM-dd"));
                    db.dr = db.req.ExecuteReader();
                    int order = 0;
                    string devise = "";
                    //Loop
                    while (db.dr.Read())
                    {
                        if (db.dr["deviseCompte"].ToString() == "usd")
                        {
                            devise = "$";
                        }
                        else { devise = db.dr["deviseCompte"].ToString(); }
                        DGVTirage.Rows.Add(
                            order += 1,
                            Convert.ToDateTime(db.dr["dateOp"].ToString()).ToShortDateString(),
                            db.dr["designOp"].ToString(),
                            db.dr["Type"].ToString(),
                            app.currency((double)db.dr["montantOp"]) + " " + devise,
                            db.dr["Obs"].ToString()
                        );
                    }
                    db.disconnect();
                }
                else
                {
                    db.connect();
                    db.req = new SQLiteCommand("SELECT * FROM OPERATION INNER JOIN COMPTE ON OPERATION.numCompte = COMPTE.numCompte WHERE OPERATION.numCompte=" + num + "  AND OPERATION.dateOp BETWEEN @dateBegin AND @dateEnd ORDER BY OPERATION.numCompte", db.con);
                    db.req.Parameters.AddWithValue("@dateBegin", TextDateBegin.Value.ToString("yyyy-MM-dd"));
                    db.req.Parameters.AddWithValue("@dateEnd", TextDateEnd.Value.ToString("yyyy-MM-dd"));
                    db.dr = db.req.ExecuteReader();
                    int order = 0;
                    string devise = "";
                    //Loop
                    while (db.dr.Read())
                    {
                        if (db.dr["deviseCompte"].ToString() == "usd")
                        {
                            devise = "$";
                        }
                        else devise = db.dr["deviseCompte"].ToString();
                        DGVTirage.Rows.Add(
                            order += 1,
                            Convert.ToDateTime(db.dr["dateOp"].ToString()).ToShortDateString(),
                            db.dr["designOp"].ToString(),
                            db.dr["Type"].ToString(),
                            app.currency((double)db.dr["montantOp"]) + " " + devise,
                            db.dr["Obs"].ToString()
                        );
                    }
                    db.disconnect();
                }
            }
            catch(Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAfficher_Click(object sender, EventArgs e)
        {
            int num = int.Parse(lbNumCompte.Text);
            selectBetweenDate(num, typeSelect);

            voirSoldeOperation(typeSelect, false, true);
        }

        private void viewCompteAllDetail()
        {
            DGVTirage.Rows.Clear();
            try
            {
                int num = int.Parse(lbNumCompte.Text);
                db.connect();
                db.req = new SQLiteCommand("SELECT * FROM OPERATION INNER JOIN COMPTE ON OPERATION.numCompte = COMPTE.numCompte WHERE OPERATION.numCompte=" + num + " ", db.con);
                db.dr = db.req.ExecuteReader();
                int order = 0;
                string devise = "";
                //Loop
                while (db.dr.Read())
                {

                    if (db.dr["deviseOp"].ToString() == "usd")
                    {
                        devise = "$";
                    }
                    else devise = db.dr["deviseOp"].ToString();

                    DGVTirage.Rows.Add(
                        order += 1,
                        Convert.ToDateTime(db.dr["dateOp"].ToString()).ToShortDateString(),
                        db.dr["designOp"].ToString(),
                        db.dr["Type"].ToString(),
                        app.currency((double)db.dr["montantOp"]) + " " + devise,
                        db.dr["Obs"].ToString()
                    );
                    
                }
                db.disconnect();
            }
            catch (SQLiteException ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAfficher1_Click(object sender, EventArgs e)
        {
            SelectFromDate();
            voirSoldeOperation("", true, false);
        }

        private void SelectFromDate()
        {
            int num = int.Parse(lbNumCompte.Text);
            DGVTirage.Rows.Clear();
            try
            {
                db.connect();
                db.req = new SQLiteCommand("SELECT * FROM OPERATION INNER JOIN COMPTE ON OPERATION.numCompte = COMPTE.numCompte WHERE OPERATION.numCompte=" + num + "  AND OPERATION.dateOp=@dateOperation ORDER BY OPERATION.numCompte", db.con);
                db.req.Parameters.AddWithValue("@dateOperation", textDate.Value.ToString("yyyy-MM-dd"));
                db.dr = db.req.ExecuteReader();
                int order = 0;
                string devise = "";
                //Loop
                while (db.dr.Read())
                {
                    if (db.dr["deviseCompte"].ToString() == "usd")
                    {
                        devise = "$";
                    }
                    else devise = db.dr["deviseCompte"].ToString();
                    DGVTirage.Rows.Add(
                        order += 1,
                        Convert.ToDateTime(db.dr["dateOp"].ToString()).ToShortDateString(),
                        db.dr["designOp"].ToString(),
                        db.dr["Type"].ToString(),
                        app.currency((double)db.dr["montantOp"]) + " " + devise,
                        db.dr["Obs"].ToString()
                    );
                }
                db.disconnect();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void cbCompte_SelectedIndexChanged(object sender, EventArgs e)
        {
            GpInfoCompte.Visible = true;
            PanelAction.Visible = true;
            SelectCompte();
            PanelInfo.Visible = true;
            lbSelectInfo.Text = "SITUATION GLOBAL DU COMPTE";
            viewCompteAllDetail();
            
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            SelectFromDate();
        }
    }
}
