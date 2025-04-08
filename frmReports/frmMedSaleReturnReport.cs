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
    public partial class frmMedSaleReturnReport : Form
    {
        public frmMedSaleReturnReport()
        {
            InitializeComponent();

            DataTable dt = BL_SaleReturn.select();
            ReportDocument rd = new ReportDocument();
            rd.Load(@"C:\Users\Umair\Desktop\PharmacyMgt\PharmacyMgt\Reports\rptMedSaleReturn.rpt");
            rd.SetDataSource(dt);
            MedSaleReturncrystalReportViewer.ReportSource = rd;

        }
    }
}
