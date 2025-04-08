using PharmacyMgt.BL;
using PharmacyMgt.DL;
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
    public partial class frmMedSale : Form
    {
        public DataTable dtList = new DataTable();
        public static string InvoiceNo;
        public int medId;
        public int totalAvalaibleQty=0;
        public int AvailableQTY;
        public int stockId; 
        public int TotalQTY;
        public int soldQty;
        public int sold;

        public frmMedSale()
        {
            // how to find repeated data in datatable
            // how to change existing record of datatable
            InitializeComponent();
            Medicine();
            GenerateInvoiceNo();
            dtList.Clear();
            gridview(1);
        }

        void Medicine()
        {
            ddlMedical.DataSource = BL_Medicine.AllMedicine(1);
            ddlMedical.DisplayMember = "MedName";
            ddlMedical.ValueMember = "MedID";
            ddlMedical.SelectedIndex = -1;
        }
        
        void GenerateInvoiceNo()
        {
            string query = "select ISNULL(max(InvoiceNo),0) from tbl_MedSale";
            DataTable dt = db.Table(query);
            txtInoiceNo.Text = Convert.ToString(Convert.ToInt32(dt.Rows[0][0]) + 1);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (dtList.Rows.Count == 0)
            {
                dtList.Columns.Clear();
                dtList.Columns.Add("MedicineId");
                dtList.Columns.Add("Medicine");
                dtList.Columns.Add("InvoiceNo");
                dtList.Columns.Add("SaleQTY");
                dtList.Columns.Add("SalePrice");
                dtList.Columns.Add("Discount");
            }

            DataTable dt = db.Table("select * from tbl_Medicine where MedId=" + Convert.ToInt32(ddlMedical.SelectedValue));
            DataRow dr = dtList.NewRow();
            DataRow[] dupValue = dtList.Select("Medicine like '%" + ddlMedical.Text + "%'");

            if (dupValue.Length == 0)
            {
                dr["MedicineId"] = ddlMedical.SelectedValue;
                dr["Medicine"] = Convert.ToString(dt.Rows[0]["MedName"]);
                dr["InvoiceNo"] = txtInoiceNo.Text;
                dr["SaleQTY"] = txtQuantity.Text;
                dr["SalePrice"] = txtSalePrice.Text;
                dr["Discount"] = txtDiscount.Text;
                dtList.Rows.Add(dr);
            }
            else
            {
                dupValue[0]["SaleQTY"] = Convert.ToInt32(dupValue[0]["SaleQTY"])+Convert.ToInt32(txtQuantity.Text);
                dtList.AcceptChanges();
            }
            gdvList.DataSource = dtList;
            gdvList.Columns["MedicineId"].Visible = false;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            medId = Convert.ToInt32(ddlMedical.SelectedValue);
            DataTable dt= BL_Stock.saleQty(medId);
            totalAvalaibleQty = 0;
            int saleQty = Convert.ToInt32(txtQuantity.Text);
            for (int i=0;i< dt.Rows.Count;i++)
            {
                totalAvalaibleQty = Convert.ToInt32(totalAvalaibleQty) + Convert.ToInt32(dt.Rows[i]["AvailableQTY"]);
            }

            if (totalAvalaibleQty >= saleQty)
            {

                for (int i = 0; i < dtList.Rows.Count; i++)
                {
                    
                    BL_MedSale o = new BL_MedSale();
                    o.MedicineId = Convert.ToInt32(dtList.Rows[i]["MedicineId"]);
                    o.InvoiceNo = Convert.ToInt32(txtInoiceNo.Text);
                    o.QTY = Convert.ToInt32(dtList.Rows[i]["SaleQTY"]);
                    o.SalePrice = Convert.ToInt32(dtList.Rows[i]["SalePrice"]);
                    o.Discount = Convert.ToInt32(dtList.Rows[i]["Discount"]);
                    o.SaleDate = DateTime.Now;
                    o.SStatus = 1;
                    o.InsertSale();
                }
                MessageBox.Show(MyMessage.msg);
                dtList.Clear();
                GenerateInvoiceNo();
                gridview(1);

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    stockId = Convert.ToInt32(dt.Rows[i]["StockId"]);
                    saleQty = saleQty - Convert.ToInt32(dt.Rows[i]["AvailableQty"]); // -5
                    
                    //totalAvalaibleQty =
                    if (saleQty >= 0)
                    {
                        BL_Stock s = new BL_Stock();
                        sold = Convert.ToInt32(txtQuantity.Text) - Convert.ToInt32(saleQty);
                        soldQty =Convert.ToInt32(sold)+ Convert.ToInt32(dt.Rows[i]["SoldQTY"]);
                        AvailableQTY = 0;//Convert.ToInt32(dt.Rows[0]["AvailableQty"]);
                        int status = 0;
                        s.updtStock(stockId, AvailableQTY,soldQty, status);
                    }
                    else
                    {
                        saleQty = Math.Abs(saleQty);
                        sold = Convert.ToInt32(dt.Rows[i]["AvailableQty"]) - Convert.ToInt32(saleQty);
                        soldQty = Convert.ToInt32(sold) + Convert.ToInt32(dt.Rows[i]["SoldQTY"]);
                        BL_Stock s = new BL_Stock();
                        int status = 1;
                        s.updtStock(stockId, saleQty, soldQty,status);
                        break;
                    }
                }
            }
            else
            {
                MessageBox.Show("Stock is not available");
                dtList.Clear();
            }
            
        }

        void gridview(int status)
        {
            DGV.DataSource = BL_MedSale.AllSale(status);
            DGV.Columns["SStatus"].Visible = false;
        }


        private void btnPaid_Click(object sender, EventArgs e)
        {
            BL_MedSale.AllSale(1);
            gridview(1);
        }

        private void btnUnPaid_Click(object sender, EventArgs e)
        {
            BL_MedSale.AllSale(0);
            gridview(0);
        }

        private void DGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            InvoiceNo = Convert.ToString(DGV.Rows[e.RowIndex].Cells["InvoiceNo"].Value);
            if (e.ColumnIndex == 0)
            {
                BL_MedSale o = new BL_MedSale();
                int SStatus = 0;
                o.UpdateSale(InvoiceNo, SStatus);
                gridview(0);
            }
            else if (e.ColumnIndex == 1)
            {
                frmSaleDetails d = new frmSaleDetails();
                d.Details(InvoiceNo);
                d.Show();
            }
        }


    }
}
