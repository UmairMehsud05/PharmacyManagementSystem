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
    public partial class frmCustomer : Form
    {
        int customerID;
        public frmCustomer()
        {
            InitializeComponent();
            GridView(1);
        }

        void GridView(int Status)
        {
            DGV.DataSource = BL_Customer.AllCustomer(Status);
            DGV.Columns["customerID"].Visible = false;
            DGV.Columns["customerStatus"].Visible = false;

        }

        private void DGV_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                BL_Customer o = new BL_Customer(Convert.ToInt32(DGV.Rows[e.RowIndex].Cells["customerID"].Value));
                customerID = o.customerID;
                txtName.Text = o.customerName;
                txtEmail.Text = o.customerEmail;
                txtContact.Text = o.customerContact;
                txtAddress.Text = o.customerAddress;
                txtCnic.Text = o.customerCNIC;
                txtStatus.SelectedIndex = o.customerStatus;
                Tab.SelectedTab = Add_Customer;
                btnAdd.Text = "Update";
            }
            else
            {
                if (e.ColumnIndex == 1)
                {
                    if (MessageBox.Show("Are you sure want to delete this Data?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        BL_Customer o = new BL_Customer();
                        o.customerID = Convert.ToInt32(DGV.Rows[e.RowIndex].Cells["customerID"].Value);
                        o.deleteCustomer();
                        MessageBox.Show(MyMessage.msg);
                        GridView(1);
                    }
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtName.Text == string.Empty)
            {
                MessageBox.Show("Please enter Your name");
                txtEmail.Focus();
            }
            else if (txtEmail.Text == string.Empty)
            {
                MessageBox.Show("Please enter Your email");
                txtContact.Focus();
            }
            else if (txtContact.Text == string.Empty)
            {
                MessageBox.Show("Please enter Your contact");
                txtCnic.Focus();
            }
            else if (txtCnic.Text == string.Empty)
            {
                MessageBox.Show("Please enter Your CNIC");
                txtAddress.Focus();
            }
            else if (txtAddress.Text == string.Empty)
            {
                MessageBox.Show("Please enter Your address");
                txtStatus.Focus();
            }
            else if (txtStatus.SelectedIndex == -1)
            {
                MessageBox.Show("Please select Status");
                txtName.Focus();
            }
            else
            {
                BL_Customer o = new BL_Customer();
                o.IsNew = true;
                if (customerID > 0)
                {
                    o.IsNew = false;
                    o.customerID = customerID;
                    btnAdd.Text = "Add";
                }
                o.customerName = txtName.Text;
                o.customerEmail = txtEmail.Text;
                o.customerContact = txtContact.Text;
                o.customerAddress = txtAddress.Text;
                o.customerCNIC = txtCnic.Text;
                o.customerStatus = txtStatus.SelectedIndex;
                o.AddOrUpdate();
                Tab.SelectedTab = Customer_Details;
                MessageBox.Show(MyMessage.msg);
                clear();
                GridView(1);
                customerID = 0;
            }
        }

        void clear()
        {
            txtName.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtContact.Text = string.Empty;
            txtAddress.Text = string.Empty;
            txtCnic.Text = string.Empty;
            txtStatus.SelectedIndex = -1;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMain obj = new frmMain();
            obj.Show();
        }

        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtEmail_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtContact_KeyPress(object sender, KeyPressEventArgs e)
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

      
        private void btnActive_Click_1(object sender, EventArgs e)
        {
            BL_Customer.AllCustomer(1);
            GridView(1);
        }

        private void btnInActive_Click_1(object sender, EventArgs e)
        {
            BL_Customer.AllCustomer(0);
            GridView(0);
        }

        private void txtSearch_Name_TextChanged(object sender, EventArgs e)
        {
            if(txtSearch_Name.Text.Length>0)
            {
                DGV.DataSource = BL_Customer.SearchCustomer(txtSearch_Name.Text);
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
                DGV.DataSource = BL_Customer.SearchCustomer(null,txtSearch_Email.Text);
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
                DGV.DataSource = BL_Customer.SearchCustomer(null,null,txtSearch_CNIC.Text);
            }
            else
            {
                GridView(1);
            }
        }
    }
}
