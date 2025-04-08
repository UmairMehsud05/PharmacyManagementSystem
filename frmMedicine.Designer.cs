namespace PharmacyMgt
{
    partial class frmMedicine
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
            this.Tab = new System.Windows.Forms.TabControl();
            this.tabAdd = new System.Windows.Forms.TabPage();
            this.txtMedicineStatus = new System.Windows.Forms.ComboBox();
            this.txtSubCategory = new System.Windows.Forms.ComboBox();
            this.txtCategory = new System.Windows.Forms.ComboBox();
            this.txtManufacturer = new System.Windows.Forms.ComboBox();
            this.txtUnitName = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtDescription = new System.Windows.Forms.RichTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMedicineFormula = new System.Windows.Forms.TextBox();
            this.txtMedicineName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabMedicineDetail = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.DGV = new System.Windows.Forms.DataGridView();
            this.Edit = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ddlSearchManufacture = new System.Windows.Forms.ComboBox();
            this.ddlSearchCategory = new System.Windows.Forms.ComboBox();
            this.btnInActive = new System.Windows.Forms.Button();
            this.btnActive = new System.Windows.Forms.Button();
            this.ddlSearch_Unit = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtSearch_MedFormula = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtSearch_MedName = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.Tab.SuspendLayout();
            this.tabAdd.SuspendLayout();
            this.tabMedicineDetail.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Tab
            // 
            this.Tab.Controls.Add(this.tabAdd);
            this.Tab.Controls.Add(this.tabMedicineDetail);
            this.Tab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Tab.Location = new System.Drawing.Point(0, 0);
            this.Tab.Name = "Tab";
            this.Tab.SelectedIndex = 0;
            this.Tab.Size = new System.Drawing.Size(726, 487);
            this.Tab.TabIndex = 0;
            // 
            // tabAdd
            // 
            this.tabAdd.Controls.Add(this.txtMedicineStatus);
            this.tabAdd.Controls.Add(this.txtSubCategory);
            this.tabAdd.Controls.Add(this.txtCategory);
            this.tabAdd.Controls.Add(this.txtManufacturer);
            this.tabAdd.Controls.Add(this.txtUnitName);
            this.tabAdd.Controls.Add(this.btnAdd);
            this.tabAdd.Controls.Add(this.txtDescription);
            this.tabAdd.Controls.Add(this.label8);
            this.tabAdd.Controls.Add(this.label7);
            this.tabAdd.Controls.Add(this.txtMedicineFormula);
            this.tabAdd.Controls.Add(this.txtMedicineName);
            this.tabAdd.Controls.Add(this.label6);
            this.tabAdd.Controls.Add(this.label5);
            this.tabAdd.Controls.Add(this.label4);
            this.tabAdd.Controls.Add(this.label3);
            this.tabAdd.Controls.Add(this.label1);
            this.tabAdd.Controls.Add(this.label2);
            this.tabAdd.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabAdd.Location = new System.Drawing.Point(4, 22);
            this.tabAdd.Name = "tabAdd";
            this.tabAdd.Padding = new System.Windows.Forms.Padding(3);
            this.tabAdd.Size = new System.Drawing.Size(718, 461);
            this.tabAdd.TabIndex = 0;
            this.tabAdd.Text = "Add Medicine";
            this.tabAdd.UseVisualStyleBackColor = true;
            // 
            // txtMedicineStatus
            // 
            this.txtMedicineStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtMedicineStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtMedicineStatus.FormattingEnabled = true;
            this.txtMedicineStatus.Items.AddRange(new object[] {
            "In-active",
            "Active"});
            this.txtMedicineStatus.Location = new System.Drawing.Point(61, 237);
            this.txtMedicineStatus.Name = "txtMedicineStatus";
            this.txtMedicineStatus.Size = new System.Drawing.Size(198, 28);
            this.txtMedicineStatus.TabIndex = 7;
            // 
            // txtSubCategory
            // 
            this.txtSubCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtSubCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtSubCategory.FormattingEnabled = true;
            this.txtSubCategory.Location = new System.Drawing.Point(283, 93);
            this.txtSubCategory.Name = "txtSubCategory";
            this.txtSubCategory.Size = new System.Drawing.Size(198, 28);
            this.txtSubCategory.TabIndex = 4;
            // 
            // txtCategory
            // 
            this.txtCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtCategory.FormattingEnabled = true;
            this.txtCategory.Location = new System.Drawing.Point(61, 91);
            this.txtCategory.Name = "txtCategory";
            this.txtCategory.Size = new System.Drawing.Size(198, 28);
            this.txtCategory.TabIndex = 2;
            this.txtCategory.SelectedIndexChanged += new System.EventHandler(this.txtCategory_SelectionChangeCommitted);
            // 
            // txtManufacturer
            // 
            this.txtManufacturer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtManufacturer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtManufacturer.FormattingEnabled = true;
            this.txtManufacturer.Location = new System.Drawing.Point(61, 159);
            this.txtManufacturer.Name = "txtManufacturer";
            this.txtManufacturer.Size = new System.Drawing.Size(198, 28);
            this.txtManufacturer.TabIndex = 1;
            // 
            // txtUnitName
            // 
            this.txtUnitName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtUnitName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtUnitName.FormattingEnabled = true;
            this.txtUnitName.Location = new System.Drawing.Point(491, 92);
            this.txtUnitName.Name = "txtUnitName";
            this.txtUnitName.Size = new System.Drawing.Size(198, 28);
            this.txtUnitName.TabIndex = 0;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Teal;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(61, 309);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(199, 49);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtDescription
            // 
            this.txtDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtDescription.Location = new System.Drawing.Point(283, 237);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(407, 121);
            this.txtDescription.TabIndex = 6;
            this.txtDescription.Text = "";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(57, 212);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(127, 21);
            this.label8.TabIndex = 125;
            this.label8.Text = "Medicine Status";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(279, 212);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 21);
            this.label7.TabIndex = 124;
            this.label7.Text = "Description";
            // 
            // txtMedicineFormula
            // 
            this.txtMedicineFormula.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtMedicineFormula.Location = new System.Drawing.Point(491, 161);
            this.txtMedicineFormula.Name = "txtMedicineFormula";
            this.txtMedicineFormula.Size = new System.Drawing.Size(199, 26);
            this.txtMedicineFormula.TabIndex = 5;
            // 
            // txtMedicineName
            // 
            this.txtMedicineName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtMedicineName.Location = new System.Drawing.Point(283, 160);
            this.txtMedicineName.Name = "txtMedicineName";
            this.txtMedicineName.Size = new System.Drawing.Size(199, 26);
            this.txtMedicineName.TabIndex = 5;
            this.txtMedicineName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMedicineName_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(487, 135);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(141, 21);
            this.label6.TabIndex = 121;
            this.label6.Text = "Medicine Formula";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(279, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 21);
            this.label5.TabIndex = 120;
            this.label5.Text = "Medicine Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(279, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 21);
            this.label4.TabIndex = 118;
            this.label4.Text = "Sub-Category";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(57, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 21);
            this.label3.TabIndex = 116;
            this.label3.Text = "Category";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(57, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 21);
            this.label1.TabIndex = 114;
            this.label1.Text = "Manufacturer";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(487, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 21);
            this.label2.TabIndex = 97;
            this.label2.Text = "Unit Name";
            // 
            // tabMedicineDetail
            // 
            this.tabMedicineDetail.Controls.Add(this.panel2);
            this.tabMedicineDetail.Controls.Add(this.panel1);
            this.tabMedicineDetail.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabMedicineDetail.Location = new System.Drawing.Point(4, 22);
            this.tabMedicineDetail.Name = "tabMedicineDetail";
            this.tabMedicineDetail.Padding = new System.Windows.Forms.Padding(3);
            this.tabMedicineDetail.Size = new System.Drawing.Size(718, 461);
            this.tabMedicineDetail.TabIndex = 1;
            this.tabMedicineDetail.Text = "Medicine Detail";
            this.tabMedicineDetail.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.DGV);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 125);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(712, 333);
            this.panel2.TabIndex = 1;
            // 
            // DGV
            // 
            this.DGV.AllowUserToAddRows = false;
            this.DGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV.BackgroundColor = System.Drawing.Color.White;
            this.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Edit});
            this.DGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGV.GridColor = System.Drawing.Color.White;
            this.DGV.Location = new System.Drawing.Point(0, 0);
            this.DGV.Name = "DGV";
            this.DGV.Size = new System.Drawing.Size(712, 333);
            this.DGV.TabIndex = 0;
            this.DGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // Edit
            // 
            this.Edit.HeaderText = "Edit";
            this.Edit.Name = "Edit";
            this.Edit.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Edit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ddlSearchManufacture);
            this.panel1.Controls.Add(this.ddlSearchCategory);
            this.panel1.Controls.Add(this.btnInActive);
            this.panel1.Controls.Add(this.btnActive);
            this.panel1.Controls.Add(this.ddlSearch_Unit);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.txtSearch_MedFormula);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.txtSearch_MedName);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(712, 122);
            this.panel1.TabIndex = 0;
            // 
            // ddlSearchManufacture
            // 
            this.ddlSearchManufacture.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlSearchManufacture.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ddlSearchManufacture.FormattingEnabled = true;
            this.ddlSearchManufacture.Location = new System.Drawing.Point(491, 29);
            this.ddlSearchManufacture.Name = "ddlSearchManufacture";
            this.ddlSearchManufacture.Size = new System.Drawing.Size(198, 28);
            this.ddlSearchManufacture.TabIndex = 135;
            this.ddlSearchManufacture.SelectionChangeCommitted += new System.EventHandler(this.ddlSearchManufacture_SelectedIndexChanged);
            // 
            // ddlSearchCategory
            // 
            this.ddlSearchCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlSearchCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ddlSearchCategory.FormattingEnabled = true;
            this.ddlSearchCategory.Location = new System.Drawing.Point(249, 82);
            this.ddlSearchCategory.Name = "ddlSearchCategory";
            this.ddlSearchCategory.Size = new System.Drawing.Size(198, 28);
            this.ddlSearchCategory.TabIndex = 134;
            this.ddlSearchCategory.SelectionChangeCommitted += new System.EventHandler(this.ddlSearchCategory_SelectedIndexChanged);
            // 
            // btnInActive
            // 
            this.btnInActive.BackColor = System.Drawing.Color.Teal;
            this.btnInActive.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInActive.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInActive.ForeColor = System.Drawing.Color.White;
            this.btnInActive.Location = new System.Drawing.Point(593, 62);
            this.btnInActive.Name = "btnInActive";
            this.btnInActive.Size = new System.Drawing.Size(113, 46);
            this.btnInActive.TabIndex = 133;
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
            this.btnActive.Location = new System.Drawing.Point(474, 62);
            this.btnActive.Name = "btnActive";
            this.btnActive.Size = new System.Drawing.Size(113, 46);
            this.btnActive.TabIndex = 132;
            this.btnActive.Text = "Active";
            this.btnActive.UseVisualStyleBackColor = false;
            this.btnActive.Click += new System.EventHandler(this.btnActive_Click);
            // 
            // ddlSearch_Unit
            // 
            this.ddlSearch_Unit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlSearch_Unit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ddlSearch_Unit.FormattingEnabled = true;
            this.ddlSearch_Unit.Location = new System.Drawing.Point(249, 31);
            this.ddlSearch_Unit.Name = "ddlSearch_Unit";
            this.ddlSearch_Unit.Size = new System.Drawing.Size(198, 28);
            this.ddlSearch_Unit.TabIndex = 131;
            this.ddlSearch_Unit.SelectionChangeCommitted += new System.EventHandler(this.txtSearch_Unit_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(487, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 19);
            this.label9.TabIndex = 130;
            this.label9.Text = "Manufacture";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(245, 62);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(66, 19);
            this.label12.TabIndex = 128;
            this.label12.Text = "Category";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(245, 9);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(36, 19);
            this.label13.TabIndex = 126;
            this.label13.Text = "Unit";
            // 
            // txtSearch_MedFormula
            // 
            this.txtSearch_MedFormula.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtSearch_MedFormula.Location = new System.Drawing.Point(9, 85);
            this.txtSearch_MedFormula.Name = "txtSearch_MedFormula";
            this.txtSearch_MedFormula.Size = new System.Drawing.Size(199, 23);
            this.txtSearch_MedFormula.TabIndex = 123;
            this.txtSearch_MedFormula.TextChanged += new System.EventHandler(this.txtSearch_MedFormula_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(5, 60);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(122, 19);
            this.label11.TabIndex = 124;
            this.label11.Text = "Medicine Formula";
            // 
            // txtSearch_MedName
            // 
            this.txtSearch_MedName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtSearch_MedName.Location = new System.Drawing.Point(9, 34);
            this.txtSearch_MedName.Name = "txtSearch_MedName";
            this.txtSearch_MedName.Size = new System.Drawing.Size(199, 23);
            this.txtSearch_MedName.TabIndex = 121;
            this.txtSearch_MedName.TextChanged += new System.EventHandler(this.txtSearch_MedName_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(5, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(108, 19);
            this.label10.TabIndex = 122;
            this.label10.Text = "Medicine Name";
            // 
            // frmMedicine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 487);
            this.Controls.Add(this.Tab);
            this.MaximizeBox = false;
            this.Name = "frmMedicine";
            this.Text = "frmMedicine";
            this.Tab.ResumeLayout(false);
            this.tabAdd.ResumeLayout(false);
            this.tabAdd.PerformLayout();
            this.tabMedicineDetail.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl Tab;
        private System.Windows.Forms.TabPage tabAdd;
        private System.Windows.Forms.TabPage tabMedicineDetail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox txtDescription;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtMedicineFormula;
        private System.Windows.Forms.TextBox txtMedicineName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView DGV;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox txtUnitName;
        private System.Windows.Forms.ComboBox txtManufacturer;
        private System.Windows.Forms.ComboBox txtCategory;
        private System.Windows.Forms.ComboBox txtSubCategory;
        private System.Windows.Forms.ComboBox txtMedicineStatus;
        private System.Windows.Forms.TextBox txtSearch_MedName;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtSearch_MedFormula;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridViewImageColumn Edit;
        private System.Windows.Forms.ComboBox ddlSearch_Unit;
        private System.Windows.Forms.Button btnInActive;
        private System.Windows.Forms.Button btnActive;
        private System.Windows.Forms.ComboBox ddlSearchManufacture;
        private System.Windows.Forms.ComboBox ddlSearchCategory;
    }
}