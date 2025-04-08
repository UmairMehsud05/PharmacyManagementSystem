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
    public partial class frmSubCategoryReport : Form
    {
        public frmSubCategoryReport()
        {
            InitializeComponent();

            DataTable dt = BL_SubCategory.SubCategoryReport();
            ReportDocument rd = new ReportDocument();
            rd.Load(@"C:\Users\Umair\Desktop\PharmacyMgt\PharmacyMgt\Reports\rptSubCategory.rpt");
            rd.SetDataSource(dt);
            SubCatcrystalReportViewer.ReportSource = rd;
        }
    }
}
