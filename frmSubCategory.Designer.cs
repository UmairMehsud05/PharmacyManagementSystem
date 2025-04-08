namespace PharmacyMgt
{
    partial class frmSubCategory
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
            this.ddlStatus = new MetroFramework.Controls.MetroComboBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.DGV = new System.Windows.Forms.DataGridView();
            this.Edit = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSubCatName = new MetroFramework.Controls.MetroTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ddlCategory = new MetroFramework.Controls.MetroComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnInActive = new System.Windows.Forms.Button();
            this.btnActive = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).BeginInit();
            this.SuspendLayout();
            // 
            // ddlStatus
            // 
            this.ddlStatus.FormattingEnabled = true;
            this.ddlStatus.ItemHeight = 23;
            this.ddlStatus.Items.AddRange(new object[] {
            "In-Active",
            "Active"});
            this.ddlStatus.Location = new System.Drawing.Point(614, 236);
            this.ddlStatus.Name = "ddlStatus";
            this.ddlStatus.Size = new System.Drawing.Size(251, 29);
            this.ddlStatus.TabIndex = 2;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Crimson;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(753, 284);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(112, 49);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // DGV
            // 
            this.DGV.AllowUserToAddRows = false;
            this.DGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV.BackgroundColor = System.Drawing.Color.White;
            this.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Edit});
            this.DGV.Location = new System.Drawing.Point(31, 80);
            this.DGV.Name = "DGV";
            this.DGV.Size = new System.Drawing.Size(563, 326);
            this.DGV.TabIndex = 33;
            this.DGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVdata_CellClick);
            // 
            // Edit
            // 
            this.Edit.HeaderText = "Edit";
            this.Edit.Name = "Edit";
            this.Edit.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Edit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Teal;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(614, 284);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(112, 49);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(610, 143);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 21);
            this.label7.TabIndex = 32;
            this.label7.Text = "Sub Category";
            // 
            // txtSubCatName
            // 
            this.txtSubCatName.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtSubCatName.Location = new System.Drawing.Point(613, 167);
            this.txtSubCatName.Name = "txtSubCatName";
            this.txtSubCatName.Size = new System.Drawing.Size(252, 35);
            this.txtSubCatName.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(610, 211);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 21);
            this.label5.TabIndex = 31;
            this.label5.Text = "Status";
            // 
            // ddlCategory
            // 
            this.ddlCategory.FormattingEnabled = true;
            this.ddlCategory.ItemHeight = 23;
            this.ddlCategory.Location = new System.Drawing.Point(614, 105);
            this.ddlCategory.Name = "ddlCategory";
            this.ddlCategory.Size = new System.Drawing.Size(251, 29);
            this.ddlCategory.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(610, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 21);
            this.label1.TabIndex = 35;
            this.label1.Text = "Category";
            // 
            // btnInActive
            // 
            this.btnInActive.BackColor = System.Drawing.Color.Teal;
            this.btnInActive.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInActive.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInActive.ForeColor = System.Drawing.Color.White;
            this.btnInActive.Location = new System.Drawing.Point(173, 28);
            this.btnInActive.Name = "btnInActive";
            this.btnInActive.Size = new System.Drawing.Size(113, 46);
            this.btnInActive.TabIndex = 37;
            this.btnInActive.Text = "In-Active";
            this.btnInActive.UseVisualStyleBackColor = false;
            this.btnInActive.Click += new System.EventHandler(this.btnInActive_Click);
            // 
            // btnActive
            // 
            this.btnActive.BackColor = System.Drawing.Color.Teal;
            this.btnActive.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActive.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActive.ForeColor = System.Drawing.Color.White;
            this.btnActive.Location = new System.Drawing.Point(43, 28);
            this.btnActive.Name = "btnActive";
            this.btnActive.Size = new System.Drawing.Size(113, 46);
            this.btnActive.TabIndex = 36;
            this.btnActive.Text = "Active";
            this.btnActive.UseVisualStyleBackColor = false;
            this.btnActive.Click += new System.EventHandler(this.btnActive_Click);
            // 
            // frmSubCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(897, 487);
            this.Controls.Add(this.btnInActive);
            this.Controls.Add(this.btnActive);
            this.Controls.Add(this.ddlCategory);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ddlStatus);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.DGV);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtSubCatName);
            this.Controls.Add(this.label5);
            this.Name = "frmSubCategory";
            this.Text = "frmSubCategory";
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroComboBox ddlStatus;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.DataGridView DGV;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label7;
        private MetroFramework.Controls.MetroTextBox txtSubCatName;
        private System.Windows.Forms.Label label5;
        private MetroFramework.Controls.MetroComboBox ddlCategory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewImageColumn Edit;
        private System.Windows.Forms.Button btnInActive;
        private System.Windows.Forms.Button btnActive;
    }
}