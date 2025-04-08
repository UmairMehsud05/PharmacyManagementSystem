namespace PharmacyMgt.frmReports
{
    partial class frmSubCategoryReport
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SubCatcrystalReportViewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // SubCatcrystalReportViewer
            // 
            this.SubCatcrystalReportViewer.ActiveViewIndex = -1;
            this.SubCatcrystalReportViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SubCatcrystalReportViewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.SubCatcrystalReportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SubCatcrystalReportViewer.Location = new System.Drawing.Point(0, 0);
            this.SubCatcrystalReportViewer.Name = "SubCatcrystalReportViewer";
            this.SubCatcrystalReportViewer.Size = new System.Drawing.Size(543, 418);
            this.SubCatcrystalReportViewer.TabIndex = 0;
            // 
            // frmSubCategoryReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(543, 418);
            this.Controls.Add(this.SubCatcrystalReportViewer);
            this.Name = "frmSubCategoryReport";
            this.Text = "frmSubCategoryReport";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer SubCatcrystalReportViewer;
    }
}