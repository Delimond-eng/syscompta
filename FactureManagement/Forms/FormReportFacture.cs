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
using Microsoft.Reporting.WinForms;

namespace FactureManagement.Forms
{
    public partial class FormReportFacture : MetroFramework.Forms.MetroForm
    {
        DataContext db = new DataContext();
        DataSet1 ds = new DataSet1();
        SQLiteDataAdapter da;
        private string _numfacture = "";
        private string _nomSignataire = "";
        private string _fonctionSignataire = "";
        private string _tva;
        private string _total;
        public FormReportFacture(string numfacture, string nom, string fonction, string tva, string total)
        {
            InitializeComponent();
            this._numfacture = numfacture;
            this._nomSignataire = nom;
            this._fonctionSignataire = fonction;
            this._tva = tva;
            this._total= total;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GetReport();
            this.reportViewer1.RefreshReport();
        }

        private void GetReport()
        {
            try
            {
                db.connect();
                this.reportViewer1.LocalReport.ReportPath = Application.StartupPath + "\\factureReport.rdlc";/*"D:\\RT GROUP\\Syscompta Full\\FactureManagement\\factureReport.rdlc*/
                da = new SQLiteDataAdapter("SELECT CLIENT.*, CONFIG.*, FACTURE.*, FACTURE_DETAIL.*FROM FACTURE INNER JOIN CONFIG ON FACTURE.idconfig = CONFIG.idconfig INNER JOIN FACTURE_DETAIL ON FACTURE.numFac = FACTURE_DETAIL.numFac, CLIENT WHERE FACTURE.numFac='"+_numfacture+"' GROUP BY FACTURE_DETAIL.designation", db.con);
                da.SelectCommand.CommandType = CommandType.Text;
                da.Fill(ds.Tables["DataTable1"]);
                db.disconnect();
                var reportSource = new ReportDataSource("DataSet1", ds.Tables["DataTable1"]);
                ReportParameter[] rparams = new ReportParameter[]
                {
                    new ReportParameter("pNomSign", _nomSignataire),
                    new ReportParameter("pFonctionSign",_fonctionSignataire),
                    new ReportParameter("ptva",_tva),
                    new ReportParameter("ptot",_total),
                };
                this.reportViewer1.LocalReport.DataSources.Add(reportSource);
                this.reportViewer1.LocalReport.SetParameters(rparams);
                this.reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
                this.reportViewer1.ZoomMode = ZoomMode.Percent;
                this.reportViewer1.ZoomPercent = 100;
                this.reportViewer1.LocalReport.Refresh();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadLine();
            }   
        }
    }
}
