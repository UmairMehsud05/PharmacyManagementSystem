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
    public partial class LogInForm : MetroFramework.Forms.MetroForm
    {
        public static string AdminName;
        public static int AdminID;
        public LogInForm()
        {
            InitializeComponent();
        }

        private void btnSignup_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SignUpForm form = new SignUpForm();
            form.Show();
            this.Hide();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            BL_Admin o = new BL_Admin();
            o.adminemail = txtEmail.Text;
            o.adminpassword = txtPassword.Text;
            o.LogIN();
            if (o.IsNew == true)
            {
                AdminID = o.adminid;
                AdminName = o.adminname;
                new frmMain().Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Login falied. Email or Password is invalid");
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
                txtPassword.Focus();
            }
            else
            {
                e.Handled = true;
            }
        }

        private void checkbox_CheckedChanged(object sender, EventArgs e)
        {
            if (checkbox.Checked == false)
            {
                txtPassword.UseSystemPasswordChar = true;
                checkbox.Text = "Show Password";
            }
            else
            {
                txtPassword.UseSystemPasswordChar = false;
                checkbox.Text = "Hide Password";
            }
        }

        private void txtPassword_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 65 && e.KeyChar <= 90 || e.KeyChar >= 97 && e.KeyChar <= 122 || e.KeyChar >= 33 && e.KeyChar <= 38 || e.KeyChar == 8 || e.KeyChar >= 48 && e.KeyChar <= 57)
            {
                e.Handled = false;
            }
            else if (e.KeyChar == 13)
            {
                e.Handled = true;
                btnLogin.Focus();
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
    }
}
