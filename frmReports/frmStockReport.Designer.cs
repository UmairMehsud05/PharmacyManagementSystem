namespace PharmacyMgt.frmReports
{
    partial class frmStockReport
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
            this.StockcrystalReportViewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // StockcrystalReportViewer
            // 
            this.StockcrystalReportViewer.ActiveViewIndex = -1;
            this.StockcrystalReportViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.StockcrystalReportViewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.StockcrystalReportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StockcrystalReportViewer.Location = new System.Drawing.Point(0, 0);
            this.StockcrystalReportViewer.Name = "StockcrystalReportViewer";
            this.StockcrystalReportViewer.Size = new System.Drawing.Size(510, 428);
            this.StockcrystalReportViewer.TabIndex = 0;
            // 
            // frmStockReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(510, 428);
            this.Controls.Add(this.StockcrystalReportViewer);
            this.Name = "frmStockReport";
            this.Text = "frmStockReport";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer StockcrystalReportViewer;
    }
}