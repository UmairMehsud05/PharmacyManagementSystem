using CrystalDecisions.CrystalReports.Engine;
using PharmacyMgt.BL;
using PharmacyMgt.BL.custom;
using PharmacyMgt.DL;
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
    public partial class frmPurchaseDetail : Form
    {
        public static string Invoice;
        public frmPurchaseDetail()
        {
            InitializeComponent();
        }

        public void Purchase(string Invoice)
        {
            DataTable dt = BL_MedPurchase.PurDetails(Invoice);
            ReportDocument rpt = new ReportDocument();
            rpt.Load(@"C: \Users\Rizwan computers\Desktop\PharmacyMgt\PharmacyMgt\Reports\rptMedPurchase.rpt");
        
            rpt.SetDataSource(dt);
            crystalReportViewer1.ReportSource = rpt;
            
            //DataTable dt = BL_MedPurchase.PurDetails(Invoice);
            //Label[] TotalMedicine = new Label[dt.Rows.Count];
            //for (int i = 0; i < dt.Rows.Count; i++)
            //{
            //    TotalMedicine[i] = new Label();
            //    TotalMedicine[i].Text = "MEDICINE " + (i + 1) + "\n";
            //    TotalMedicine[i].Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic)
            //    | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            //    flowLayoutPanel1.Controls.Add(TotalMedicine[i]);
            //    TotalMedicine[i] = new Label();
            //    TotalMedicine[i].Text = "\n\n";
            //    flowLayoutPanel2.Controls.Add(TotalMedicine[i]);

            //    Label[] lbl = new Label[11];

            //    lbl[0] = new Label();
            //    lbl[1] = new Label();
            //    lbl[2] = new Label();
            //    lbl[3] = new Label();
            //    lbl[4] = new Label();
            //    lbl[5] = new Label();
            //    lbl[6] = new Label();
            //    lbl[7] = new Label();
            //    lbl[8] = new Label();
            //    lbl[9] = new Label();
            //    lbl[10] = new Label();

            //    //lbl[0].Text = "Purchase ID";
            //    //flowLayoutPanel1.Controls.Add(lbl[0]);
            //    lbl[0].Text = "Invoice No";
            //    flowLayoutPanel1.Controls.Add(lbl[0]);
            //    lbl[1].Text = "Med Name";
            //    flowLayoutPanel1.Controls.Add(lbl[1]);
            //    lbl[2].Text = "Company";
            //    flowLayoutPanel1.Controls.Add(lbl[2]);
            //    lbl[3].Text = "Category";
            //    flowLayoutPanel1.Controls.Add(lbl[3]);
            //    lbl[4].Text = "Sub Cat";
            //    flowLayoutPanel1.Controls.Add(lbl[4]);
            //    lbl[5].Text = "Total Qty";
            //    flowLayoutPanel1.Controls.Add(lbl[5]);
            //    lbl[6].Text = "Pur Price";
            //    flowLayoutPanel1.Controls.Add(lbl[6]);
            //    lbl[7].Text = "Discount";
            //    flowLayoutPanel1.Controls.Add(lbl[7]);
            //    lbl[8].Text = "Bonus";
            //    flowLayoutPanel1.Controls.Add(lbl[8]);
            //    lbl[9].Text = "Pur Date";
            //    flowLayoutPanel1.Controls.Add(lbl[9]);
            //    lbl[10].Text = "Status";
            //    flowLayoutPanel1.Controls.Add(lbl[10]);


            //    for (int j = 0; j < 11; j++)
            //    {
            //        Label[] lblData = new Label[11];


            //        lblData[i] = new Label();
            //        lblData[i].Text = dt.Rows[i][j].ToString();

            //        flowLayoutPanel2.Controls.Add(lblData[i]);
            //    }

            //}
        }
    }
}
