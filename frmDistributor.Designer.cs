namespace PharmacyMgt
{
    partial class frmDistributor
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
            this.Tab = new MetroFramework.Controls.MetroTabControl();
            this.tab_Add = new MetroFramework.Controls.MetroTabPage();
            this.txtCnic = new MetroFramework.Controls.MetroTextBox();
            this.txtStatus = new System.Windows.Forms.ComboBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.IconPixBox = new FontAwesome.Sharp.IconPictureBox();
            this.txtPostCode = new System.Windows.Forms.MaskedTextBox();
            this.txtShopName = new MetroFramework.Controls.MetroTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAddress = new MetroFramework.Controls.MetroTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtEmail = new MetroFramework.Controls.MetroTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtContact = new MetroFramework.Controls.MetroTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtName = new MetroFramework.Controls.MetroTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tab_Details = new MetroFramework.Controls.MetroTabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.DGV = new System.Windows.Forms.DataGridView();
            this.Edit = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtSearch_CNIC = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSearch_Email = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtSearch_CompanyName = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtSearch_Name = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnInActive = new System.Windows.Forms.Button();
            this.btnActive = new System.Windows.Forms.Button();
            this.Tab.SuspendLayout();
            this.tab_Add.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IconPixBox)).BeginInit();
            this.tab_Details.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Tab
            // 
            this.Tab.Controls.Add(this.tab_Add);
            this.Tab.Controls.Add(this.tab_Details);
            this.Tab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Tab.Location = new System.Drawing.Point(0, 0);
            this.Tab.Name = "Tab";
            this.Tab.SelectedIndex = 1;
            this.Tab.Size = new System.Drawing.Size(744, 463);
            this.Tab.TabIndex = 0;
            // 
            // tab_Add
            // 
            this.tab_Add.BackColor = System.Drawing.Color.White;
            this.tab_Add.Controls.Add(this.txtCnic);
            this.tab_Add.Controls.Add(this.txtStatus);
            this.tab_Add.Controls.Add(this.btnClear);
            this.tab_Add.Controls.Add(this.btnAdd);
            this.tab_Add.Controls.Add(this.IconPixBox);
            this.tab_Add.Controls.Add(this.txtPostCode);
            this.tab_Add.Controls.Add(this.txtShopName);
            this.tab_Add.Controls.Add(this.label9);
            this.tab_Add.Controls.Add(this.label8);
            this.tab_Add.Controls.Add(this.label7);
            this.tab_Add.Controls.Add(this.label6);
            this.tab_Add.Controls.Add(this.txtAddress);
            this.tab_Add.Controls.Add(this.label5);
            this.tab_Add.Controls.Add(this.txtEmail);
            this.tab_Add.Controls.Add(this.label4);
            this.tab_Add.Controls.Add(this.txtContact);
            this.tab_Add.Controls.Add(this.label2);
            this.tab_Add.Controls.Add(this.txtName);
            this.tab_Add.Controls.Add(this.label1);
            this.tab_Add.HorizontalScrollbarBarColor = true;
            this.tab_Add.Location = new System.Drawing.Point(4, 35);
            this.tab_Add.Name = "tab_Add";
            this.tab_Add.Size = new System.Drawing.Size(736, 424);
            this.tab_Add.TabIndex = 0;
            this.tab_Add.Text = "Add Distributor";
            this.tab_Add.VerticalScrollbarBarColor = true;
            // 
            // txtCnic
            // 
            this.txtCnic.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtCnic.Location = new System.Drawing.Point(521, 202);
            this.txtCnic.Name = "txtCnic";
            this.txtCnic.Size = new System.Drawing.Size(199, 35);
            this.txtCnic.TabIndex = 4;
            this.txtCnic.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCnic_KeyPress);
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
            this.txtStatus.Location = new System.Drawing.Point(521, 279);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(199, 37);
            this.txtStatus.TabIndex = 7;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Teal;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(267, 321);
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
            this.btnAdd.Location = new System.Drawing.Point(112, 321);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(108, 48);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // IconPixBox
            // 
            this.IconPixBox.BackColor = System.Drawing.Color.White;
            this.IconPixBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.IconPixBox.IconChar = FontAwesome.Sharp.IconChar.None;
            this.IconPixBox.IconColor = System.Drawing.SystemColors.ControlText;
            this.IconPixBox.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IconPixBox.IconSize = 119;
            this.IconPixBox.Location = new System.Drawing.Point(573, 56);
            this.IconPixBox.Name = "IconPixBox";
            this.IconPixBox.Size = new System.Drawing.Size(147, 119);
            this.IconPixBox.TabIndex = 109;
            this.IconPixBox.TabStop = false;
            // 
            // txtPostCode
            // 
            this.txtPostCode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtPostCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPostCode.Location = new System.Drawing.Point(315, 280);
            this.txtPostCode.Mask = "00000";
            this.txtPostCode.Name = "txtPostCode";
            this.txtPostCode.Size = new System.Drawing.Size(200, 35);
            this.txtPostCode.TabIndex = 6;
            // 
            // txtShopName
            // 
            this.txtShopName.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtShopName.Location = new System.Drawing.Point(316, 116);
            this.txtShopName.Name = "txtShopName";
            this.txtShopName.Size = new System.Drawing.Size(199, 35);
            this.txtShopName.TabIndex = 1;
            this.txtShopName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtShopName_KeyPress_1);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(312, 93);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 21);
            this.label9.TabIndex = 106;
            this.label9.Text = "ShopName";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(517, 257);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 21);
            this.label8.TabIndex = 105;
            this.label8.Text = "Status";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(517, 178);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 21);
            this.label7.TabIndex = 104;
            this.label7.Text = "CNIC";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(312, 257);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 21);
            this.label6.TabIndex = 103;
            this.label6.Text = "PostalCode";
            // 
            // txtAddress
            // 
            this.txtAddress.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtAddress.Location = new System.Drawing.Point(112, 280);
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
            this.label5.Location = new System.Drawing.Point(108, 257);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 21);
            this.label5.TabIndex = 101;
            this.label5.Text = "Address";
            // 
            // txtEmail
            // 
            this.txtEmail.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtEmail.Location = new System.Drawing.Point(112, 201);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(199, 35);
            this.txtEmail.TabIndex = 2;
            this.txtEmail.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEmail_KeyPress_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(108, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 21);
            this.label4.TabIndex = 99;
            this.label4.Text = "Email";
            // 
            // txtContact
            // 
            this.txtContact.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtContact.Location = new System.Drawing.Point(316, 201);
            this.txtContact.Name = "txtContact";
            this.txtContact.Size = new System.Drawing.Size(199, 35);
            this.txtContact.TabIndex = 3;
            this.txtContact.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtContact_KeyPress_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(312, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 21);
            this.label2.TabIndex = 97;
            this.label2.Text = "Contact";
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.White;
            this.txtName.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtName.Location = new System.Drawing.Point(112, 116);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(199, 35);
            this.txtName.TabIndex = 0;
            this.txtName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtName_KeyPress_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(108, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 21);
            this.label1.TabIndex = 95;
            this.label1.Text = "Name";
            // 
            // tab_Details
            // 
            this.tab_Details.Controls.Add(this.panel2);
            this.tab_Details.Controls.Add(this.panel1);
            this.tab_Details.HorizontalScrollbarBarColor = true;
            this.tab_Details.Location = new System.Drawing.Point(4, 35);
            this.tab_Details.Name = "tab_Details";
            this.tab_Details.Size = new System.Drawing.Size(736, 424);
            this.tab_Details.TabIndex = 1;
            this.tab_Details.Text = "Details";
            this.tab_Details.VerticalScrollbarBarColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.DGV);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 123);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(736, 301);
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
            this.DGV.Size = new System.Drawing.Size(736, 301);
            this.DGV.TabIndex = 75;
            this.DGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_CellClick);
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
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.txtSearch_CNIC);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtSearch_Email);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.txtSearch_CompanyName);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.txtSearch_Name);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.btnInActive);
            this.panel1.Controls.Add(this.btnActive);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(736, 123);
            this.panel1.TabIndex = 2;
            // 
            // txtSearch_CNIC
            // 
            this.txtSearch_CNIC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtSearch_CNIC.Location = new System.Drawing.Point(330, 90);
            this.txtSearch_CNIC.Name = "txtSearch_CNIC";
            this.txtSearch_CNIC.Size = new System.Drawing.Size(199, 23);
            this.txtSearch_CNIC.TabIndex = 131;
            this.txtSearch_CNIC.TextChanged += new System.EventHandler(this.txtSearch_CNIC_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(326, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 19);
            this.label3.TabIndex = 132;
            this.label3.Text = "CNIC";
            // 
            // txtSearch_Email
            // 
            this.txtSearch_Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtSearch_Email.Location = new System.Drawing.Point(330, 39);
            this.txtSearch_Email.Name = "txtSearch_Email";
            this.txtSearch_Email.Size = new System.Drawing.Size(199, 23);
            this.txtSearch_Email.TabIndex = 129;
            this.txtSearch_Email.TextChanged += new System.EventHandler(this.txtSearch_Email_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(326, 14);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(43, 19);
            this.label12.TabIndex = 130;
            this.label12.Text = "Email";
            // 
            // txtSearch_CompanyName
            // 
            this.txtSearch_CompanyName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtSearch_CompanyName.Location = new System.Drawing.Point(62, 90);
            this.txtSearch_CompanyName.Name = "txtSearch_CompanyName";
            this.txtSearch_CompanyName.Size = new System.Drawing.Size(199, 23);
            this.txtSearch_CompanyName.TabIndex = 127;
            this.txtSearch_CompanyName.TextChanged += new System.EventHandler(this.txtSearch_CompanyName_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(58, 65);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(109, 19);
            this.label11.TabIndex = 128;
            this.label11.Text = "Company Name";
            // 
            // txtSearch_Name
            // 
            this.txtSearch_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtSearch_Name.Location = new System.Drawing.Point(62, 39);
            this.txtSearch_Name.Name = "txtSearch_Name";
            this.txtSearch_Name.Size = new System.Drawing.Size(199, 23);
            this.txtSearch_Name.TabIndex = 125;
            this.txtSearch_Name.TextChanged += new System.EventHandler(this.txtSearch_Name_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(58, 14);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(46, 19);
            this.label10.TabIndex = 126;
            this.label10.Text = "Name";
            // 
            // btnInActive
            // 
            this.btnInActive.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInActive.BackColor = System.Drawing.Color.Teal;
            this.btnInActive.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInActive.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInActive.ForeColor = System.Drawing.Color.White;
            this.btnInActive.Location = new System.Drawing.Point(605, 58);
            this.btnInActive.Name = "btnInActive";
            this.btnInActive.Size = new System.Drawing.Size(113, 46);
            this.btnInActive.TabIndex = 10;
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
            this.btnActive.Location = new System.Drawing.Point(605, 7);
            this.btnActive.Name = "btnActive";
            this.btnActive.Size = new System.Drawing.Size(113, 46);
            this.btnActive.TabIndex = 9;
            this.btnActive.Text = "Active";
            this.btnActive.UseVisualStyleBackColor = false;
            this.btnActive.Click += new System.EventHandler(this.btnActive_Click_1);
            // 
            // frmDistributor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(744, 463);
            this.Controls.Add(this.Tab);
            this.Name = "frmDistributor";
            this.Text = "frmDistributor";
            this.Tab.ResumeLayout(false);
            this.tab_Add.ResumeLayout(false);
            this.tab_Add.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IconPixBox)).EndInit();
            this.tab_Details.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl Tab;
        private MetroFramework.Controls.MetroTabPage tab_Add;
        private MetroFramework.Controls.MetroTabPage tab_Details;
        private MetroFramework.Controls.MetroTextBox txtCnic;
        private System.Windows.Forms.ComboBox txtStatus;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnAdd;
        private FontAwesome.Sharp.IconPictureBox IconPixBox;
        private System.Windows.Forms.MaskedTextBox txtPostCode;
        private MetroFramework.Controls.MetroTextBox txtShopName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private MetroFramework.Controls.MetroTextBox txtAddress;
        private System.Windows.Forms.Label label5;
        private MetroFramework.Controls.MetroTextBox txtEmail;
        private System.Windows.Forms.Label label4;
        private MetroFramework.Controls.MetroTextBox txtContact;
        private System.Windows.Forms.Label label2;
        private MetroFramework.Controls.MetroTextBox txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView DGV;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewImageColumn Edit;
        private System.Windows.Forms.Button btnInActive;
        private System.Windows.Forms.Button btnActive;
        private System.Windows.Forms.TextBox txtSearch_CNIC;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSearch_Email;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtSearch_CompanyName;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtSearch_Name;
        private System.Windows.Forms.Label label10;
    }
}