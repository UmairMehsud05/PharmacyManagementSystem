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
    public partial class frmMedicine : Form
    {
        int MedId;
        int status;
        public frmMedicine()
        {
            InitializeComponent();
            Unit();
            Manufacturer();
            Category();
            DataGridView(1);
        }

        void Unit()
        {
            txtUnitName.DataSource = BL_Unit.AllUnit(1);
            txtUnitName.DisplayMember = "UnitName";
            txtUnitName.ValueMember = "UnitID";
            txtUnitName.SelectedIndex = -1;

            ddlSearch_Unit.DataSource = BL_Unit.AllUnit(1);
            ddlSearch_Unit.DisplayMember = "UnitName";
            ddlSearch_Unit.ValueMember = "UnitID";
            ddlSearch_Unit.SelectedIndex = -1;
        }

        void Manufacturer()
        {
            txtManufacturer.DataSource = BL_Manufacturer.AllManufacturer(1);
            txtManufacturer.DisplayMember = "CompanyName";
            txtManufacturer.ValueMember = "ManufacturerID";
            txtManufacturer.SelectedIndex = -1;

            ddlSearchManufacture.DataSource = BL_Manufacturer.AllManufacturer(1);
            ddlSearchManufacture.DisplayMember = "CompanyName";
            ddlSearchManufacture.ValueMember = "ManufacturerID";
            ddlSearchManufacture.SelectedIndex = -1;
        }

        void Category()
        {
            txtCategory.DataSource = BL_Category.AllCat(1);
            txtCategory.DisplayMember = "CatName";
            txtCategory.ValueMember = "CatID";
            txtCategory.SelectedIndex = -1;

            ddlSearchCategory.DataSource = BL_Category.AllCat(1);
            ddlSearchCategory.DisplayMember = "CatName";
            ddlSearchCategory.ValueMember = "CatID";
            ddlSearchCategory.SelectedIndex = -1;
        }


        void DataGridView(int status)
        {
            DGV.DataSource = BL_Medicine.AllMedicine(status);
            DGV.Columns["MedID"].Visible = false;
            DGV.Columns["Status"].Visible = false;
            DGV.Columns["UnitID"].Visible = false;
            DGV.Columns["CatID"].Visible = false;
            DGV.Columns["SubCatID"].Visible = false;
            DGV.Columns["ManufacturerID"].Visible = false;
        }


        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                BL_Medicine o = new BL_Medicine(Convert.ToInt32(DGV.Rows[e.RowIndex].Cells["MedID"].Value));
                MedId = o.MedID;
                txtUnitName.SelectedValue = o.UnitID;
                txtManufacturer.SelectedValue = o.ManufacturerID;
                txtCategory.SelectedValue = o.CatID;
                txtSubCategory.SelectedValue = o.SubCatID;
                txtMedicineName.Text = o.MedName;
                txtMedicineFormula.Text = o.MedFormula;
                txtDescription.Text = o.Description;
                txtMedicineStatus.SelectedIndex = o.MedStatus;
                btnAdd.Text = "Update";
                Tab.SelectedTab = tabAdd;
                tabAdd.Text = "Update Details";
            }
            else if (e.ColumnIndex == 1)
            {
                if (MessageBox.Show("Are you sure want to delete this data?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    BL_Medicine o = new BL_Medicine();
                    o.MedID = Convert.ToInt32(DGV.Rows[e.RowIndex].Cells["MedID"].Value);
                    o.Delete();
                    MessageBox.Show(MyMessage.msg);
                }
                DataGridView(1);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtMedicineName.Text == string.Empty)
            {
                MessageBox.Show("Please enter Medicine name");
                txtMedicineFormula.Focus();
            }
            else if (txtMedicineFormula.Text == string.Empty)
            {
                MessageBox.Show("Please enter MedicineFormula");
                txtDescription.Focus();
            }
            else if (txtDescription.Text == string.Empty)
            {
                MessageBox.Show("Please enter description");
                txtMedicineStatus.Focus();
            }
            else if (txtMedicineStatus.SelectedIndex == -1)
            {
                MessageBox.Show("Please select Status");
                txtMedicineName.Focus();
            }
            else
            {
                BL_Medicine o = new BL_Medicine();
                o.IsNew = true;
                if (MedId > 0)
                {
                    o.IsNew = false;
                    o.MedID = MedId;
                    btnAdd.Text = "Add";
                }
                o.UnitID = Convert.ToInt32(txtUnitName.SelectedValue);
                o.ManufacturerID = Convert.ToInt32(txtManufacturer.SelectedValue);
                o.CatID = Convert.ToInt32(txtCategory.SelectedValue);
                o.SubCatID = Convert.ToInt32(txtSubCategory.SelectedValue);
                o.MedName = txtMedicineName.Text;
                o.MedFormula = txtMedicineFormula.Text;
                o.Description = txtDescription.Text;
                o.MedStatus = txtMedicineStatus.SelectedIndex;
                o.AddOrUpdate();
                MessageBox.Show(MyMessage.msg);
                Tab.SelectedTab = tabMedicineDetail;
                tabAdd.Text = "Add Medicine";
                DataGridView(1);
                Clear();
                MedId = 0;
            }

        }

        private void txtMedicineName_KeyPress(object sender, KeyPressEventArgs e)
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

        void Clear()
        {
            txtUnitName.SelectedValue = -1;
            txtManufacturer.SelectedValue = -1;
            txtCategory.SelectedValue = -1;
            txtSubCategory.SelectedValue = -1;
            txtMedicineName.Text = string.Empty;
            txtMedicineFormula.Text = string.Empty;
            txtDescription.Text = string.Empty;
            txtMedicineStatus.SelectedIndex = -1;
        }

        private void txtCategory_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                txtSubCategory.DataSource = BL_Medicine.SubCategoryByCatId(Convert.ToInt32(txtCategory.SelectedValue));
                txtSubCategory.DisplayMember = "SubCatname";
                txtSubCategory.ValueMember = "SubCatID";
                txtSubCategory.SelectedIndex = -1;
            }
            catch
            {
            }
        }

        private void txtSearch_MedName_TextChanged(object sender, EventArgs e)
        {
            if (txtSearch_MedName.Text.Length > 0)
            {
                DGV.DataSource = BL_Medicine.SearchMedicine(txtSearch_MedName.Text);
            }
            else
            {
                DataGridView(1);
            }
        }

        private void txtSearch_MedFormula_TextChanged(object sender, EventArgs e)
        {
            if (txtSearch_MedFormula.Text.Length > 0)
            {
                DGV.DataSource = BL_Medicine.SearchMedicine(null, txtSearch_MedFormula.Text);
            }
            else
            {
                DataGridView(1);
            }
        }

        private void txtSearch_Unit_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddlSearch_Unit.SelectedIndex >= 0)
            {
                DGV.DataSource = BL_Medicine.SearchMedicine(null, null, Convert.ToInt32(ddlSearch_Unit.SelectedValue));
            }
            else
            {
                DataGridView(1);
            }
        }

        private void btnActive_Click(object sender, EventArgs e)
        {
            BL_Medicine.AllMedicine(1);
            DataGridView(1);
        }

        private void btnInActive_Click(object sender, EventArgs e)
        {
            BL_Medicine.AllMedicine(0);
            DataGridView(0);

        }

        private void ddlSearchCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddlSearchCategory.SelectedIndex >= 0)
            {
                DGV.DataSource = BL_Medicine.SearchMedicine(null, null,null, Convert.ToInt32(ddlSearchCategory.SelectedValue),null);
            }
            else
            {
                DataGridView(1);
            }
        }

        private void ddlSearchManufacture_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddlSearchManufacture.SelectedIndex >= 0)
            {
                DGV.DataSource = BL_Medicine.SearchMedicine(null, null, null, null, Convert.ToInt32(ddlSearchManufacture.SelectedValue));
            }
            else
            {
                DataGridView(1);
            }
        }
    }
}
