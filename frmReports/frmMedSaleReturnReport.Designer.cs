namespace PharmacyMgt.frmReports
{
    partial class frmMedSaleReturnReport
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
            this.MedSaleReturncrystalReportViewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // MedSaleReturncrystalReportViewer
            // 
            this.MedSaleReturncrystalReportViewer.ActiveViewIndex = -1;
            this.MedSaleReturncrystalReportViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MedSaleReturncrystalReportViewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.MedSaleReturncrystalReportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MedSaleReturncrystalReportViewer.Location = new System.Drawing.Point(0, 0);
            this.MedSaleReturncrystalReportViewer.Name = "MedSaleReturncrystalReportViewer";
            this.MedSaleReturncrystalReportViewer.Size = new System.Drawing.Size(524, 454);
            this.MedSaleReturncrystalReportViewer.TabIndex = 0;
            // 
            // frmMedSaleReturnReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(524, 454);
            this.Controls.Add(this.MedSaleReturncrystalReportViewer);
            this.Name = "frmMedSaleReturnReport";
            this.Text = "frmMedSaleReturnReport";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer MedSaleReturncrystalReportViewer;
    }
}