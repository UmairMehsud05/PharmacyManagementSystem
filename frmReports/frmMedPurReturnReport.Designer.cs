namespace PharmacyMgt.frmReports
{
    partial class frmMedPurReturnReport
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
            this.MedPurReturncrystalReportViewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // MedPurReturncrystalReportViewer
            // 
            this.MedPurReturncrystalReportViewer.ActiveViewIndex = -1;
            this.MedPurReturncrystalReportViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MedPurReturncrystalReportViewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.MedPurReturncrystalReportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MedPurReturncrystalReportViewer.Location = new System.Drawing.Point(0, 0);
            this.MedPurReturncrystalReportViewer.Name = "MedPurReturncrystalReportViewer";
            this.MedPurReturncrystalReportViewer.Size = new System.Drawing.Size(559, 474);
            this.MedPurReturncrystalReportViewer.TabIndex = 0;
            // 
            // frmMedPurReturnReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(559, 474);
            this.Controls.Add(this.MedPurReturncrystalReportViewer);
            this.Name = "frmMedPurReturnReport";
            this.Text = "frmMedPurReturnReport";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer MedPurReturncrystalReportViewer;
    }
}