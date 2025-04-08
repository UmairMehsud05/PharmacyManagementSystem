using PharmacyMgt.BL;
using PharmacyMgt.BL.custom;
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
    public partial class frmHome : Form
    {
       
        public frmHome()
        {
            InitializeComponent();
            Category();
            Unit();
            Manufacturer();
            Distributor();
            SubCategory();
            Medicine();
            Customer();
            Purchase();
            Stock();
            PurchaseReturn();
            Sale();
            SaleReturn();
        }

        void Category()
        {
            DataTable dt = BL_Category.AllCat(1);
            lblTotalCategory.Text = dt.Rows.Count.ToString();
        }

        void Unit()
        {
            DataTable dt = BL_Unit.AllUnit(1);
            lblTotalUnit.Text = dt.Rows.Count.ToString();
        }

        void Manufacturer()
        {
            DataTable dt = BL_Manufacturer.AllManufacturer(1);
            lblTotalManufacturer.Text = dt.Rows.Count.ToString();
        }

        void Distributor()
        {
            DataTable dt = BL_Distributor.AllDistributor(1);
            lblTotalDistributor.Text = dt.Rows.Count.ToString();
        }

        void SubCategory()
        {
            lblTotalSubCategory.Text = BL_SubCategory.AllSubCategory(1).Rows.Count.ToString();
        }

        void Medicine()
        {
            DataTable dt = BL_Medicine.AllMedicine(1);
            lblTotalMedicine.Text = dt.Rows.Count.ToString();
        }

        void Customer()
        {
            DataTable dt = BL_Customer.AllCustomer(1);
            lblTotalCustomer.Text = dt.Rows.Count.ToString();
        }

        void Purchase()
        {
            DataTable dt= BL_MedPurchase.AllPurchase(1);
            lblTotalPurchase.Text = dt.Rows.Count.ToString();
        }

        void Stock()
        {
            DataTable dt = BL_Stock.SelectStock(1);
            lblTotalStock.Text = dt.Rows.Count.ToString();
        }

        void PurchaseReturn()
        {
            DataTable dt = BL_ReturnPurchase.showreturnPur();
            lblPurchaseReturn.Text = dt.Rows.Count.ToString();
        }

        void Sale()
        {
            DataTable dt = BL_MedSale.AllSale(1);
            lblSale.Text = dt.Rows.Count.ToString();
        }

        void SaleReturn()
        {
            DataTable dt = BL_SaleReturn.select();
            lblSaleReturn.Text = dt.Rows.Count.ToString();
        }
    }
}
