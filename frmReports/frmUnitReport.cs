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
    public partial class frmUnitReport : Form
    {
        public frmUnitReport()
        {
            InitializeComponent();

            DataTable dt = BL_Unit.UnitReport();
            ReportDocument rd = new ReportDocument();
            rd.Load(@"C:\Users\Umair\Desktop\PharmacyMgt\PharmacyMgt\Reports\rptUnit.rpt");
            rd.SetDataSource(dt);
            UnitcrystalReportViewer.ReportSource = rd;

        }
    }
}
