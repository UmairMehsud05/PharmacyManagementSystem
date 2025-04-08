namespace PharmacyMgt.frmReports
{
    partial class frmMedPurchaseReport
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
            this.MedPurchasecrystalReportViewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // MedPurchasecrystalReportViewer
            // 
            this.MedPurchasecrystalReportViewer.ActiveViewIndex = -1;
            this.MedPurchasecrystalReportViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MedPurchasecrystalReportViewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.MedPurchasecrystalReportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MedPurchasecrystalReportViewer.Location = new System.Drawing.Point(0, 0);
            this.MedPurchasecrystalReportViewer.Name = "MedPurchasecrystalReportViewer";
            this.MedPurchasecrystalReportViewer.Size = new System.Drawing.Size(473, 420);
            this.MedPurchasecrystalReportViewer.TabIndex = 0;
            // 
            // frmMedPurchaseReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(473, 420);
            this.Controls.Add(this.MedPurchasecrystalReportViewer);
            this.Name = "frmMedPurchaseReport";
            this.Text = "frmMedPurchaseReport";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer MedPurchasecrystalReportViewer;
    }
}