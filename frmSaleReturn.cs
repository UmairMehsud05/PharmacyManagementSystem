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
    public partial class frmSaleReturn : Form
    {
        public int medid;
        public string InvoiceNo;
        public int QTY;
        public frmSaleReturn()
        {
            InitializeComponent();
            dataGridveiw();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            medid = Convert.ToInt32(txtMedicineName.SelectedValue);
            DataTable dt = BL_MedSale.Sale(medid, txtInvoiceNo.Text);
            if (Convert.ToInt32(txtQty.Text) <= Convert.ToInt32(dt.Rows[0]["QTY"]))
            {
                DataTable dt_Stock = BL_Stock.salereturnstock(medid);
                if(Convert.ToInt32(txtQty.Text)<=Convert.ToInt32(dt_Stock.Rows[0]["SoldQTY"]))
                {
                    BL_SaleReturn b = new BL_SaleReturn();
                    b.MedicineId = Convert.ToInt32(txtMedicineName.SelectedValue);
                    b.InvoiceNo = txtInvoiceNo.Text;
                    b.ReturnQty = Convert.ToInt32(txtQty.Text);
                    b.SalePrice = Convert.ToInt32(dt.Rows[0]["SalePrice"]);
                    b.SaleReturnDate = DateTime.Now;
                    b.saleRetInsert();

                    BL_MedSale m = new BL_MedSale();
                    m.QTY = Convert.ToInt32(dt.Rows[0]["QTY"])- Convert.ToInt32(txtQty.Text);
                    m.UpdateRetSale(Convert.ToInt32(dt.Rows[0]["SaleId"]));

                    BL_Stock s = new BL_Stock();
                    s.Status = 1;
                    s.AvailableQTY = Convert.ToInt32(dt_Stock.Rows[0]["AvailableQTY"]) + Convert.ToInt32(txtQty.Text);
                    s.SoldQTY = Convert.ToInt32(dt_Stock.Rows[0]["SoldQTY"]) - Convert.ToInt32(txtQty.Text);
                    s.updtedStock(Convert.ToInt32(dt_Stock.Rows[0]["StockId"]));
                }
            }
            else
            {
                MessageBox.Show("You does not Purchase so much Quantities");
            }
            dataGridveiw();
        }

        void dataGridveiw()
        {
            DataTable dt= BL_SaleReturn.select();
            dgv.DataSource = dt;
            dgv.Columns["MedicineId"].Visible = false;

        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            InvoiceNo = Convert.ToString(txtInvoiceNo.Text);
            DataTable dt = BL_SaleReturn.saleretrn(InvoiceNo);
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
            DataTable dt = BL_SaleReturn.saleretrn(InvoiceNo);
            txtSalePrice.Text = dt.Rows[0]["SalePrice"].ToString();
        }

        
    }
}
