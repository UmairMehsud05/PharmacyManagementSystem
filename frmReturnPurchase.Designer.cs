namespace PharmacyMgt
{
    partial class frmReturnPurchase
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
            this.txtMedicineName = new System.Windows.Forms.ComboBox();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtInvoiceNo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.btnCheck = new System.Windows.Forms.Button();
            this.txtPPrice = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // txtMedicineName
            // 
            this.txtMedicineName.BackColor = System.Drawing.Color.White;
            this.txtMedicineName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtMedicineName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtMedicineName.FormattingEnabled = true;
            this.txtMedicineName.Location = new System.Drawing.Point(56, 140);
            this.txtMedicineName.Name = "txtMedicineName";
            this.txtMedicineName.Size = new System.Drawing.Size(198, 28);
            this.txtMedicineName.TabIndex = 160;
            this.txtMedicineName.SelectionChangeCommitted += new System.EventHandler(this.txtMedicineName_SelectionChangeCommitted);
            // 
            // txtQty
            // 
            this.txtQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtQty.Location = new System.Drawing.Point(56, 210);
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(199, 26);
            this.txtQty.TabIndex = 166;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(52, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 21);
            this.label5.TabIndex = 167;
            this.label5.Text = "Invoice No";
            // 
            // txtInvoiceNo
            // 
            this.txtInvoiceNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtInvoiceNo.Location = new System.Drawing.Point(56, 73);
            this.txtInvoiceNo.Name = "txtInvoiceNo";
            this.txtInvoiceNo.Size = new System.Drawing.Size(199, 26);
            this.txtInvoiceNo.TabIndex = 165;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(52, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 21);
            this.label2.TabIndex = 168;
            this.label2.Text = "QTY";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(52, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 21);
            this.label1.TabIndex = 169;
            this.label1.Text = "Medicine";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Teal;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(55, 321);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(199, 37);
            this.btnAdd.TabIndex = 172;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv.BackgroundColor = System.Drawing.Color.White;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(337, 48);
            this.dgv.Name = "dgv";
            this.dgv.Size = new System.Drawing.Size(591, 380);
            this.dgv.TabIndex = 173;
            // 
            // btnCheck
            // 
            this.btnCheck.BackColor = System.Drawing.Color.Teal;
            this.btnCheck.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheck.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheck.ForeColor = System.Drawing.Color.White;
            this.btnCheck.Location = new System.Drawing.Point(261, 67);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(70, 37);
            this.btnCheck.TabIndex = 174;
            this.btnCheck.Text = "Check";
            this.btnCheck.UseVisualStyleBackColor = false;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // txtPPrice
            // 
            this.txtPPrice.Enabled = false;
            this.txtPPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtPPrice.Location = new System.Drawing.Point(55, 275);
            this.txtPPrice.Name = "txtPPrice";
            this.txtPPrice.Size = new System.Drawing.Size(199, 26);
            this.txtPPrice.TabIndex = 175;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(51, 250);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 21);
            this.label3.TabIndex = 176;
            this.label3.Text = "Purchase Price";
            // 
            // frmReturnPurchase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(940, 484);
            this.Controls.Add(this.txtPPrice);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtQty);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtInvoiceNo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMedicineName);
            this.Name = "frmReturnPurchase";
            this.Text = "frmReturnPurchase";
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox txtMedicineName;
        private System.Windows.Forms.TextBox txtQty;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtInvoiceNo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.TextBox txtPPrice;
        private System.Windows.Forms.Label label3;
    }
}