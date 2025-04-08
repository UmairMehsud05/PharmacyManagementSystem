using PharmacyMgt.frmReports;
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
    public partial class frmReport : Form
    {
        public frmReport()
        {
            InitializeComponent();
        }

        private void btnCateReport_Click(object sender, EventArgs e)
        {
            frmCateReport cat = new frmCateReport();
            cat.Show();
        }

        private void btnCustomerReport_Click(object sender, EventArgs e)
        {
            frmCustomerReport cus = new frmCustomerReport();
            cus.Show();
        }

        private void btnDistributorReport_Click(object sender, EventArgs e)
        {
            frmDistributorReport d = new frmDistributorReport();
            d.Show();
        }

        private void btnManufReport_Click(object sender, EventArgs e)
        {
            frmManufacturerReport m = new frmManufacturerReport();
            m.Show();
        }

        private void btnMedicineReport_Click(object sender, EventArgs e)
        {
            frmMedicineReport m = new frmMedicineReport();
            m.Show();
        }

        private void btnMedPurchaseReport_Click(object sender, EventArgs e)
        {
            frmMedPurchaseReport mr = new frmMedPurchaseReport();
            mr.Show();
        }

        private void btnMedPurReturnReport_Click(object sender, EventArgs e)
        {
            frmMedPurReturnReport pr = new frmMedPurReturnReport();
            pr.Show();
        }

        private void btnMedSaleReport_Click(object sender, EventArgs e)
        {
            frmMedSaleReport s = new frmMedSaleReport();
            s.Show();
        }

        private void btnMedSaleReturnReport_Click(object sender, EventArgs e)
        {
            frmMedSaleReturnReport sr = new frmMedSaleReturnReport();
            sr.Show();
        }

        private void btnMedStockReport_Click(object sender, EventArgs e)
        {
            frmStockReport s = new frmStockReport();
            s.Show();
        }

        private void btnSubCateReport_Click(object sender, EventArgs e)
        {
            frmSubCategoryReport sc = new frmSubCategoryReport();
            sc.Show();
        }

        private void btnUnitReport_Click(object sender, EventArgs e)
        {
            frmUnitReport u = new frmUnitReport();
            u.Show();
        }
    }
}
