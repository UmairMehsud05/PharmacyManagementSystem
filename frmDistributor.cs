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
    public partial class frmDistributor : Form
    {
        int DisID;
        int status;
        public frmDistributor()
        {
            InitializeComponent();
            GridView(1);
        }

        private void txtName_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 65 && e.KeyChar <= 90 || e.KeyChar >= 97 && e.KeyChar <= 122 || e.KeyChar == 32 || e.KeyChar == 8)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtShopName_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 65 && e.KeyChar <= 90 || e.KeyChar >= 97 && e.KeyChar <= 122 || e.KeyChar == 32 || e.KeyChar == 8)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtEmail_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 65 && e.KeyChar <= 90 || e.KeyChar >= 97 && e.KeyChar <= 122 || e.KeyChar == 8 || e.KeyChar >= 48 && e.KeyChar <= 57 || e.KeyChar == 46 || e.KeyChar == 64)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtContact_KeyPress_1(object sender, KeyPressEventArgs e)
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

        private void txtCnic_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 48 && e.KeyChar <= 57 || e.KeyChar == 45 || e.KeyChar == 8)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtAddress_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 65 && e.KeyChar <= 90 || e.KeyChar >= 97 && e.KeyChar <= 122 || e.KeyChar == 32 || e.KeyChar == 8)
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
            if (txtName.Text == string.Empty)
            {
                MessageBox.Show("Please enter your Name.");
                txtShopName.Focus();
            }
            else if (txtShopName.Text == string.Empty)
            {
                MessageBox.Show("Please enter ShopName");
                txtEmail.Focus();
            }
            else if (txtEmail.Text == string.Empty)
            {
                MessageBox.Show("Please enter your email");
                txtContact.Focus();
            }
            else if (txtContact.Text == string.Empty)
            {
                MessageBox.Show("Please enter your contact");
                txtCnic.Focus();
            }
            else if (txtCnic.Text == string.Empty)
            {
                MessageBox.Show("Please enter your CNIC");
                txtAddress.Focus();
            }
            else if (txtAddress.Text == string.Empty)
            {
                MessageBox.Show("Please enter your address");
                txtPostCode.Focus();
            }
            else if (txtPostCode.Text == string.Empty)
            {
                MessageBox.Show("Please enter your PostCode");
                txtStatus.Focus();
            }
            else if (txtStatus.SelectedIndex == -1)
            {
                MessageBox.Show("Please Select your status");
                txtName.Focus();
            }
            else
            {
                BL_Distributor o = new BL_Distributor();
                o.Isnew = true;
                if (DisID > 0)
                {
                    o.Isnew = false;
                    o.DistributerId = DisID;
                    btnAdd.Text = "Add";
                }
                o.Name = txtName.Text;
                o.ShopName = txtShopName.Text;
                o.Email = txtEmail.Text;
                o.Contact = txtContact.Text;
                o.CNIC = txtCnic.Text;
                o.Address = txtAddress.Text;
                o.PostalCode = txtPostCode.Text;
                o.Status = txtStatus.SelectedIndex;
                o.AddOrUpdate();
                MessageBox.Show(MyMessage.msg);
                Tab.SelectedTab = tab_Details;
                tab_Add.Text = "add distributor";
                Clear();
                GridView(1);
                DisID = 0;
            }
        }

        void GridView(int status)
        {
            DGV.DataSource = BL_Distributor.AllDistributor(status);
            DGV.Columns["DistributerId"].Visible = false;
            DGV.Columns["Status"].Visible = false;
        }
        private void DGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                BL_Distributor o = new BL_Distributor(Convert.ToInt32(DGV.Rows[e.RowIndex].Cells["DistributerId"].Value));
                DisID = o.DistributerId;
                txtName.Text = o.Name;
                txtShopName.Text = o.ShopName;
                txtEmail.Text = o.Email;
                txtContact.Text = o.Contact;
                txtCnic.Text = o.CNIC;
                txtAddress.Text = o.Address;
                txtPostCode.Text = o.PostalCode;
                txtStatus.SelectedIndex = o.Status;
                btnAdd.Text = "Update";
                Tab.SelectedTab = tab_Add;
                tab_Add.Text = "Update Distributor";
            }
            else
                if (e.ColumnIndex == 1)
            {
                if (MessageBox.Show("Are you sure want to delete Data?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    BL_Distributor o = new BL_Distributor();
                    o.DistributerId = Convert.ToInt32(DGV.Rows[e.RowIndex].Cells["DistributerId"].Value);
                    o.DeleteDistributor();
                    MessageBox.Show(MyMessage.msg);
                    GridView(1);
                }
            }

        }

        void Clear()
        {
            txtName.Text = string.Empty;
            txtShopName.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtContact.Text = string.Empty;
            txtCnic.Text = string.Empty;
            txtAddress.Text = string.Empty;
            txtPostCode.Text = string.Empty;
            txtStatus.SelectedIndex = -1;
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
            btnAdd.Text = "Add";
            tab_Add.Text = "Add Distributor";
        }

        private void btnActive_Click_1(object sender, EventArgs e)
        {
            BL_Distributor.AllDistributor(1);
            GridView(1);
            btnActive.BackColor = Color.Gold;
            btnInActive.BackColor = Color.Teal;
        }

        private void btnInActive_Click(object sender, EventArgs e)
        {
            BL_Distributor.AllDistributor(0);
            GridView(0);
            btnActive.BackColor = Color.Teal;
            btnInActive.BackColor = Color.Gold;
        }

        private void txtSearch_Name_TextChanged(object sender, EventArgs e)
        {
            if (txtSearch_Name.Text.Length > 0)
            {
                DGV.DataSource = BL_Distributor.SearchDistributor(txtSearch_Name.Text);
            }
            else
            {
                GridView(1);
            }
        }

        private void txtSearch_CompanyName_TextChanged(object sender, EventArgs e)
        {
            if (txtSearch_CompanyName.Text.Length > 0)
            {
                DGV.DataSource = BL_Distributor.SearchDistributor(null, txtSearch_CompanyName.Text);
            }
            else
            {
                GridView(1);
            }
        }

        private void txtSearch_Email_TextChanged(object sender, EventArgs e)
        {
            if (txtSearch_Email.Text.Length > 0)
            {
                DGV.DataSource = BL_Distributor.SearchDistributor(null, null, txtSearch_Email.Text);
            }
            else
            {
                GridView(1);
            }
        }

        private void txtSearch_CNIC_TextChanged(object sender, EventArgs e)
        {
            if (txtSearch_CNIC.Text.Length > 0)
            {
                DGV.DataSource = BL_Distributor.SearchDistributor(null, null, null, txtSearch_CNIC.Text);
            }
            else
            {
                GridView(1);
            }
        }
    }
}
