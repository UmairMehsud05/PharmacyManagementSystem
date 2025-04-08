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

namespace PharmacyMgt
{
    public partial class frmReturnPurchase : Form
    {
        public static string InvoiceNo;
        public static int MedId;
        public static int status;
        public frmReturnPurchase()
        {
            InitializeComponent();
            dgridview();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            MedId = Convert.ToInt32(txtMedicineName.SelectedValue);
            DataTable purchase_dt = BL_MedPurchase.purchase(txtInvoiceNo.Text, MedId);
            if (Convert.ToInt32(txtQty.Text) <= Convert.ToInt32(purchase_dt.Rows[0]["Qty"]))
            {
                DataTable stock_dt = BL_Stock.Stock(txtInvoiceNo.Text, MedId);
                if (Convert.ToInt32(txtQty.Text) <= Convert.ToInt32(stock_dt.Rows[0]["AvailableQTY"]))
                {
                    BL_ReturnPurchase b = new BL_ReturnPurchase();
                    b.MedicineId = Convert.ToInt32(txtMedicineName.SelectedValue);
                    b.InvoiceNo = txtInvoiceNo.Text;
                    b.QTY = Convert.ToInt32(txtQty.Text);
                    b.PPrice = Convert.ToInt32(purchase_dt.Rows[0]["PPrice"]);
                    b.RDate = DateTime.Now;
                    b.insert();

                    BL_Stock t = new BL_Stock();
                    t.TotalQTY = Convert.ToInt32(stock_dt.Rows[0]["TotalQTY"]) - (Convert.ToInt32(txtQty.Text));
                    t.AvailableQTY = Convert.ToInt32(stock_dt.Rows[0]["AvailableQTY"]) - (Convert.ToInt32(txtQty.Text));
                    t.updateStock(Convert.ToInt32(stock_dt.Rows[0]["StockId"]));

                    BL_MedPurchase p = new BL_MedPurchase();
                    p.Qty = Convert.ToInt32(purchase_dt.Rows[0]["Qty"]) - Convert.ToInt32(txtQty.Text);
                    p.UpdatePur(Convert.ToInt32(purchase_dt.Rows[0]["PurchaseId"]));
                    MessageBox.Show("Selected Medicine returned successfully");
                }
                else
                {
                    MessageBox.Show("You did not have so much Stock");
                }
            }
            else
            {
                MessageBox.Show("You didn't return so much");
            }
            dgridview();
        }

        void dgridview()
        {
           DataTable dt= BL_ReturnPurchase.showreturnPur();
            dgv.DataSource = dt;
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            InvoiceNo = Convert.ToString(txtInvoiceNo.Text);
            DataTable dt = BL_ReturnPurchase.ReturnPur(Convert.ToInt32(InvoiceNo));
            if (dt.Rows.Count > 0)
            {
                txtMedicineName.DataSource = dt;
                txtMedicineName.DisplayMember = "MedName";
                txtMedicineName.ValueMember = "MedicineId";
                txtMedicineName.SelectedIndex = -1;
            }
            else
            {
                MessageBox.Show("Values not found!");
            }
        }

        private void txtMedicineName_SelectionChangeCommitted(object sender, EventArgs e)
        {
            DataTable dt = BL_ReturnPurchase.ReturnPur(Convert.ToInt32(InvoiceNo));
            txtPPrice.Text = dt.Rows[0]["PPrice"].ToString();
        }
    }
}
