namespace PharmacyMgt
{
    partial class frmStock
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.OutOfStock = new System.Windows.Forms.Button();
            this.btnInStock = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.DGV_Stock = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Stock)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.OutOfStock);
            this.panel1.Controls.Add(this.btnInStock);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(625, 52);
            this.panel1.TabIndex = 0;
            // 
            // OutOfStock
            // 
            this.OutOfStock.BackColor = System.Drawing.Color.Teal;
            this.OutOfStock.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.OutOfStock.ForeColor = System.Drawing.Color.White;
            this.OutOfStock.Location = new System.Drawing.Point(319, 6);
            this.OutOfStock.Name = "OutOfStock";
            this.OutOfStock.Size = new System.Drawing.Size(120, 41);
            this.OutOfStock.TabIndex = 1;
            this.OutOfStock.Text = "Out-Of-Stock";
            this.OutOfStock.UseVisualStyleBackColor = false;
            this.OutOfStock.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnInStock
            // 
            this.btnInStock.BackColor = System.Drawing.Color.Teal;
            this.btnInStock.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btnInStock.ForeColor = System.Drawing.Color.White;
            this.btnInStock.Location = new System.Drawing.Point(146, 6);
            this.btnInStock.Name = "btnInStock";
            this.btnInStock.Size = new System.Drawing.Size(120, 40);
            this.btnInStock.TabIndex = 0;
            this.btnInStock.Text = "IN-Stock";
            this.btnInStock.UseVisualStyleBackColor = false;
            this.btnInStock.Click += new System.EventHandler(this.btnInStock_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.DGV_Stock);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 52);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(625, 385);
            this.panel2.TabIndex = 1;
            // 
            // DGV_Stock
            // 
            this.DGV_Stock.AllowUserToAddRows = false;
            this.DGV_Stock.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_Stock.BackgroundColor = System.Drawing.Color.White;
            this.DGV_Stock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Stock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGV_Stock.Location = new System.Drawing.Point(0, 0);
            this.DGV_Stock.Name = "DGV_Stock";
            this.DGV_Stock.Size = new System.Drawing.Size(625, 385);
            this.DGV_Stock.TabIndex = 0;
            // 
            // frmStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(625, 437);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmStock";
            this.Text = "frmStock";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Stock)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button OutOfStock;
        private System.Windows.Forms.Button btnInStock;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView DGV_Stock;
    }
}