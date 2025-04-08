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
    public partial class frmManufacturer : Form
    {
        int status;
        int ManufacturerID;
        public frmManufacturer()
        {
            InitializeComponent();
            Gridview(1);
        }
        

        void Gridview(int status)
        {
            DGV.DataSource = BL_Manufacturer.AllManufacturer(status);
            DGV.Columns["ManufacturerID"].Visible = false;
            DGV.Columns["Gender"].Visible = false;
            DGV.Columns["Status"].Visible = false;
        }

        private void DGV_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                BL_Manufacturer o = new BL_Manufacturer(Convert.ToInt32(DGV.Rows[e.RowIndex].Cells["ManufacturerID"].Value));
                ManufacturerID = o.ManufacturerID;
                txtComName.Text = o.CompanyName;
                txtEmail.Text = o.Email;
                txtContact.Text = o.Contact;
                txtManagerName.Text = o.ManagerName;
                txtGender.SelectedIndex = Convert.ToInt32(o.Gender);
                txtAddress.Text = o.Address;
                txtZipCode.Text = o.ZipCode.ToString();
                txtStatus.SelectedIndex = o.Status;
                btnAdd.Text = "Update";
                MyTab.SelectedTab = tab_AddManufacturer;
                tab_AddManufacturer.Text = "Update Manufacturer";
            }
            else if (e.ColumnIndex == 1)
            {

                if (MessageBox.Show("Are you sure want to delete this data?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    BL_Manufacturer o = new BL_Manufacturer();
                    o.ManufacturerID = Convert.ToInt32(DGV.Rows[e.RowIndex].Cells["ManufacturerID"].Value);
                    o.Delete();
                    MessageBox.Show(MyMessage.msg);
                    Gridview(1);
                }

            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtComName.Text == string.Empty)
            {
                MessageBox.Show("Please enter your Company name");
                txtEmail.Focus();
            }
            else if (txtEmail.Text == string.Empty)
            {
                MessageBox.Show("Please enter your Email");
                txtContact.Focus();
            }
            else if (txtContact.Text == string.Empty)
            {
                MessageBox.Show("Please enter your Contact");
                txtManagerName.Focus();
            }
            else if (txtManagerName.Text == string.Empty)
            {
                MessageBox.Show("Please enter Manager Name");
                txtGender.Focus();
            }
            else if (txtGender.SelectedIndex < 0)
            {
                MessageBox.Show("Please enter your Gender");
                txtAddress.Focus();
            }
            else if (txtAddress.Text == string.Empty)
            {
                MessageBox.Show("Please enter your Address");
                txtZipCode.Focus();
            }
            else if (txtZipCode.Text == string.Empty)
            {
                MessageBox.Show("Please enter your ZipCode");
                txtStatus.Focus();
            }
            else if (txtStatus.SelectedIndex < 0)
            {
                MessageBox.Show("Please enter your Status");
                txtComName.Focus();
            }
            else
            {
                BL_Manufacturer o = new BL_Manufacturer();
                o.IsNew = true;
                if (ManufacturerID > 0)
                {
                    o.IsNew = false;
                    o.ManufacturerID = ManufacturerID;
                    btnAdd.Text = "Add";
                }
                o.CompanyName = txtComName.Text;
                o.Email = txtEmail.Text;
                o.Contact = txtContact.Text;
                o.Address = txtAddress.Text;
                o.ManagerName = txtManagerName.Text;
                o.Gender = txtGender.SelectedIndex;
                o.ZipCode = txtZipCode.Text;
                o.Status = txtStatus.SelectedIndex;
                o.AddOrUpdate();
                MessageBox.Show(MyMessage.msg);
                MyTab.SelectedTab = tab_ManufacturerDetails;
                tab_AddManufacturer.Text = "Add Manufacturer";
                Clear();
                Gridview(1);
                ManufacturerID = 0;
            }
        }
    
    void Clear()
    {
        txtComName.Text = string.Empty;
        txtEmail.Text = string.Empty;
        txtContact.Text = string.Empty;
        txtAddress.Text = string.Empty;
        txtGender.SelectedIndex = -1;
        txtManagerName.Text = string.Empty;
        txtZipCode.Text = string.Empty;
        txtStatus.SelectedIndex = -1;
        btnAdd.Text = "Add";
    }
        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }
    

        private void txtComName_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtManagerName_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtZipCode_KeyPress(object sender, KeyPressEventArgs e)
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

        private void btnActive_Click(object sender, EventArgs e)
        {
            BL_Manufacturer.AllManufacturer(1);
            Gridview(1);
        }

        private void btnInActive_Click(object sender, EventArgs e)
        {
            BL_Manufacturer.AllManufacturer(0);
            Gridview(0);
        }

        private void txtSearch_CompanyName_TextChanged(object sender, EventArgs e)
        {
            if(txtSearch_CompanyName.Text.Length>0)
            {
                DGV.DataSource = BL_Manufacturer.SearchManufacture(txtSearch_CompanyName.Text);
            }
            else
            {
                Gridview(1);
            }
        }

        private void txtSearch_Email_TextChanged(object sender, EventArgs e)
        {
            if(txtSearch_Email.Text.Length>0)
            {
                DGV.DataSource = BL_Manufacturer.SearchManufacture(null, txtSearch_Email.Text);
            }
            else
            {
                Gridview(1);
            }
        }
    }
}
