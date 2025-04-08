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
    public partial class frmCustomerReport : Form
    {
        public frmCustomerReport()
        {
            InitializeComponent();

            DataTable dt = BL_Customer.CustomerReport();
            ReportDocument rd = new ReportDocument();
            rd.Load(@"C:\Users\Rizwan computers\Documents\Visual Studio 2015\Projects\PharmacyMgt\PharmacyMgt\Reports\rptCustomer.rpt");
            rd.SetDataSource(dt);
            CustomercrystalReportViewer.ReportSource = rd;
        }
    }
}
