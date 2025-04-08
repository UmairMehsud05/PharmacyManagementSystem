namespace PharmacyMgt
{
    partial class frmCat
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
            this.label7 = new System.Windows.Forms.Label();
            this.txtCatName = new MetroFramework.Controls.MetroTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.DGVdata = new System.Windows.Forms.DataGridView();
            this.btnClear = new System.Windows.Forms.Button();
            this.ddlStatus = new MetroFramework.Controls.MetroComboBox();
            this.btnInActive = new System.Windows.Forms.Button();
            this.btnActive = new System.Windows.Forms.Button();
            this.Edit = new System.Windows.Forms.DataGridViewImageColumn();
            this.Delete = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DGVdata)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(616, 79);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 21);
            this.label7.TabIndex = 21;
            this.label7.Text = "Category";
            // 
            // txtCatName
            // 
            this.txtCatName.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtCatName.Location = new System.Drawing.Point(619, 103);
            this.txtCatName.Name = "txtCatName";
            this.txtCatName.Size = new System.Drawing.Size(252, 26);
            this.txtCatName.TabIndex = 0;
            this.txtCatName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCatName_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(616, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 21);
            this.label5.TabIndex = 19;
            this.label5.Text = "Status";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Teal;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(620, 220);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(112, 49);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // DGVdata
            // 
            this.DGVdata.AllowUserToAddRows = false;
            this.DGVdata.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVdata.BackgroundColor = System.Drawing.Color.White;
            this.DGVdata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVdata.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Edit,
            this.Delete});
            this.DGVdata.Location = new System.Drawing.Point(37, 79);
            this.DGVdata.Name = "DGVdata";
            this.DGVdata.Size = new System.Drawing.Size(563, 326);
            this.DGVdata.TabIndex = 26;
            this.DGVdata.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVdata_CellClick);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Crimson;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(759, 220);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(112, 49);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // ddlStatus
            // 
            this.ddlStatus.FormattingEnabled = true;
            this.ddlStatus.ItemHeight = 23;
            this.ddlStatus.Items.AddRange(new object[] {
            "In-Active",
            "Active"});
            this.ddlStatus.Location = new System.Drawing.Point(620, 172);
            this.ddlStatus.Name = "ddlStatus";
            this.ddlStatus.Size = new System.Drawing.Size(251, 29);
            this.ddlStatus.TabIndex = 1;
            // 
            // btnInActive
            // 
            this.btnInActive.BackColor = System.Drawing.Color.Teal;
            this.btnInActive.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInActive.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInActive.ForeColor = System.Drawing.Color.White;
            this.btnInActive.Location = new System.Drawing.Point(173, 21);
            this.btnInActive.Name = "btnInActive";
            this.btnInActive.Size = new System.Drawing.Size(113, 46);
            this.btnInActive.TabIndex = 28;
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
            this.btnActive.Location = new System.Drawing.Point(37, 21);
            this.btnActive.Name = "btnActive";
            this.btnActive.Size = new System.Drawing.Size(113, 46);
            this.btnActive.TabIndex = 27;
            this.btnActive.Text = "Active";
            this.btnActive.UseVisualStyleBackColor = false;
            this.btnActive.Click += new System.EventHandler(this.btnActive_Click);
            // 
            // Edit
            // 
            this.Edit.HeaderText = "Edit";
            this.Edit.Name = "Edit";
            this.Edit.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Edit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Delete
            // 
            this.Delete.HeaderText = "Delete";
            this.Delete.Name = "Delete";
            this.Delete.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Delete.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // frmCat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(908, 487);
            this.Controls.Add(this.btnInActive);
            this.Controls.Add(this.btnActive);
            this.Controls.Add(this.ddlStatus);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.DGVdata);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtCatName);
            this.Controls.Add(this.label5);
            this.Name = "frmCat";
            this.Text = "Category";
            ((System.ComponentModel.ISupportInitialize)(this.DGVdata)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label7;
        private MetroFramework.Controls.MetroTextBox txtCatName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView DGVdata;
        private System.Windows.Forms.Button btnClear;
        private MetroFramework.Controls.MetroComboBox ddlStatus;
        private System.Windows.Forms.Button btnInActive;
        private System.Windows.Forms.Button btnActive;
        private System.Windows.Forms.DataGridViewImageColumn Edit;
        private System.Windows.Forms.DataGridViewImageColumn Delete;
    }
}