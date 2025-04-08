namespace PharmacyMgt.frmReports
{
    partial class frmMedicineReport
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
            this.MedicinecrystalReportViewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // MedicinecrystalReportViewer
            // 
            this.MedicinecrystalReportViewer.ActiveViewIndex = -1;
            this.MedicinecrystalReportViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MedicinecrystalReportViewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.MedicinecrystalReportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MedicinecrystalReportViewer.Location = new System.Drawing.Point(0, 0);
            this.MedicinecrystalReportViewer.Name = "MedicinecrystalReportViewer";
            this.MedicinecrystalReportViewer.Size = new System.Drawing.Size(576, 424);
            this.MedicinecrystalReportViewer.TabIndex = 0;
            // 
            // frmMedicineReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(576, 424);
            this.Controls.Add(this.MedicinecrystalReportViewer);
            this.Name = "frmMedicineReport";
            this.Text = "frmMedicineReport";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer MedicinecrystalReportViewer;
    }
}