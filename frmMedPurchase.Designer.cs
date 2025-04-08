namespace PharmacyMgt
{
    partial class frmMedPurchase
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Tab = new MetroFramework.Controls.MetroTabControl();
            this.MedPurchase = new MetroFramework.Controls.MetroTabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.gdvList = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtBonus = new System.Windows.Forms.NumericUpDown();
            this.txtDiscount = new System.Windows.Forms.NumericUpDown();
            this.txtPurchasePrice = new System.Windows.Forms.NumericUpDown();
            this.txtQuantity = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.ddlMedical = new MetroFramework.Controls.MetroComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtInoiceNo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Purchase_Details = new MetroFramework.Controls.MetroTabPage();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnUnPaid = new System.Windows.Forms.Button();
            this.btnPaid = new System.Windows.Forms.Button();
            this.DGV = new System.Windows.Forms.DataGridView();
            this.Ispaid = new System.Windows.Forms.DataGridViewButtonColumn();
            this.View = new System.Windows.Forms.DataGridViewImageColumn();
            this.Tab.SuspendLayout();
            this.MedPurchase.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdvList)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtBonus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiscount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPurchasePrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuantity)).BeginInit();
            this.Purchase_Details.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).BeginInit();
            this.SuspendLayout();
            // 
            // Tab
            // 
            this.Tab.Controls.Add(this.MedPurchase);
            this.Tab.Controls.Add(this.Purchase_Details);
            this.Tab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Tab.Location = new System.Drawing.Point(0, 0);
            this.Tab.Name = "Tab";
            this.Tab.SelectedIndex = 0;
            this.Tab.Size = new System.Drawing.Size(819, 513);
            this.Tab.TabIndex = 140;
            // 
            // MedPurchase
            // 
            this.MedPurchase.Controls.Add(this.panel3);
            this.MedPurchase.Controls.Add(this.panel2);
            this.MedPurchase.Controls.Add(this.panel1);
            this.MedPurchase.HorizontalScrollbarBarColor = true;
            this.MedPurchase.Location = new System.Drawing.Point(4, 35);
            this.MedPurchase.Name = "MedPurchase";
            this.MedPurchase.Size = new System.Drawing.Size(811, 474);
            this.MedPurchase.TabIndex = 1;
            this.MedPurchase.Text = "MedPurchase";
            this.MedPurchase.VerticalScrollbarBarColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.gdvList);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 20);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(8, 10, 0, 0);
            this.panel3.Size = new System.Drawing.Size(563, 454);
            this.panel3.TabIndex = 144;
            // 
            // gdvList
            // 
            this.gdvList.AllowUserToAddRows = false;
            this.gdvList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gdvList.BackgroundColor = System.Drawing.Color.White;
            this.gdvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gdvList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gdvList.Location = new System.Drawing.Point(8, 10);
            this.gdvList.Name = "gdvList";
            this.gdvList.Size = new System.Drawing.Size(555, 444);
            this.gdvList.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.txtBonus);
            this.panel2.Controls.Add(this.txtDiscount);
            this.panel2.Controls.Add(this.txtPurchasePrice);
            this.panel2.Controls.Add(this.txtQuantity);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.btnConfirm);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.ddlMedical);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.btnAdd);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txtInoiceNo);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(563, 20);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(248, 454);
            this.panel2.TabIndex = 143;
            // 
            // txtBonus
            // 
            this.txtBonus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtBonus.Location = new System.Drawing.Point(16, 292);
            this.txtBonus.Name = "txtBonus";
            this.txtBonus.Size = new System.Drawing.Size(206, 26);
            this.txtBonus.TabIndex = 139;
            // 
            // txtDiscount
            // 
            this.txtDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtDiscount.Location = new System.Drawing.Point(16, 239);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Size = new System.Drawing.Size(206, 26);
            this.txtDiscount.TabIndex = 138;
            // 
            // txtPurchasePrice
            // 
            this.txtPurchasePrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtPurchasePrice.Location = new System.Drawing.Point(16, 186);
            this.txtPurchasePrice.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtPurchasePrice.Name = "txtPurchasePrice";
            this.txtPurchasePrice.Size = new System.Drawing.Size(206, 26);
            this.txtPurchasePrice.TabIndex = 137;
            this.txtPurchasePrice.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // txtQuantity
            // 
            this.txtQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtQuantity.Location = new System.Drawing.Point(16, 135);
            this.txtQuantity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(206, 26);
            this.txtQuantity.TabIndex = 136;
            this.txtQuantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(12, -3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 21);
            this.label5.TabIndex = 21;
            this.label5.Text = "Medical";
            // 
            // btnConfirm
            // 
            this.btnConfirm.BackColor = System.Drawing.Color.Crimson;
            this.btnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirm.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirm.ForeColor = System.Drawing.Color.White;
            this.btnConfirm.Location = new System.Drawing.Point(16, 370);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(206, 34);
            this.btnConfirm.TabIndex = 135;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = false;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 214);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 21);
            this.label4.TabIndex = 131;
            this.label4.Text = "Discount";
            // 
            // ddlMedical
            // 
            this.ddlMedical.FormattingEnabled = true;
            this.ddlMedical.ItemHeight = 23;
            this.ddlMedical.Items.AddRange(new object[] {
            "In-Active",
            "Active"});
            this.ddlMedical.Location = new System.Drawing.Point(16, 22);
            this.ddlMedical.Name = "ddlMedical";
            this.ddlMedical.Size = new System.Drawing.Size(206, 29);
            this.ddlMedical.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 21);
            this.label2.TabIndex = 127;
            this.label2.Text = "Quantity";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Teal;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(16, 326);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(206, 38);
            this.btnAdd.TabIndex = 134;
            this.btnAdd.Text = "Add More?";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 21);
            this.label1.TabIndex = 125;
            this.label1.Text = "InvoiceNo ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 21);
            this.label3.TabIndex = 129;
            this.label3.Text = "Purchase Price";
            // 
            // txtInoiceNo
            // 
            this.txtInoiceNo.Enabled = false;
            this.txtInoiceNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtInoiceNo.Location = new System.Drawing.Point(16, 79);
            this.txtInoiceNo.Name = "txtInoiceNo";
            this.txtInoiceNo.Size = new System.Drawing.Size(206, 26);
            this.txtInoiceNo.TabIndex = 124;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 268);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 21);
            this.label6.TabIndex = 133;
            this.label6.Text = "Bonus";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(811, 20);
            this.panel1.TabIndex = 142;
            // 
            // Purchase_Details
            // 
            this.Purchase_Details.Controls.Add(this.panel4);
            this.Purchase_Details.HorizontalScrollbarBarColor = true;
            this.Purchase_Details.Location = new System.Drawing.Point(4, 35);
            this.Purchase_Details.Name = "Purchase_Details";
            this.Purchase_Details.Size = new System.Drawing.Size(811, 474);
            this.Purchase_Details.TabIndex = 2;
            this.Purchase_Details.Text = "Purchase_Details";
            this.Purchase_Details.VerticalScrollbarBarColor = true;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnUnPaid);
            this.panel4.Controls.Add(this.btnPaid);
            this.panel4.Controls.Add(this.DGV);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Padding = new System.Windows.Forms.Padding(0, 50, 0, 0);
            this.panel4.Size = new System.Drawing.Size(811, 474);
            this.panel4.TabIndex = 2;
            // 
            // btnUnPaid
            // 
            this.btnUnPaid.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUnPaid.BackColor = System.Drawing.Color.Teal;
            this.btnUnPaid.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btnUnPaid.ForeColor = System.Drawing.Color.White;
            this.btnUnPaid.Location = new System.Drawing.Point(675, 5);
            this.btnUnPaid.Name = "btnUnPaid";
            this.btnUnPaid.Size = new System.Drawing.Size(75, 39);
            this.btnUnPaid.TabIndex = 15;
            this.btnUnPaid.Text = "UnPaid";
            this.btnUnPaid.UseVisualStyleBackColor = false;
            this.btnUnPaid.Click += new System.EventHandler(this.btnUnPaid_Click);
            // 
            // btnPaid
            // 
            this.btnPaid.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPaid.BackColor = System.Drawing.Color.Teal;
            this.btnPaid.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btnPaid.ForeColor = System.Drawing.Color.White;
            this.btnPaid.Location = new System.Drawing.Point(579, 5);
            this.btnPaid.Name = "btnPaid";
            this.btnPaid.Size = new System.Drawing.Size(75, 39);
            this.btnPaid.TabIndex = 14;
            this.btnPaid.Text = "Paid";
            this.btnPaid.UseVisualStyleBackColor = false;
            this.btnPaid.Click += new System.EventHandler(this.btnPaid_Click);
            // 
            // DGV
            // 
            this.DGV.AllowUserToAddRows = false;
            this.DGV.BackgroundColor = System.Drawing.Color.White;
            this.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Ispaid,
            this.View});
            this.DGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGV.Location = new System.Drawing.Point(0, 50);
            this.DGV.Name = "DGV";
            this.DGV.Size = new System.Drawing.Size(811, 424);
            this.DGV.TabIndex = 0;
            this.DGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_CellClick);
            // 
            // Ispaid
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            this.Ispaid.DefaultCellStyle = dataGridViewCellStyle1;
            this.Ispaid.HeaderText = "Action";
            this.Ispaid.Name = "Ispaid";
            this.Ispaid.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Ispaid.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Ispaid.Text = "Paid?";
            this.Ispaid.ToolTipText = "Click to paid your purchase invoice.";
            this.Ispaid.UseColumnTextForButtonValue = true;
            // 
            // View
            // 
            this.View.HeaderText = "View";
            this.View.Name = "View";
            // 
            // frmMedPurchase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(819, 513);
            this.Controls.Add(this.Tab);
            this.Name = "frmMedPurchase";
            this.Text = "frmMedPurchase";
            this.Tab.ResumeLayout(false);
            this.MedPurchase.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gdvList)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtBonus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiscount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPurchasePrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuantity)).EndInit();
            this.Purchase_Details.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroTabControl Tab;
        private MetroFramework.Controls.MetroTabPage MedPurchase;
        private MetroFramework.Controls.MetroTabPage Purchase_Details;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.NumericUpDown txtBonus;
        private System.Windows.Forms.NumericUpDown txtDiscount;
        private System.Windows.Forms.NumericUpDown txtPurchasePrice;
        private System.Windows.Forms.NumericUpDown txtQuantity;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Label label4;
        private MetroFramework.Controls.MetroComboBox ddlMedical;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtInoiceNo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView gdvList;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView DGV;
        private System.Windows.Forms.Button btnPaid;
        private System.Windows.Forms.Button btnUnPaid;
        private System.Windows.Forms.DataGridViewButtonColumn Ispaid;
        private System.Windows.Forms.DataGridViewImageColumn View;
    }
}