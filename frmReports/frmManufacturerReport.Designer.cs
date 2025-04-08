namespace PharmacyMgt.frmReports
{
    partial class frmManufacturerReport
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
            this.ManufacturercrystalReportViewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // ManufacturercrystalReportViewer
            // 
            this.ManufacturercrystalReportViewer.ActiveViewIndex = -1;
            this.ManufacturercrystalReportViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ManufacturercrystalReportViewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.ManufacturercrystalReportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ManufacturercrystalReportViewer.Location = new System.Drawing.Point(0, 0);
            this.ManufacturercrystalReportViewer.Name = "ManufacturercrystalReportViewer";
            this.ManufacturercrystalReportViewer.Size = new System.Drawing.Size(654, 461);
            this.ManufacturercrystalReportViewer.TabIndex = 0;
            // 
            // frmManufacturerReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(654, 461);
            this.Controls.Add(this.ManufacturercrystalReportViewer);
            this.Name = "frmManufacturerReport";
            this.Text = "frmManufacturerReport";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer ManufacturercrystalReportViewer;
    }
}