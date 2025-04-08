using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using PharmacyMgt.DL;
using PharmacyMgt.BL;

namespace PharmacyMgt
{
    public partial class frmSubCategory : Form
    {
        int ID;
        int Status;
        public frmSubCategory()
        {
            InitializeComponent();
            LoadCategory();
            GridViewData(1);
        }
        void LoadCategory()
        {
            
            ddlCategory.DataSource = BL_SubCategory.load();
            ddlCategory.DisplayMember = "CatName"; 
            ddlCategory.ValueMember = "CatID";
            ddlCategory.SelectedIndex = -1;
        }


        void GridViewData(int Status)
        {
            
            DGV.DataSource = BL_SubCategory.AllSubCategory(Status);
            DGV.Columns["SubCatID"].Visible = false;
            DGV.Columns["Status"].Visible = false;
            DGV.Columns["CatID"].Visible = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtSubCatName.Text == string.Empty)
            {
                MessageBox.Show("Please enter your SubCategory name");
                ddlStatus.Focus();
            }
            else if (ddlStatus.SelectedIndex == -1)
            {
                MessageBox.Show("Please select status");
            }
            else
            {
                BL_SubCategory o = new BL_SubCategory();
                o.IsNew = true;
                if (ID > 0)
                {
                    o.IsNew = false;
                    o.SubCatID = ID;
                    btnAdd.Text = "Add";
                }
                o.CatID = Convert.ToInt32(ddlCategory.SelectedValue);
                o.SubCatName = txtSubCatName.Text;
                o.Status = ddlStatus.SelectedIndex;
                o.AddOrUpdate();
                MessageBox.Show(MyMessage.msg);
                GridViewData(1);
                Clear();
                ID = 0;
            }
        }

              
        private void DGVdata_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex==0)
            {
                BL_SubCategory o = new BL_SubCategory(Convert.ToInt32(DGV.Rows[e.RowIndex].Cells["SubCatID"].Value));
                ID = o.SubCatID;
                ddlCategory.SelectedValue = o.CatID; ;
                txtSubCatName.Text = o.SubCatName;
                ddlStatus.SelectedIndex = o.Status;
                btnAdd.Text = "Update";
            }
            else if(e.ColumnIndex==1)
            {
                if(MessageBox.Show("Are you sure want to delete this data","Delete",MessageBoxButtons.YesNo,MessageBoxIcon.Warning)==DialogResult.Yes)
                {
                    BL_SubCategory o = new BL_SubCategory();
                    o.SubCatID = Convert.ToInt32(DGV.Rows[e.RowIndex].Cells["SubCatID"].Value);
                    o.Delete();
                    MessageBox.Show(MyMessage.msg);
                    GridViewData(1);
                }
                
            }
        }

        void Clear()
        {
            ddlCategory.SelectedValue = -1;
            txtSubCatName.Text = string.Empty;
            ddlStatus.SelectedIndex = -1;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btnActive_Click(object sender, EventArgs e)
        {
            BL_SubCategory.AllSubCategory(1);
            GridViewData(1);
        }

        private void btnInActive_Click(object sender, EventArgs e)
        {
            BL_SubCategory.AllSubCategory(0);
            GridViewData(0);
        }
    }
}
