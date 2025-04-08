namespace PharmacyMgt
{
    partial class frmCustomer
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
            this.DGV = new System.Windows.Forms.DataGridView();
            this.Edit = new System.Windows.Forms.DataGridViewImageColumn();
            this.Tab = new MetroFramework.Controls.MetroTabControl();
            this.Add_Customer = new MetroFramework.Controls.MetroTabPage();
            this.Customer_Details = new MetroFramework.Controls.MetroTabPage();
            this.txtContact = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtStatus = new System.Windows.Forms.ComboBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtCnic = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtSearch_CNIC = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtSearch_Email = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSearch_Name = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnInActive = new System.Windows.Forms.Button();
            this.btnActive = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).BeginInit();
            this.Tab.SuspendLayout();
            this.Add_Customer.SuspendLayout();
            this.Customer_Details.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
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
            this.DGV.Size = new System.Drawing.Size(609, 282);
            this.DGV.TabIndex = 155;
            this.DGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_CellClick_1);
            // 
            // Edit
            // 
            this.Edit.HeaderText = "Edit";
            this.Edit.Name = "Edit";
            this.Edit.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Edit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Tab
            // 
            this.Tab.Controls.Add(this.Add_Customer);
            this.Tab.Controls.Add(this.Customer_Details);
            this.Tab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Tab.Location = new System.Drawing.Point(0, 0);
            this.Tab.Name = "Tab";
            this.Tab.SelectedIndex = 0;
            this.Tab.Size = new System.Drawing.Size(617, 440);
            this.Tab.TabIndex = 162;
            // 
            // Add_Customer
            // 
            this.Add_Customer.Controls.Add(this.txtContact);
            this.Add_Customer.Controls.Add(this.label5);
            this.Add_Customer.Controls.Add(this.btnCancel);
            this.Add_Customer.Controls.Add(this.txtName);
            this.Add_Customer.Controls.Add(this.btnAdd);
            this.Add_Customer.Controls.Add(this.label1);
            this.Add_Customer.Controls.Add(this.txtStatus);
            this.Add_Customer.Controls.Add(this.txtEmail);
            this.Add_Customer.Controls.Add(this.txtCnic);
            this.Add_Customer.Controls.Add(this.label2);
            this.Add_Customer.Controls.Add(this.label3);
            this.Add_Customer.Controls.Add(this.label6);
            this.Add_Customer.Controls.Add(this.label4);
            this.Add_Customer.Controls.Add(this.txtAddress);
            this.Add_Customer.HorizontalScrollbarBarColor = true;
            this.Add_Customer.Location = new System.Drawing.Point(4, 35);
            this.Add_Customer.Name = "Add_Customer";
            this.Add_Customer.Size = new System.Drawing.Size(609, 401);
            this.Add_Customer.TabIndex = 0;
            this.Add_Customer.Text = "Add Customer";
            this.Add_Customer.VerticalScrollbarBarColor = true;
            // 
            // Customer_Details
            // 
            this.Customer_Details.Controls.Add(this.panel2);
            this.Customer_Details.Controls.Add(this.panel1);
            this.Customer_Details.HorizontalScrollbarBarColor = true;
            this.Customer_Details.Location = new System.Drawing.Point(4, 35);
            this.Customer_Details.Name = "Customer_Details";
            this.Customer_Details.Size = new System.Drawing.Size(609, 401);
            this.Customer_Details.TabIndex = 1;
            this.Customer_Details.Text = "Customer Details";
            this.Customer_Details.VerticalScrollbarBarColor = true;
            // 
            // txtContact
            // 
            this.txtContact.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtContact.Location = new System.Drawing.Point(78, 152);
            this.txtContact.Name = "txtContact";
            this.txtContact.Size = new System.Drawing.Size(199, 26);
            this.txtContact.TabIndex = 156;
            this.txtContact.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtContact_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(72, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 21);
            this.label5.TabIndex = 162;
            this.label5.Text = "Customer Name ";
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Red;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(329, 294);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(199, 37);
            this.btnCancel.TabIndex = 161;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtName.Location = new System.Drawing.Point(76, 67);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(199, 26);
            this.txtName.TabIndex = 154;
            this.txtName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtName_KeyPress);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Teal;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(78, 294);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(199, 37);
            this.btnAdd.TabIndex = 160;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(327, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 21);
            this.label1.TabIndex = 163;
            this.label1.Text = "Email";
            // 
            // txtStatus
            // 
            this.txtStatus.BackColor = System.Drawing.Color.White;
            this.txtStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtStatus.FormattingEnabled = true;
            this.txtStatus.Items.AddRange(new object[] {
            "In-active",
            "Active"});
            this.txtStatus.Location = new System.Drawing.Point(330, 235);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(198, 28);
            this.txtStatus.TabIndex = 159;
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtEmail.Location = new System.Drawing.Point(331, 67);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(199, 26);
            this.txtEmail.TabIndex = 155;
            this.txtEmail.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEmail_KeyPress);
            // 
            // txtCnic
            // 
            this.txtCnic.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtCnic.Location = new System.Drawing.Point(77, 237);
            this.txtCnic.Mask = "00000-0000000-0";
            this.txtCnic.Name = "txtCnic";
            this.txtCnic.Size = new System.Drawing.Size(199, 26);
            this.txtCnic.TabIndex = 158;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(74, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 21);
            this.label2.TabIndex = 164;
            this.label2.Text = "Contact";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(325, 210);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 21);
            this.label3.TabIndex = 167;
            this.label3.Text = "Status";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(327, 127);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 21);
            this.label6.TabIndex = 165;
            this.label6.Text = "Address";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(74, 211);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 21);
            this.label4.TabIndex = 166;
            this.label4.Text = "CNIC";
            // 
            // txtAddress
            // 
            this.txtAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtAddress.Location = new System.Drawing.Point(331, 152);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(199, 26);
            this.txtAddress.TabIndex = 157;
            this.txtAddress.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAddress_KeyPress);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.btnInActive);
            this.panel1.Controls.Add(this.btnActive);
            this.panel1.Controls.Add(this.txtSearch_CNIC);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.txtSearch_Email);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txtSearch_Name);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(609, 119);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.DGV);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 119);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(609, 282);
            this.panel2.TabIndex = 3;
            // 
            // txtSearch_CNIC
            // 
            this.txtSearch_CNIC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtSearch_CNIC.Location = new System.Drawing.Point(235, 37);
            this.txtSearch_CNIC.Name = "txtSearch_CNIC";
            this.txtSearch_CNIC.Size = new System.Drawing.Size(199, 23);
            this.txtSearch_CNIC.TabIndex = 166;
            this.txtSearch_CNIC.TextChanged += new System.EventHandler(this.txtSearch_CNIC_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(231, 12);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 19);
            this.label8.TabIndex = 167;
            this.label8.Text = "CNIC";
            // 
            // txtSearch_Email
            // 
            this.txtSearch_Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtSearch_Email.Location = new System.Drawing.Point(14, 87);
            this.txtSearch_Email.Name = "txtSearch_Email";
            this.txtSearch_Email.Size = new System.Drawing.Size(199, 23);
            this.txtSearch_Email.TabIndex = 164;
            this.txtSearch_Email.TextChanged += new System.EventHandler(this.txtSearch_Email_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(10, 62);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 19);
            this.label7.TabIndex = 165;
            this.label7.Text = "Email";
            // 
            // txtSearch_Name
            // 
            this.txtSearch_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtSearch_Name.Location = new System.Drawing.Point(14, 37);
            this.txtSearch_Name.Name = "txtSearch_Name";
            this.txtSearch_Name.Size = new System.Drawing.Size(199, 23);
            this.txtSearch_Name.TabIndex = 162;
            this.txtSearch_Name.TextChanged += new System.EventHandler(this.txtSearch_Name_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(10, 12);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(46, 19);
            this.label10.TabIndex = 163;
            this.label10.Text = "Name";
            // 
            // btnInActive
            // 
            this.btnInActive.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInActive.BackColor = System.Drawing.Color.Teal;
            this.btnInActive.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInActive.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInActive.ForeColor = System.Drawing.Color.White;
            this.btnInActive.Location = new System.Drawing.Point(459, 64);
            this.btnInActive.Name = "btnInActive";
            this.btnInActive.Size = new System.Drawing.Size(113, 46);
            this.btnInActive.TabIndex = 169;
            this.btnInActive.Text = "In-Active";
            this.btnInActive.UseVisualStyleBackColor = false;
            this.btnInActive.Click += new System.EventHandler(this.btnInActive_Click_1);
            // 
            // btnActive
            // 
            this.btnActive.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnActive.BackColor = System.Drawing.Color.Teal;
            this.btnActive.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActive.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActive.ForeColor = System.Drawing.Color.White;
            this.btnActive.Location = new System.Drawing.Point(459, 12);
            this.btnActive.Name = "btnActive";
            this.btnActive.Size = new System.Drawing.Size(113, 46);
            this.btnActive.TabIndex = 168;
            this.btnActive.Text = "Active";
            this.btnActive.UseVisualStyleBackColor = false;
            this.btnActive.Click += new System.EventHandler(this.btnActive_Click_1);
            // 
            // frmCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(617, 440);
            this.Controls.Add(this.Tab);
            this.Name = "frmCustomer";
            this.Text = "frmCustomer";
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).EndInit();
            this.Tab.ResumeLayout(false);
            this.Add_Customer.ResumeLayout(false);
            this.Add_Customer.PerformLayout();
            this.Customer_Details.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DGV;
        private System.Windows.Forms.DataGridViewImageColumn Edit;
        private MetroFramework.Controls.MetroTabControl Tab;
        private MetroFramework.Controls.MetroTabPage Add_Customer;
        private System.Windows.Forms.TextBox txtContact;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox txtStatus;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.MaskedTextBox txtCnic;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAddress;
        private MetroFramework.Controls.MetroTabPage Customer_Details;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnInActive;
        private System.Windows.Forms.Button btnActive;
        private System.Windows.Forms.TextBox txtSearch_CNIC;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtSearch_Email;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSearch_Name;
        private System.Windows.Forms.Label label10;
    }
}