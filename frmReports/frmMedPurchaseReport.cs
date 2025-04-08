using CrystalDecisions.CrystalReports.Engine;
using PharmacyMgt.BL;
using PharmacyMgt.BL.custom;
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
    public partial class frmMedPurchaseReport : Form
    {
        public frmMedPurchaseReport()
        {
            InitializeComponent();

            DataTable dt = BL_MedPurchase.PurchaseReport();
            ReportDocument rd = new ReportDocument(); 
            rd.Load(@"C:\Users\Umair\Desktop\PharmacyMgt\PharmacyMgt\Reports\rptMedPurchase.rpt");
            rd.SetDataSource(dt);
            MedPurchasecrystalReportViewer.ReportSource = rd;
        }
    }
}
