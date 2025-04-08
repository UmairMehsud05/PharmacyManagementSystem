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

namespace PharmacyMgt
{
    public partial class frmDistributorReport : Form
    {
        public frmDistributorReport()
        {
            InitializeComponent();

            DataTable dt = BL_Distributor.DistributorReport();
            ReportDocument rd = new ReportDocument();
            rd.Load(@"C:\Users\Umair\Desktop\PharmacyMgt\PharmacyMgt\Reports\rptDistributor.rpt");
            rd.SetDataSource(dt);
            DistributorcrystalReportViewer.ReportSource = rd;

        }
    }
}
