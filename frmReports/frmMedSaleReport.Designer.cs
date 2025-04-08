namespace PharmacyMgt.frmReports
{
    partial class frmMedSaleReport
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
            this.MedSalecrystalReportViewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // MedSalecrystalReportViewer
            // 
            this.MedSalecrystalReportViewer.ActiveViewIndex = -1;
            this.MedSalecrystalReportViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MedSalecrystalReportViewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.MedSalecrystalReportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MedSalecrystalReportViewer.Location = new System.Drawing.Point(0, 0);
            this.MedSalecrystalReportViewer.Name = "MedSalecrystalReportViewer";
            this.MedSalecrystalReportViewer.Size = new System.Drawing.Size(654, 443);
            this.MedSalecrystalReportViewer.TabIndex = 0;
            // 
            // frmMedSaleReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(654, 443);
            this.Controls.Add(this.MedSalecrystalReportViewer);
            this.Name = "frmMedSaleReport";
            this.Text = "frmMedSaleReport";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer MedSalecrystalReportViewer;
    }
}