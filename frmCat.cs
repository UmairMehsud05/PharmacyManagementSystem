using PharmacyMgt.BL;
using PharmacyMgt.DL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PharmacyMgt
{
    public partial class frmCat : Form
    {
        int CatId;
        public frmCat()
        {
            InitializeComponent();
            GridViewData(1);
        }

        void GridViewData(int status)
        {
            DGVdata.DataSource = BL_Category.AllCat(status);
            DGVdata.Columns["CatID"].Visible = false;
            DGVdata.Columns["CatStatus"].Visible = false;
        }

        private void DGVdata_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == 0)
                {
                    
                    BL_Category o = new BL_Category(Convert.ToInt32(DGVdata.Rows[e.RowIndex].Cells["CatID"].Value));

                    
                    if (o == null)
                    {
                        MessageBox.Show("BL_Category object is null!");
                        return;
                    }

                    
                    CatId = o.CatID;
                    txtCatName.Text = o.CatName;

                    
                    if (o.CatStatus >= 0 && o.CatStatus < ddlStatus.Items.Count)
                    {
                        ddlStatus.SelectedIndex = o.CatStatus;
                    }
                    else
                    {
                        MessageBox.Show("Invalid CatStatus value: " + o.CatStatus);
                        ddlStatus.SelectedIndex = 0; 
                    }

                    btnAdd.Text = "Update";
                }
                else if (e.ColumnIndex == 1)
                {
                    if (MessageBox.Show("Are you sure want to delete data?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        BL_Category o = new BL_Category();
                        o.CatID = Convert.ToInt32(DGVdata.Rows[e.RowIndex].Cells["CatID"].Value);
                        o.DeleteCat();
                        MessageBox.Show(MyMessage.msg);
                        GridViewData(1);
                    }
                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show("An error occurred: " + ex.Message + "\n" + ex.StackTrace);
            }
        }
        

        private void btnClear_Click(object sender, EventArgs e)
        {
            clear();
            btnAdd.Text = "Add";
        }
        void clear()
        {
            txtCatName.Text = string.Empty;
            ddlStatus.SelectedIndex = -1;
        }

        private void txtCatName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 65 && e.KeyChar <= 90 || e.KeyChar >= 97 && e.KeyChar <= 122 || e.KeyChar == 8)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(txtCatName.Text==string.Empty)
            {
                MessageBox.Show("Please enter Category Name");
                ddlStatus.Focus();
            }
            else if(ddlStatus.SelectedIndex==-1)
            {
                MessageBox.Show("Please select Status");
                txtCatName.Focus();
            }
            else
            {
                BL_Category o = new BL_Category();
                o.IsNew = true;
                if (CatId > 0)
                {
                    o.IsNew = false;
                    o.CatID = CatId;
                    btnAdd.Text = "Add";
                }
                o.CatName = txtCatName.Text;
                o.CatStatus = ddlStatus.SelectedIndex;
                o.AddOrUpdate();
                MessageBox.Show(MyMessage.msg);
                clear();
                GridViewData(1);
                CatId = 0;
            }
            
        }

        private void btnActive_Click(object sender, EventArgs e)
        {
            BL_Category.AllCat(1);
            GridViewData(1);
        }

        private void btnInActive_Click(object sender, EventArgs e)
        {
            BL_Category.AllCat(0);
            GridViewData(0);
        }
    }
}
