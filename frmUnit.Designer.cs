namespace PharmacyMgt
{
    partial class frmUnit
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtUnit = new MetroFramework.Controls.MetroTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtStatus = new MetroFramework.Controls.MetroComboBox();
            this.DGV = new System.Windows.Forms.DataGridView();
            this.Edit = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnInActive = new System.Windows.Forms.Button();
            this.btnActive = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(639, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Unit";
            // 
            // txtUnit
            // 
            this.txtUnit.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtUnit.Location = new System.Drawing.Point(643, 104);
            this.txtUnit.Name = "txtUnit";
            this.txtUnit.Size = new System.Drawing.Size(252, 35);
            this.txtUnit.TabIndex = 0;
            this.txtUnit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUnit_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(643, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Status";
            // 
            // txtStatus
            // 
            this.txtStatus.FormattingEnabled = true;
            this.txtStatus.ItemHeight = 23;
            this.txtStatus.Items.AddRange(new object[] {
            "In-active",
            "Active"});
            this.txtStatus.Location = new System.Drawing.Point(643, 169);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(252, 29);
            this.txtStatus.TabIndex = 1;
            // 
            // DGV
            // 
            this.DGV.AllowUserToAddRows = false;
            this.DGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV.BackgroundColor = System.Drawing.Color.White;
            this.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Edit});
            this.DGV.Location = new System.Drawing.Point(40, 80);
            this.DGV.Name = "DGV";
            this.DGV.Size = new System.Drawing.Size(582, 355);
            this.DGV.TabIndex = 4;
            this.DGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_CellClick);
            // 
            // Edit
            // 
            this.Edit.HeaderText = "Edit";
            this.Edit.Name = "Edit";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Teal;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(647, 219);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(108, 48);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Crimson;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(785, 219);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(110, 48);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnInActive
            // 
            this.btnInActive.BackColor = System.Drawing.Color.Teal;
            this.btnInActive.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInActive.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInActive.ForeColor = System.Drawing.Color.White;
            this.btnInActive.Location = new System.Drawing.Point(171, 28);
            this.btnInActive.Name = "btnInActive";
            this.btnInActive.Size = new System.Drawing.Size(113, 46);
            this.btnInActive.TabIndex = 14;
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
            this.btnActive.Location = new System.Drawing.Point(52, 28);
            this.btnActive.Name = "btnActive";
            this.btnActive.Size = new System.Drawing.Size(113, 46);
            this.btnActive.TabIndex = 13;
            this.btnActive.Text = "Active";
            this.btnActive.UseVisualStyleBackColor = false;
            this.btnActive.Click += new System.EventHandler(this.btnActive_Click);
            // 
            // frmUnit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(967, 496);
            this.Controls.Add(this.btnInActive);
            this.Controls.Add(this.btnActive);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.DGV);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtUnit);
            this.Controls.Add(this.label1);
            this.Name = "frmUnit";
            this.Text = "frmUnit";
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroTextBox txtUnit;
        private System.Windows.Forms.Label label2;
        private MetroFramework.Controls.MetroComboBox txtStatus;
        private System.Windows.Forms.DataGridView DGV;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.DataGridViewImageColumn Edit;
        private System.Windows.Forms.Button btnInActive;
        private System.Windows.Forms.Button btnActive;
    }
}