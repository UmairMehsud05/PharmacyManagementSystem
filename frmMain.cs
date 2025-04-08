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
    public partial class frmMain : MetroFramework.Forms.MetroForm
    {
        Form curForm;

        public frmMain()
        {
            InitializeComponent();
            lblAdminName.Text ="WELCOME '"+ LogInForm.AdminName+"'";
            loadform(btnHome, new frmHome());
            timer1.Start();
        }
       
        void loadform(object sender, Form frm)
        {
            if (curForm!=null)
            {
                curForm.Close();
            }
            curForm = frm;
            curForm.TopLevel = false;
            curForm.BackColor = Color.White;
            curForm.Dock = DockStyle.Fill;
            curForm.FormBorderStyle = FormBorderStyle.None;
            pnlMain.Controls.Add(curForm);
            curForm.Show();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            loadform(sender,new frmHome());
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            loadform(sender, new frmProfile());
        }
        private void btnCategory_Click(object sender, EventArgs e)
        {
            loadform(sender, new frmCat());
        }

        private void btnUnit_Click(object sender, EventArgs e)
        {
            loadform(sender, new frmUnit());
        }

        bool hide = false;
        private void btnBars_Click(object sender, EventArgs e)
        {
            if(hide==true)
            {
                show();
                hide = false;
            }
            else
            {
                hidee();
                hide = true;
            }
        }

        void show()
        {
            pnlMenu.Size = new Size(161, 459);
            btnHome.Text = "Home";
            btnUser.Text = "Profile";
            btnCategory.Text = "Category";
            btnUnit.Text = "Unit";
            btnManufacturer.Text = "Manufacturer";
            btnDistributor.Text = "Distributor";
            btnSubCategory.Text = "Sub-Category";
            btnMedicine.Text = "Medicine";
            btnCustomer.Text = "Customer";
        }
        void hidee()
        {
            pnlMenu.Size = new Size(57, 459);
            btnHome.Text = "";
            btnUser.Text = "";
            btnCategory.Text = "";
            btnUnit.Text = "";
            btnManufacturer.Text = "";
            btnDistributor.Text = "";
            btnSubCategory.Text = "";
            btnMedicine.Text = "";
            btnCustomer.Text = "";
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            loadform(sender, new frmManufacturer());
        }

        private void btnDistributor_Click(object sender, EventArgs e)
        {
            loadform(sender, new frmDistributor());
        }

        private void btnSubCategory_Click(object sender, EventArgs e)
        {
            loadform(sender, new frmSubCategory());
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblDateTime.Text = DateTime.Now.ToString("dddd, dd MMMM, yyyy - hh:mm:ss tt");
        }

        private void btnMedicine_Click(object sender, EventArgs e)
        {
            loadform(sender, new frmMedicine());
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            loadform(sender, new frmCustomer());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new LogInForm().Show(); 
        }

        private void iconButton1_Click_1(object sender, EventArgs e)
        {
            loadform(sender, new frmMedPurchase());
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            loadform(sender, new frmStock());
        }

        private void btnPurchaseReturn_Click(object sender, EventArgs e)
        {
            loadform(sender, new frmReturnPurchase());
        }

        private void iconButton1_Click_2(object sender, EventArgs e)
        {
            loadform(sender, new frmMedSale());
        }

        private void iconButton2_Click_1(object sender, EventArgs e)
        {
            loadform(sender, new frmSaleReturn());
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            loadform(sender, new frmReport());
        }
    }
}
