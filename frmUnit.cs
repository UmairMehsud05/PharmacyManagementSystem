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
    public partial class frmUnit : Form
    {
        int status;
        int ID;
        public frmUnit()
        {
            InitializeComponent();
            Gridview(1);
        }

        void Gridview(int status)
        {
            DGV.DataSource = BL_Unit.AllUnit(status);
            DGV.Columns["UnitId"].Visible = false;
            DGV.Columns["UnitStatus"].Visible = false;
        }
        private void DGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                BL_Unit o = new BL_Unit(Convert.ToInt32(DGV.Rows[e.RowIndex].Cells["UnitID"].Value));
                ID = o.UnitID;
                txtUnit.Text = o.UnitName;
                txtStatus.SelectedIndex = o.UnitStatus;
                btnAdd.Text = "Update";
            }
            else if (e.ColumnIndex == 1)
            {
                if (MessageBox.Show("Are you sure want to delete this data?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    BL_Unit o = new BL_Unit();
                    o.UnitID = Convert.ToInt32(DGV.Rows[e.RowIndex].Cells["UnitID"].Value);
                    o.Delete();
                    MessageBox.Show(MyMessage.msg);
                    Gridview(1);
                }
            }

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtUnit.Text == string.Empty)
            {
                MessageBox.Show("Please enter your unit name");
                txtUnit.Focus();
            }
            else if (txtStatus.SelectedIndex < 0)
            {
                MessageBox.Show("Please select your unit status");
                txtStatus.Focus();
            }
            else
            {
                BL_Unit o = new BL_Unit();
                o.IsNew = true;
                if (ID > 0)
                {
                    o.IsNew = false;
                    o.UnitID = ID;
                    btnAdd.Text = "Add";
                }
                o.UnitName = txtUnit.Text;
                o.UnitStatus = txtStatus.SelectedIndex;
                o.AddOrUpdate();
                MessageBox.Show(MyMessage.msg);
                clear();
                Gridview(1);
                ID = 0;
            }

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clear();
            btnAdd.Text = "Add";
        }
        void clear()
        {
            txtUnit.Text = string.Empty;
            txtStatus.SelectedIndex = -1;
        }

        private void txtUnit_KeyPress(object sender, KeyPressEventArgs e)
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

        private void btnActive_Click(object sender, EventArgs e)
        {
            BL_Unit.AllUnit(1);
            Gridview(1);
        }

        private void btnInActive_Click(object sender, EventArgs e)
        {
            BL_Unit.AllUnit(0);
            Gridview(0);
        }
    }
}
