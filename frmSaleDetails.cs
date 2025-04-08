using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Windows.Forms;
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
    public partial class frmSaleDetails : Form
    {
        public frmSaleDetails()
        {
            InitializeComponent();

        }

        public void Details(string invoice)
        {
            DataTable dt= BL_MedSale.SaleDetail(invoice);
            ReportDocument rpts = new ReportDocument();
            rpts.Load(@"C:\Users\Umair\Desktop\PharmacyMgt\PharmacyMgt\Reports\rptMedSale.rpt");
            rpts.SetDataSource(dt);
            crystalReportViewer1.ReportSource = rpts;

            //datagridview.DataSource = dt; 
            //datagridview.Columns["SStatus"].Visible = false;
            //datagridview.Columns["MedicineId"].Visible = false;
        }
        
    }
}
