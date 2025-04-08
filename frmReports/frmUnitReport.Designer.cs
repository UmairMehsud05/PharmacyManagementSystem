namespace PharmacyMgt.frmReports
{
    partial class frmUnitReport
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
            this.UnitcrystalReportViewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // UnitcrystalReportViewer
            // 
            this.UnitcrystalReportViewer.ActiveViewIndex = -1;
            this.UnitcrystalReportViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UnitcrystalReportViewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.UnitcrystalReportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UnitcrystalReportViewer.Location = new System.Drawing.Point(0, 0);
            this.UnitcrystalReportViewer.Name = "UnitcrystalReportViewer";
            this.UnitcrystalReportViewer.Size = new System.Drawing.Size(527, 415);
            this.UnitcrystalReportViewer.TabIndex = 0;
            // 
            // frmUnitReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(527, 415);
            this.Controls.Add(this.UnitcrystalReportViewer);
            this.Name = "frmUnitReport";
            this.Text = "frmUnitReport";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer UnitcrystalReportViewer;
    }
}