namespace PharmacyMgt.frmReports
{
    partial class frmCateReport
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
            this.CatecrystalReportViewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // CatecrystalReportViewer
            // 
            this.CatecrystalReportViewer.ActiveViewIndex = -1;
            this.CatecrystalReportViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CatecrystalReportViewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.CatecrystalReportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CatecrystalReportViewer.Location = new System.Drawing.Point(0, 0);
            this.CatecrystalReportViewer.Name = "CatecrystalReportViewer";
            this.CatecrystalReportViewer.Size = new System.Drawing.Size(727, 451);
            this.CatecrystalReportViewer.TabIndex = 0;
            // 
            // frmCateReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(727, 451);
            this.Controls.Add(this.CatecrystalReportViewer);
            this.Name = "frmCateReport";
            this.Text = "frmCateReport";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer CatecrystalReportViewer;
    }
}