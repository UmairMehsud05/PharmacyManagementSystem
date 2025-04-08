using PharmacyMgt.BL;
using PharmacyMgt.DL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PharmacyMgt
{
    public partial class SignUpForm : MetroFramework.Forms.MetroForm
    {
        string query;
        public SignUpForm()
        {
            InitializeComponent();
        }

        void Clear()
        {
            txtName.Text = "";
            txtPassword.Text = "";
            txtEmail.Text = "";
            txtContact.Text = "";
            txtCNIC.Text = "";
            txtAddress.Text = "";
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        //public string SaveImage()
        //{
        //    Image img = picbox.Image;
        //    MemoryStream ms = new MemoryStream();
        //    img.Save(ms, ImageFormat.Jpeg);
        //    byte[] ar = new byte[ms.Length];
        //    ms.Write(ar, 0, ar.Length);
        //    return Convert.ToBase64String(ar);
        //}

        public string SaveImage(Image image)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                // Convert Image to byte[]
                image.Save(ms, ImageFormat.Png);
                byte[] imageBytes = ms.ToArray();

                // Convert byte[] to Base64 String
                string base64String = Convert.ToBase64String(imageBytes);
                return base64String;
            }
        }


        private void btnsignup_Click(object sender, EventArgs e)
        {
            if (txtName.Text == string.Empty)
            {
                MessageBox.Show("Please enter your name");
                txtPassword.Focus();
            }
            else if (txtPassword.Text == string.Empty)
            {
                MessageBox.Show("Please enter your Password");
                txtContact.Focus();
            }
            else if (txtContact.Text == string.Empty)
            {
                MessageBox.Show("Please enter your Contact");
                txtEmail.Focus();
            }
            else if (txtEmail.Text == string.Empty)
            {
                MessageBox.Show("Please enter your Email");
                txtCNIC.Focus();
            }
            else if (txtCNIC.Text == string.Empty)
            {
                MessageBox.Show("Please enter your CNIC");
                txtAddress.Focus();
            }
            else if (txtAddress.Text == string.Empty)
            {
                MessageBox.Show("Please enter your Address");
                txtName.Focus();
            }
            else
            {
                BL_Admin o = new BL_Admin();
                o.adminname = txtName.Text;
                o.adminpassword = txtPassword.Text;
                o.admincontact = txtContact.Text;
                o.adminemail = txtEmail.Text;
                o.adminCnic = txtCNIC.Text;
                o.adminaddress = txtAddress.Text;
                if (picbox.Image != null)
                {
                    o.adminimage = SaveImage(picbox.Image);
                }

                o.SignUp();
                if (o.IsNew == false)
                {
                    MessageBox.Show(MyMessage.msg);
                }
                else if (o.IsNew == true)
                {
                    MessageBox.Show(MyMessage.msg);
                    Clear();
                }

            }
        }

        private void picbox_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            DialogResult dr = ofd.ShowDialog();
            if (dr == DialogResult.OK)
            {
                picbox.Image = Image.FromFile(ofd.FileName);
            }
        }

        private void btnLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new LogInForm().Show();
            this.Hide();
        }

        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 65 && e.KeyChar <= 90 || e.KeyChar >= 97 && e.KeyChar <= 122 || e.KeyChar == 32 || e.KeyChar == 8)
            {
                e.Handled = false;
            }
            else if (e.KeyChar == 13)
            {
                e.Handled = true;
                txtPassword.Focus();
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 65 && e.KeyChar <= 90 || e.KeyChar >= 97 && e.KeyChar <= 122 || e.KeyChar >= 33 && e.KeyChar <= 38 || e.KeyChar == 8 || e.KeyChar >= 48 && e.KeyChar <= 57)
            {
                e.Handled = false;
            }
            else if (e.KeyChar == 13)
            {
                e.Handled = true;
                txtContact.Focus();
            }
            else if (txtPassword.Text.Length < 10 && txtPassword.Text.Length > 7)
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
            else if (e.KeyChar == 13)
            {
                e.Handled = true;
                txtEmail.Focus();
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
            else if (e.KeyChar == 13)
            {
                e.Handled = true;
                txtCNIC.Focus();
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtCNIC_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 48 && e.KeyChar <= 57 || e.KeyChar == 8 || e.KeyChar == 45)
            {
                e.Handled = false;
            }
            else if (e.KeyChar == 13)
            {
                e.Handled = true;
                txtAddress.Focus();
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
            else if (e.KeyChar == 13)
            {
                e.Handled = true;
                btnsignup.Focus();
            }
            else
            {
                e.Handled = true;
            }
        }

        private void CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBox.Checked == false)
            {
                txtPassword.UseSystemPasswordChar = true;
                CheckBox.Text = "Show Password";
            }
            else
            {
                txtPassword.UseSystemPasswordChar = false;
                CheckBox.Text = "Hide Password";
            }
        }
    }
}
