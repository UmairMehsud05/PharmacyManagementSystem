namespace PharmacyMgt
{
    partial class frmCustomerReport
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
            this.CustomercrystalReportViewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // CustomercrystalReportViewer
            // 
            this.CustomercrystalReportViewer.ActiveViewIndex = -1;
            this.CustomercrystalReportViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CustomercrystalReportViewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.CustomercrystalReportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CustomercrystalReportViewer.Location = new System.Drawing.Point(0, 0);
            this.CustomercrystalReportViewer.Name = "CustomercrystalReportViewer";
            this.CustomercrystalReportViewer.Size = new System.Drawing.Size(652, 463);
            this.CustomercrystalReportViewer.TabIndex = 0;
            // 
            // frmCustomerReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(652, 463);
            this.Controls.Add(this.CustomercrystalReportViewer);
            this.Name = "frmCustomerReport";
            this.Text = "frmCustomerReport";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer CustomercrystalReportViewer;
    }
}