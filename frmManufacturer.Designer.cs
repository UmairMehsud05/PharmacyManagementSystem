namespace PharmacyMgt
{
    partial class frmManufacturer
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
            this.MyTab = new MetroFramework.Controls.MetroTabControl();
            this.tab_AddManufacturer = new MetroFramework.Controls.MetroTabPage();
            this.txtStatus = new System.Windows.Forms.ComboBox();
            this.txtGender = new System.Windows.Forms.ComboBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.iconPicBox = new FontAwesome.Sharp.IconPictureBox();
            this.txtZipCode = new System.Windows.Forms.MaskedTextBox();
            this.txtEmail = new MetroFramework.Controls.MetroTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAddress = new MetroFramework.Controls.MetroTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtContact = new MetroFramework.Controls.MetroTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtManagerName = new MetroFramework.Controls.MetroTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtComName = new MetroFramework.Controls.MetroTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tab_ManufacturerDetails = new MetroFramework.Controls.MetroTabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.DGV = new System.Windows.Forms.DataGridView();
            this.Edit = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtSearch_Email = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSearch_CompanyName = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnInActive = new System.Windows.Forms.Button();
            this.btnActive = new System.Windows.Forms.Button();
            this.MyTab.SuspendLayout();
            this.tab_AddManufacturer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPicBox)).BeginInit();
            this.tab_ManufacturerDetails.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MyTab
            // 
            this.MyTab.Controls.Add(this.tab_AddManufacturer);
            this.MyTab.Controls.Add(this.tab_ManufacturerDetails);
            this.MyTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MyTab.Location = new System.Drawing.Point(0, 0);
            this.MyTab.Name = "MyTab";
            this.MyTab.SelectedIndex = 1;
            this.MyTab.Size = new System.Drawing.Size(767, 472);
            this.MyTab.TabIndex = 0;
            // 
            // tab_AddManufacturer
            // 
            this.tab_AddManufacturer.BackColor = System.Drawing.Color.White;
            this.tab_AddManufacturer.Controls.Add(this.txtStatus);
            this.tab_AddManufacturer.Controls.Add(this.txtGender);
            this.tab_AddManufacturer.Controls.Add(this.btnClear);
            this.tab_AddManufacturer.Controls.Add(this.btnAdd);
            this.tab_AddManufacturer.Controls.Add(this.iconPicBox);
            this.tab_AddManufacturer.Controls.Add(this.txtZipCode);
            this.tab_AddManufacturer.Controls.Add(this.txtEmail);
            this.tab_AddManufacturer.Controls.Add(this.label9);
            this.tab_AddManufacturer.Controls.Add(this.label8);
            this.tab_AddManufacturer.Controls.Add(this.label7);
            this.tab_AddManufacturer.Controls.Add(this.label6);
            this.tab_AddManufacturer.Controls.Add(this.txtAddress);
            this.tab_AddManufacturer.Controls.Add(this.label5);
            this.tab_AddManufacturer.Controls.Add(this.txtContact);
            this.tab_AddManufacturer.Controls.Add(this.label4);
            this.tab_AddManufacturer.Controls.Add(this.txtManagerName);
            this.tab_AddManufacturer.Controls.Add(this.label2);
            this.tab_AddManufacturer.Controls.Add(this.txtComName);
            this.tab_AddManufacturer.Controls.Add(this.label1);
            this.tab_AddManufacturer.HorizontalScrollbarBarColor = true;
            this.tab_AddManufacturer.Location = new System.Drawing.Point(4, 35);
            this.tab_AddManufacturer.Name = "tab_AddManufacturer";
            this.tab_AddManufacturer.Size = new System.Drawing.Size(759, 433);
            this.tab_AddManufacturer.TabIndex = 0;
            this.tab_AddManufacturer.Text = "Add Manufacturer";
            this.tab_AddManufacturer.VerticalScrollbarBarColor = true;
            // 
            // txtStatus
            // 
            this.txtStatus.BackColor = System.Drawing.SystemColors.Control;
            this.txtStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStatus.FormattingEnabled = true;
            this.txtStatus.Items.AddRange(new object[] {
            "In-active",
            "Active"});
            this.txtStatus.Location = new System.Drawing.Point(486, 282);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(199, 37);
            this.txtStatus.TabIndex = 7;
            // 
            // txtGender
            // 
            this.txtGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGender.FormattingEnabled = true;
            this.txtGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.txtGender.Location = new System.Drawing.Point(486, 203);
            this.txtGender.Name = "txtGender";
            this.txtGender.Size = new System.Drawing.Size(199, 37);
            this.txtGender.TabIndex = 4;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Teal;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(232, 325);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(108, 48);
            this.btnClear.TabIndex = 9;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Teal;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(77, 325);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(108, 48);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // iconPicBox
            // 
            this.iconPicBox.BackColor = System.Drawing.Color.White;
            this.iconPicBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconPicBox.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconPicBox.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconPicBox.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPicBox.IconSize = 119;
            this.iconPicBox.Location = new System.Drawing.Point(538, 60);
            this.iconPicBox.Name = "iconPicBox";
            this.iconPicBox.Size = new System.Drawing.Size(147, 119);
            this.iconPicBox.TabIndex = 69;
            this.iconPicBox.TabStop = false;
            // 
            // txtZipCode
            // 
            this.txtZipCode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtZipCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtZipCode.Location = new System.Drawing.Point(280, 284);
            this.txtZipCode.Mask = "00000";
            this.txtZipCode.Name = "txtZipCode";
            this.txtZipCode.Size = new System.Drawing.Size(200, 35);
            this.txtZipCode.TabIndex = 6;
            // 
            // txtEmail
            // 
            this.txtEmail.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtEmail.Location = new System.Drawing.Point(281, 120);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(199, 35);
            this.txtEmail.TabIndex = 1;
            this.txtEmail.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEmail_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(277, 97);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 21);
            this.label9.TabIndex = 66;
            this.label9.Text = "Email";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(482, 261);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 21);
            this.label8.TabIndex = 65;
            this.label8.Text = "Status";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(482, 182);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 21);
            this.label7.TabIndex = 64;
            this.label7.Text = "Gender";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(277, 261);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 21);
            this.label6.TabIndex = 63;
            this.label6.Text = "ZipCode";
            // 
            // txtAddress
            // 
            this.txtAddress.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtAddress.Location = new System.Drawing.Point(77, 284);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(199, 35);
            this.txtAddress.TabIndex = 5;
            this.txtAddress.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAddress_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(73, 261);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 21);
            this.label5.TabIndex = 61;
            this.label5.Text = "Address";
            // 
            // txtContact
            // 
            this.txtContact.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtContact.Location = new System.Drawing.Point(77, 205);
            this.txtContact.Name = "txtContact";
            this.txtContact.Size = new System.Drawing.Size(199, 35);
            this.txtContact.TabIndex = 2;
            this.txtContact.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtContact_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(73, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 21);
            this.label4.TabIndex = 59;
            this.label4.Text = "Contact";
            // 
            // txtManagerName
            // 
            this.txtManagerName.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtManagerName.Location = new System.Drawing.Point(281, 205);
            this.txtManagerName.Name = "txtManagerName";
            this.txtManagerName.Size = new System.Drawing.Size(199, 35);
            this.txtManagerName.TabIndex = 3;
            this.txtManagerName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtManagerName_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(277, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 21);
            this.label2.TabIndex = 57;
            this.label2.Text = "ManagerName";
            // 
            // txtComName
            // 
            this.txtComName.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtComName.Location = new System.Drawing.Point(77, 120);
            this.txtComName.Name = "txtComName";
            this.txtComName.Size = new System.Drawing.Size(199, 35);
            this.txtComName.TabIndex = 0;
            this.txtComName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtComName_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(73, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 21);
            this.label1.TabIndex = 55;
            this.label1.Text = "CompanyName";
            // 
            // tab_ManufacturerDetails
            // 
            this.tab_ManufacturerDetails.Controls.Add(this.panel2);
            this.tab_ManufacturerDetails.Controls.Add(this.panel1);
            this.tab_ManufacturerDetails.HorizontalScrollbarBarColor = true;
            this.tab_ManufacturerDetails.Location = new System.Drawing.Point(4, 35);
            this.tab_ManufacturerDetails.Name = "tab_ManufacturerDetails";
            this.tab_ManufacturerDetails.Size = new System.Drawing.Size(759, 433);
            this.tab_ManufacturerDetails.TabIndex = 1;
            this.tab_ManufacturerDetails.Text = "Details";
            this.tab_ManufacturerDetails.VerticalScrollbarBarColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.DGV);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 114);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(759, 319);
            this.panel2.TabIndex = 3;
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
            this.DGV.Location = new System.Drawing.Point(0, 0);
            this.DGV.Name = "DGV";
            this.DGV.Size = new System.Drawing.Size(759, 319);
            this.DGV.TabIndex = 56;
            this.DGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_CellClick_1);
            // 
            // Edit
            // 
            this.Edit.HeaderText = "Edit";
            this.Edit.Name = "Edit";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.txtSearch_Email);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtSearch_CompanyName);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.btnInActive);
            this.panel1.Controls.Add(this.btnActive);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(759, 114);
            this.panel1.TabIndex = 2;
            // 
            // txtSearch_Email
            // 
            this.txtSearch_Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtSearch_Email.Location = new System.Drawing.Point(285, 55);
            this.txtSearch_Email.Name = "txtSearch_Email";
            this.txtSearch_Email.Size = new System.Drawing.Size(199, 23);
            this.txtSearch_Email.TabIndex = 129;
            this.txtSearch_Email.TextChanged += new System.EventHandler(this.txtSearch_Email_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(281, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 19);
            this.label3.TabIndex = 130;
            this.label3.Text = "Email";
            // 
            // txtSearch_CompanyName
            // 
            this.txtSearch_CompanyName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtSearch_CompanyName.Location = new System.Drawing.Point(43, 55);
            this.txtSearch_CompanyName.Name = "txtSearch_CompanyName";
            this.txtSearch_CompanyName.Size = new System.Drawing.Size(199, 23);
            this.txtSearch_CompanyName.TabIndex = 127;
            this.txtSearch_CompanyName.TextChanged += new System.EventHandler(this.txtSearch_CompanyName_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(39, 30);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(109, 19);
            this.label10.TabIndex = 128;
            this.label10.Text = "Company Name";
            // 
            // btnInActive
            // 
            this.btnInActive.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInActive.BackColor = System.Drawing.Color.Teal;
            this.btnInActive.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInActive.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInActive.ForeColor = System.Drawing.Color.White;
            this.btnInActive.Location = new System.Drawing.Point(638, 64);
            this.btnInActive.Name = "btnInActive";
            this.btnInActive.Size = new System.Drawing.Size(113, 46);
            this.btnInActive.TabIndex = 12;
            this.btnInActive.Text = "In-Active";
            this.btnInActive.UseVisualStyleBackColor = false;
            this.btnInActive.Click += new System.EventHandler(this.btnInActive_Click);
            // 
            // btnActive
            // 
            this.btnActive.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnActive.BackColor = System.Drawing.Color.Teal;
            this.btnActive.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActive.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActive.ForeColor = System.Drawing.Color.White;
            this.btnActive.Location = new System.Drawing.Point(638, 13);
            this.btnActive.Name = "btnActive";
            this.btnActive.Size = new System.Drawing.Size(113, 46);
            this.btnActive.TabIndex = 11;
            this.btnActive.Text = "Active";
            this.btnActive.UseVisualStyleBackColor = false;
            this.btnActive.Click += new System.EventHandler(this.btnActive_Click);
            // 
            // frmManufacturer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(767, 472);
            this.Controls.Add(this.MyTab);
            this.MaximizeBox = false;
            this.Name = "frmManufacturer";
            this.Text = "frmManufacturer";
            this.MyTab.ResumeLayout(false);
            this.tab_AddManufacturer.ResumeLayout(false);
            this.tab_AddManufacturer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPicBox)).EndInit();
            this.tab_ManufacturerDetails.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl MyTab;
        private MetroFramework.Controls.MetroTabPage tab_AddManufacturer;
        private MetroFramework.Controls.MetroTabPage tab_ManufacturerDetails;
        private System.Windows.Forms.ComboBox txtStatus;
        private System.Windows.Forms.ComboBox txtGender;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnAdd;
        private FontAwesome.Sharp.IconPictureBox iconPicBox;
        private System.Windows.Forms.MaskedTextBox txtZipCode;
        private MetroFramework.Controls.MetroTextBox txtEmail;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private MetroFramework.Controls.MetroTextBox txtAddress;
        private System.Windows.Forms.Label label5;
        private MetroFramework.Controls.MetroTextBox txtContact;
        private System.Windows.Forms.Label label4;
        private MetroFramework.Controls.MetroTextBox txtManagerName;
        private System.Windows.Forms.Label label2;
        private MetroFramework.Controls.MetroTextBox txtComName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView DGV;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewImageColumn Edit;
        private System.Windows.Forms.Button btnInActive;
        private System.Windows.Forms.Button btnActive;
        private System.Windows.Forms.TextBox txtSearch_Email;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSearch_CompanyName;
        private System.Windows.Forms.Label label10;
    }
}