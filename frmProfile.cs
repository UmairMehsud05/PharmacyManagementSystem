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
    public partial class frmProfile : Form
    {
        public frmProfile()
        {
            InitializeComponent();
            data();
        }

        void data()
        {
            BL_Admin o = new BL_Admin();
            o.Profile(LogInForm.AdminID);
            txtName.Text = o.adminname;
            txtPassword.Text = o.adminpassword;
            txtContact.Text = o.admincontact;
            txtEmail.Text = o.adminemail;
            txtCNIC.Text = o.adminCnic;
            txtAddress.Text = o.adminaddress;
            if (!string.IsNullOrEmpty(o.adminimage))
            {
                LoadImage(o.adminimage);
            }

        }

        public void LoadImage(string base64String)
        {
            // Convert Base64 String to byte[]
            byte[] imageBytes = Convert.FromBase64String(base64String);
            MemoryStream ms = new MemoryStream(imageBytes, 0, imageBytes.Length);

            // Convert byte[] to Image
            ms.Write(imageBytes, 0, imageBytes.Length);
            pictureBox1.Image = Image.FromStream(ms, true);
            //true means we want to load colorfull images.
        }
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

        private void txtAddress_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 65 && e.KeyChar <= 90 || e.KeyChar >= 97 && e.KeyChar <= 122 || e.KeyChar == 32 || e.KeyChar == 8)
            {
                e.Handled = false;
            }
            else if (e.KeyChar == 13)
            {
                e.Handled = true;
                pictureBox1.Focus();
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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            BL_Admin o = new BL_Admin();
            o.adminid = LogInForm.AdminID;
            o.adminname = txtName.Text;
            o.adminemail = txtEmail.Text;
            o.admincontact = txtContact.Text;
            o.adminpassword = txtPassword.Text;
            o.adminCnic = txtCNIC.Text;
            o.adminaddress = txtAddress.Text;
            o.adminimage = SaveImage(pictureBox1.Image);
            o.SignUp();
            MessageBox.Show(MyMessage.msg);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            DialogResult dr = ofd.ShowDialog();
            if (dr == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(ofd.FileName);
            }
        }
    }
}
