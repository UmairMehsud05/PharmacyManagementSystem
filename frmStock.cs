using PharmacyMgt.BL;
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
    public partial class frmStock : Form
    {
        public static int medid;
        public frmStock()
        {
            InitializeComponent();
            gridview(1);
        }

        void gridview(int status)
        {
            DGV_Stock.DataSource = BL_Stock.SelectStock(status);
            DGV_Stock.Columns["Status"].Visible = false;
            DGV_Stock.Columns["StockId"].Visible = false;
            DGV_Stock.Columns["MedicineId"].Visible = false;
        }

        private void btnInStock_Click(object sender, EventArgs e)
        {
            BL_Stock.SelectStock(1);
            gridview(1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BL_Stock.SelectStock(0);
            gridview(0);
        }
    }
}
