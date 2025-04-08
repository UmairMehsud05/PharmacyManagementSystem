using CrystalDecisions.CrystalReports.Engine;
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

namespace PharmacyMgt.frmReports
{
    public partial class frmCateReport : Form
    {
        public frmCateReport()
        {
            InitializeComponent();
            LoadCategoryReport();

        }
        

        private void LoadCategoryReport()
        {
            try
            {
                // Get the data
                DataTable dt = BL_Category.AllCategory();

                if (dt == null || dt.Rows.Count == 0)
                {
                    MessageBox.Show("No data found for category report.");
                    return;
                }

                // Create report document
                ReportDocument rd = new ReportDocument();

                // Load the report file (make sure the path is correct)
                string reportPath = @"C:\Users\Rizwan computers\Documents\Visual Studio 2015\Projects\PharmacyMgt\PharmacyMgt\Reports\rptCategory.rpt";
                if (!System.IO.File.Exists(reportPath))
                {
                    MessageBox.Show("Report file not found at: " + reportPath);
                    return;
                }

                rd.Load(reportPath);
                rd.SetDataSource(dt);

                // Assign to viewer
                CatecrystalReportViewer.ReportSource = rd;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading the report:\n" + ex.Message + "\n\nDetails:\n" + ex.ToString());
            }
        }
    }
}
