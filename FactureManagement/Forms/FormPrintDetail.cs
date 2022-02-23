using FactureManagement.Datas;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FactureManagement.Forms
{
    public partial class FormPrintDetail : MetroFramework.Forms.MetroForm
    {

        DataContext db = new DataContext();
        DataSet2 ds = new DataSet2();
        SQLiteDataAdapter Da { get; set; }
        public FormPrintDetail()
        {
            InitializeComponent();
            //GetReport();
        }

        private void GetReport()
        {
            try
            {
                db.connect();
                this.reportViewer1.LocalReport.ReportPath = Application.StartupPath + "\\clientStatsReport.rdlc";/*"D:\\RT GROUP\\Syscompta Full\\FactureManagement\\DetailClientReport.rdlc*/
                Da = new SQLiteDataAdapter("SELECT FACTURE.datecreateFac, FACTURE.numFac, FACTURE.montantFac, FACTURE.devisefac, FACTURE.idcli, CLIENT.nomcli, CLIENT.tel, PAIEMENT.montantpaie, PAIEMENT.devisepaie, PAIEMENT.montantres, PAIEMENT.modepaie, PAIEMENT.datepaie FROM CLIENT INNER JOIN FACTURE ON CLIENT.idcli = FACTURE.idcli INNER JOIN  PAIEMENT ON FACTURE.numFac = PAIEMENT.numFac", db.con);
                Da.SelectCommand.CommandType = CommandType.Text;
                Da.Fill(ds.Tables["DataTableClient"]);
                db.disconnect();
                var reportSource = new ReportDataSource("DataSet1", ds.Tables["DataTableClient"]);
                this.reportViewer1.LocalReport.DataSources.Add(reportSource);
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

        private void FormPrintDetail_Load(object sender, EventArgs e)
        {
            GetReport();
        }
    }
}
