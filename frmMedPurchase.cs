using CrystalDecisions.CrystalReports.Engine;
using PharmacyMgt.BL;
using PharmacyMgt.BL.custom;
using PharmacyMgt.DL;
using PharmacyMgt.Reports;
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
    public partial class frmMedPurchase : Form
    {
        static DataTable dtList = new DataTable();
        public static string Invoice;
        public static int medid;
        public frmMedPurchase()
        {
            InitializeComponent();
            Medicine();
            GenerateInvoicNo();
            dtList.Clear();
            GridView(1);
        }

        void GenerateInvoicNo()
        {
            string query = "select ISNULL(max(InvoiceNo),0) from tbl_MedPurchase";
            DataTable dt = db.Table(query);
            txtInoiceNo.Text = Convert.ToString(Convert.ToInt32(dt.Rows[0][0]) + 1);
        }

        void Medicine()
        {
            ddlMedical.DataSource = BL_Medicine.AllMedicine(1);
            ddlMedical.DisplayMember = "MedName";
            ddlMedical.ValueMember = "MedID";
            ddlMedical.SelectedIndex = -1;
        }

        void GridView(int PStatus)
        {
            DGV.DataSource = BL_MedPurchase.AllPurchase(PStatus);
            DGV.Columns["PStatus"].Visible = false;
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (ddlMedical.SelectedIndex == -1)
            {
                MessageBox.Show("Please select Medicine");
                txtInoiceNo.Focus();
            }
            else if (txtQuantity.Text == string.Empty)
            {
                txtQuantity.Text = "1";
            }
            else if (txtDiscount.Text == string.Empty)
            {
                txtDiscount.Text = "0";
            }
            else if (txtBonus.Text == string.Empty)
            {
                txtBonus.Text = "0";
            }
            else
            {
                if (dtList.Rows.Count == 0)
                {
                    dtList.Columns.Clear();
                    dtList.Columns.Add("MedicineId");
                    dtList.Columns.Add("Medicine");
                    dtList.Columns.Add("InvoiceNo");
                    dtList.Columns.Add("QTY");
                    dtList.Columns.Add("Price");
                    dtList.Columns.Add("Bonus");
                    dtList.Columns.Add("Discount");
                   }
                DataTable dt = db.Table("select * from tbl_Medicine where MedId=" + Convert.ToInt32(ddlMedical.SelectedValue));
                DataRow dr = dtList.NewRow();
                DataRow[] dupvalues = dtList.Select("Medicine like '%" + ddlMedical.Text + "%'");
                if(dupvalues.Length==0)
                {
                    dr["MedicineId"] = ddlMedical.SelectedValue;
                    dr["Medicine"] = Convert.ToString(dt.Rows[0]["MedName"]);
                    dr["InvoiceNo"] = txtInoiceNo.Text;
                    dr["QTY"] = txtQuantity.Text;
                    dr["Price"] = txtPurchasePrice.Text;
                    dr["Bonus"] = txtBonus.Text;
                    dr["Discount"] = txtDiscount.Text;
                    dtList.Rows.Add(dr);
                }
                else
                {
                    dupvalues[0]["QTY"] = Convert.ToInt32(dupvalues[0]["QTY"]) + Convert.ToInt32(txtQuantity.Text);
                    dtList.AcceptChanges();
                }
                gdvList.DataSource = dtList;
                gdvList.Columns["MedicineId"].Visible = false;
            }
        }

        void Clear()
        {
            ddlMedical.SelectedIndex = -1;
            txtQuantity.Text = "1";
            txtPurchasePrice.Text = "1";
            txtDiscount.Text = "0";
            txtBonus.Text = "0";
        }
        private void txtQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 8 || e.KeyChar >= 48 && e.KeyChar <= 57)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtPurchasePrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 8 || e.KeyChar >= 48 && e.KeyChar <= 57)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtDiscount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 8 || e.KeyChar >= 48 && e.KeyChar <= 57)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtBonus_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 8 || e.KeyChar >= 48 && e.KeyChar <= 57)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtInoiceNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 8 || e.KeyChar >= 48 && e.KeyChar <= 57)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dtList.Rows.Count; i++)
            {
                BL_MedPurchase o = new BL_MedPurchase();
                o.MedicineId = Convert.ToInt32(dtList.Rows[i]["MedicineId"]);
                o.InvoiceNo = txtInoiceNo.Text;
                o.Qty = Convert.ToInt32(dtList.Rows[i]["QTY"]);
                o.PPrice = Convert.ToInt32(dtList.Rows[i]["Price"]);
                o.Discount = Convert.ToInt32(dtList.Rows[i]["Discount"]);
                o.Bonus = Convert.ToInt32(dtList.Rows[i]["Bonus"]);
                o.PDate = DateTime.Now;
                o.PStatus = 0;
                o.InsertMedPurchase();

                BL_Stock s = new BL_Stock();
                //s.PurchaseId = Convert.ToInt32(dtList.Rows[i]["PurchaseId"]);
                s.MedicineId = Convert.ToInt32(dtList.Rows[i]["MedicineId"]);
                s.InvoiceNo = Convert.ToString(dtList.Rows[i]["InvoiceNo"]); 
                s.TotalQTY = Convert.ToInt32(dtList.Rows[i]["QTY"]) + Convert.ToInt32(dtList.Rows[i]["Bonus"]);
                s.AvailableQTY = s.TotalQTY ;
                s.SoldQTY = 0;
                s.PPrice = Convert.ToInt32(dtList.Rows[i]["Price"]);
                s.Date = DateTime.Now;
                s.Status = 1;
                s.InsertStock();
                // Despirin --> 10 QTY --> per QTy price Rs5 ---> Total Price Rs 50 --> Discount 10%
                // Per QtyPrice Rs 5 ---> Total Price Rs 50 ---> Discount Rs 50x10% = Rs10 ---> Net Price = Rs 40
            }
            MessageBox.Show(MyMessage.msg);
            Clear();
            GenerateInvoicNo();
            dtList.Clear();
            GridView(1);
        }


        
        private void DGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Invoice = Convert.ToString(DGV.Rows[e.RowIndex].Cells["InvoiceNo"].Value);
            if (e.ColumnIndex == 0)
            {
                BL_MedPurchase o = new BL_MedPurchase();
                o.PStatus = 1;
                o.Update(Invoice);
                GridView(1);
            }
            else
            if (e.ColumnIndex == 1)
            {
                frmPurchaseDetail p = new frmPurchaseDetail();
                p.Purchase(Invoice);
                p.Show();
            }
            
        }
        private void btnPaid_Click(object sender, EventArgs e)
        {
            BL_MedPurchase.AllPurchase(1);
            GridView(1);
        }

        private void btnUnPaid_Click(object sender, EventArgs e)
        {
            BL_MedPurchase.AllPurchase(0);
            GridView(0);
        }
        
    }
}
