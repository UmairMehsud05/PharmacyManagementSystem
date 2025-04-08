using CrystalDecisions.CrystalReports.Engine;
using PharmacyMgt.BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PharmacyMgt.frmReports
{
    public partial class frmStockReport : Form
    {
        public frmStockReport()
        {
            InitializeComponent();

            DataTable dt = BL_Stock.StockReport();
            ReportDocument rd = new ReportDocument();
            rd.Load(@"C:\Users\Umair\Desktop\PharmacyMgt\PharmacyMgt\Reports\rptStock.rpt");
            rd.SetDataSource(dt);
            StockcrystalReportViewer.ReportSource = rd;

        }
    }
}
