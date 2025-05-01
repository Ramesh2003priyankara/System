namespace Skills_International_
{
    partial class Registration_Form2
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
            this.grpStudentRegistration = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.linkLabel3 = new System.Windows.Forms.LinkLabel();
            this.cmbRegNo = new System.Windows.Forms.ComboBox();
            this.lblRegNo = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.grpParentDetails = new System.Windows.Forms.GroupBox();
            this.txtContactNo = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtParentName = new System.Windows.Forms.TextBox();
            this.txtNIC = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.grpContactDetails = new System.Windows.Forms.GroupBox();
            this.txtMobilePhone = new System.Windows.Forms.TextBox();
            this.txtHomePhone = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.grpBasicDetails = new System.Windows.Forms.GroupBox();
            this.rdbFemale = new System.Windows.Forms.RadioButton();
            this.rdbMale = new System.Windows.Forms.RadioButton();
            this.dtpDOB = new System.Windows.Forms.DateTimePicker();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label14 = new System.Windows.Forms.Label();
            this.grpStudentRegistration.SuspendLayout();
            this.grpParentDetails.SuspendLayout();
            this.grpContactDetails.SuspendLayout();
            this.grpBasicDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpStudentRegistration
            // 
            this.grpStudentRegistration.BackColor = System.Drawing.Color.LightSteelBlue;
            this.grpStudentRegistration.Controls.Add(this.btnSearch);
            this.grpStudentRegistration.Controls.Add(this.linkLabel3);
            this.grpStudentRegistration.Controls.Add(this.cmbRegNo);
            this.grpStudentRegistration.Controls.Add(this.lblRegNo);
            this.grpStudentRegistration.Controls.Add(this.btnDelete);
            this.grpStudentRegistration.Controls.Add(this.btnRegister);
            this.grpStudentRegistration.Controls.Add(this.btnClear);
            this.grpStudentRegistration.Controls.Add(this.btnUpdate);
            this.grpStudentRegistration.Controls.Add(this.grpParentDetails);
            this.grpStudentRegistration.Controls.Add(this.grpContactDetails);
            this.grpStudentRegistration.Controls.Add(this.grpBasicDetails);
            this.grpStudentRegistration.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpStudentRegistration.ForeColor = System.Drawing.Color.Indigo;
            this.grpStudentRegistration.Location = new System.Drawing.Point(12, 42);
            this.grpStudentRegistration.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpStudentRegistration.Name = "grpStudentRegistration";
            this.grpStudentRegistration.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpStudentRegistration.Size = new System.Drawing.Size(700, 807);
            this.grpStudentRegistration.TabIndex = 22;
            this.grpStudentRegistration.TabStop = false;
            this.grpStudentRegistration.Text = "Student Registration";
            this.grpStudentRegistration.Enter += new System.EventHandler(this.grpStudentRegistration_Enter);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(291, 20);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(157, 38);
            this.btnSearch.TabIndex = 16;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            this.btnSearch.Leave += new System.EventHandler(this.btnSearch_Leave);
            this.btnSearch.SystemColorsChanged += new System.EventHandler(this.btnSearch_Click);
            // 
            // linkLabel3
            // 
            this.linkLabel3.AutoSize = true;
            this.linkLabel3.Font = new System.Drawing.Font("Bauhaus 93", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel3.LinkColor = System.Drawing.Color.Brown;
            this.linkLabel3.Location = new System.Drawing.Point(633, 780);
            this.linkLabel3.Name = "linkLabel3";
            this.linkLabel3.Size = new System.Drawing.Size(44, 23);
            this.linkLabel3.TabIndex = 18;
            this.linkLabel3.TabStop = true;
            this.linkLabel3.Text = "Exit";
            this.linkLabel3.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel3_LinkClicked);
            // 
            // cmbRegNo
            // 
            this.cmbRegNo.BackColor = System.Drawing.Color.White;
            this.cmbRegNo.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbRegNo.FormattingEnabled = true;
            this.cmbRegNo.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.cmbRegNo.Location = new System.Drawing.Point(131, 27);
            this.cmbRegNo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbRegNo.Name = "cmbRegNo";
            this.cmbRegNo.Size = new System.Drawing.Size(121, 28);
            this.cmbRegNo.TabIndex = 0;
            this.cmbRegNo.SelectedIndexChanged += new System.EventHandler(this.cmbRegNo_SelectedIndexChanged);
            // 
            // lblRegNo
            // 
            this.lblRegNo.AutoSize = true;
            this.lblRegNo.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblRegNo.Location = new System.Drawing.Point(60, 32);
            this.lblRegNo.Name = "lblRegNo";
            this.lblRegNo.Size = new System.Drawing.Size(58, 22);
            this.lblRegNo.TabIndex = 9;
            this.lblRegNo.Text = "RegNo";
            this.lblRegNo.Click += new System.EventHandler(this.lblRegNo_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnDelete.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnDelete.Location = new System.Drawing.Point(33, 729);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(112, 48);
            this.btnDelete.TabIndex = 15;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnRegister.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnRegister.Location = new System.Drawing.Point(536, 729);
            this.btnRegister.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(125, 48);
            this.btnRegister.TabIndex = 13;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.MediumBlue;
            this.btnClear.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnClear.Location = new System.Drawing.Point(184, 729);
            this.btnClear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(107, 48);
            this.btnClear.TabIndex = 17;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Indigo;
            this.btnUpdate.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnUpdate.Location = new System.Drawing.Point(399, 729);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(113, 48);
            this.btnUpdate.TabIndex = 14;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // grpParentDetails
            // 
            this.grpParentDetails.Controls.Add(this.txtContactNo);
            this.grpParentDetails.Controls.Add(this.label13);
            this.grpParentDetails.Controls.Add(this.txtParentName);
            this.grpParentDetails.Controls.Add(this.txtNIC);
            this.grpParentDetails.Controls.Add(this.label12);
            this.grpParentDetails.Controls.Add(this.label11);
            this.grpParentDetails.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpParentDetails.ForeColor = System.Drawing.Color.Black;
            this.grpParentDetails.Location = new System.Drawing.Point(19, 510);
            this.grpParentDetails.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpParentDetails.Name = "grpParentDetails";
            this.grpParentDetails.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpParentDetails.Size = new System.Drawing.Size(661, 214);
            this.grpParentDetails.TabIndex = 1;
            this.grpParentDetails.TabStop = false;
            this.grpParentDetails.Text = "Parent Details";
            // 
            // txtContactNo
            // 
            this.txtContactNo.BackColor = System.Drawing.SystemColors.Window;
            this.txtContactNo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtContactNo.Font = new System.Drawing.Font("Yu Gothic UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContactNo.Location = new System.Drawing.Point(152, 154);
            this.txtContactNo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtContactNo.Name = "txtContactNo";
            this.txtContactNo.Size = new System.Drawing.Size(389, 23);
            this.txtContactNo.TabIndex = 12;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label13.Location = new System.Drawing.Point(31, 154);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(99, 23);
            this.label13.TabIndex = 3;
            this.label13.Text = "Conact No";
            // 
            // txtParentName
            // 
            this.txtParentName.BackColor = System.Drawing.SystemColors.Window;
            this.txtParentName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtParentName.Font = new System.Drawing.Font("Yu Gothic UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtParentName.Location = new System.Drawing.Point(156, 60);
            this.txtParentName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtParentName.Name = "txtParentName";
            this.txtParentName.Size = new System.Drawing.Size(389, 23);
            this.txtParentName.TabIndex = 10;
            // 
            // txtNIC
            // 
            this.txtNIC.BackColor = System.Drawing.SystemColors.Window;
            this.txtNIC.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNIC.Font = new System.Drawing.Font("Yu Gothic UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNIC.Location = new System.Drawing.Point(156, 103);
            this.txtNIC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNIC.Name = "txtNIC";
            this.txtNIC.Size = new System.Drawing.Size(389, 23);
            this.txtNIC.TabIndex = 11;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label12.Location = new System.Drawing.Point(31, 103);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(45, 23);
            this.label12.TabIndex = 2;
            this.label12.Text = "NIC";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label11.Location = new System.Drawing.Point(31, 60);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(121, 23);
            this.label11.TabIndex = 1;
            this.label11.Text = "Parent Name";
            // 
            // grpContactDetails
            // 
            this.grpContactDetails.Controls.Add(this.txtMobilePhone);
            this.grpContactDetails.Controls.Add(this.txtHomePhone);
            this.grpContactDetails.Controls.Add(this.txtAddress);
            this.grpContactDetails.Controls.Add(this.txtEmail);
            this.grpContactDetails.Controls.Add(this.label10);
            this.grpContactDetails.Controls.Add(this.label9);
            this.grpContactDetails.Controls.Add(this.label8);
            this.grpContactDetails.Controls.Add(this.label7);
            this.grpContactDetails.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpContactDetails.ForeColor = System.Drawing.Color.Black;
            this.grpContactDetails.Location = new System.Drawing.Point(19, 286);
            this.grpContactDetails.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpContactDetails.Name = "grpContactDetails";
            this.grpContactDetails.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpContactDetails.Size = new System.Drawing.Size(661, 217);
            this.grpContactDetails.TabIndex = 1;
            this.grpContactDetails.TabStop = false;
            this.grpContactDetails.Text = "Contact Deatils";
            // 
            // txtMobilePhone
            // 
            this.txtMobilePhone.BackColor = System.Drawing.SystemColors.Window;
            this.txtMobilePhone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMobilePhone.Font = new System.Drawing.Font("Yu Gothic UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMobilePhone.Location = new System.Drawing.Point(157, 174);
            this.txtMobilePhone.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMobilePhone.Name = "txtMobilePhone";
            this.txtMobilePhone.Size = new System.Drawing.Size(143, 23);
            this.txtMobilePhone.TabIndex = 8;
            // 
            // txtHomePhone
            // 
            this.txtHomePhone.BackColor = System.Drawing.SystemColors.Window;
            this.txtHomePhone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtHomePhone.Font = new System.Drawing.Font("Yu Gothic UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHomePhone.Location = new System.Drawing.Point(485, 174);
            this.txtHomePhone.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtHomePhone.Name = "txtHomePhone";
            this.txtHomePhone.Size = new System.Drawing.Size(143, 23);
            this.txtHomePhone.TabIndex = 9;
            // 
            // txtAddress
            // 
            this.txtAddress.AutoCompleteCustomSource.AddRange(new string[] {
            "10001",
            "10002",
            "10003",
            "10004"});
            this.txtAddress.BackColor = System.Drawing.SystemColors.Window;
            this.txtAddress.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAddress.Font = new System.Drawing.Font("Yu Gothic UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.Location = new System.Drawing.Point(155, 44);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(437, 53);
            this.txtAddress.TabIndex = 6;
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.SystemColors.Window;
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmail.Font = new System.Drawing.Font("Yu Gothic UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(157, 118);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(336, 23);
            this.txtEmail.TabIndex = 7;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label10.Location = new System.Drawing.Point(356, 167);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(117, 23);
            this.label10.TabIndex = 4;
            this.label10.Text = "Home Phone";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label9.Location = new System.Drawing.Point(21, 46);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 23);
            this.label9.TabIndex = 3;
            this.label9.Text = "Address";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label8.Location = new System.Drawing.Point(21, 113);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 23);
            this.label8.TabIndex = 2;
            this.label8.Text = "Email";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label7.Location = new System.Drawing.Point(21, 166);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(125, 23);
            this.label7.TabIndex = 1;
            this.label7.Text = "Mobile Phone";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // grpBasicDetails
            // 
            this.grpBasicDetails.Controls.Add(this.rdbFemale);
            this.grpBasicDetails.Controls.Add(this.rdbMale);
            this.grpBasicDetails.Controls.Add(this.dtpDOB);
            this.grpBasicDetails.Controls.Add(this.txtLastName);
            this.grpBasicDetails.Controls.Add(this.txtFirstName);
            this.grpBasicDetails.Controls.Add(this.label6);
            this.grpBasicDetails.Controls.Add(this.label5);
            this.grpBasicDetails.Controls.Add(this.label4);
            this.grpBasicDetails.Controls.Add(this.label3);
            this.grpBasicDetails.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBasicDetails.ForeColor = System.Drawing.Color.Black;
            this.grpBasicDetails.Location = new System.Drawing.Point(19, 57);
            this.grpBasicDetails.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpBasicDetails.Name = "grpBasicDetails";
            this.grpBasicDetails.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpBasicDetails.Size = new System.Drawing.Size(661, 223);
            this.grpBasicDetails.TabIndex = 0;
            this.grpBasicDetails.TabStop = false;
            this.grpBasicDetails.Text = "Basic Details";
            // 
            // rdbFemale
            // 
            this.rdbFemale.AutoSize = true;
            this.rdbFemale.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rdbFemale.Location = new System.Drawing.Point(316, 183);
            this.rdbFemale.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdbFemale.Name = "rdbFemale";
            this.rdbFemale.Size = new System.Drawing.Size(92, 27);
            this.rdbFemale.TabIndex = 5;
            this.rdbFemale.TabStop = true;
            this.rdbFemale.Text = "Female";
            this.rdbFemale.UseVisualStyleBackColor = true;
            // 
            // rdbMale
            // 
            this.rdbMale.AutoSize = true;
            this.rdbMale.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rdbMale.Location = new System.Drawing.Point(199, 183);
            this.rdbMale.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdbMale.Name = "rdbMale";
            this.rdbMale.Size = new System.Drawing.Size(74, 27);
            this.rdbMale.TabIndex = 4;
            this.rdbMale.TabStop = true;
            this.rdbMale.Text = "Male";
            this.rdbMale.UseVisualStyleBackColor = true;
            // 
            // dtpDOB
            // 
            this.dtpDOB.Location = new System.Drawing.Point(200, 135);
            this.dtpDOB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpDOB.Name = "dtpDOB";
            this.dtpDOB.Size = new System.Drawing.Size(292, 30);
            this.dtpDOB.TabIndex = 3;
            // 
            // txtLastName
            // 
            this.txtLastName.BackColor = System.Drawing.SystemColors.Window;
            this.txtLastName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLastName.Font = new System.Drawing.Font("Yu Gothic UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastName.Location = new System.Drawing.Point(165, 95);
            this.txtLastName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(437, 23);
            this.txtLastName.TabIndex = 2;
            // 
            // txtFirstName
            // 
            this.txtFirstName.BackColor = System.Drawing.SystemColors.Window;
            this.txtFirstName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFirstName.Font = new System.Drawing.Font("Yu Gothic UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirstName.Location = new System.Drawing.Point(165, 41);
            this.txtFirstName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(437, 23);
            this.txtFirstName.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label6.Location = new System.Drawing.Point(41, 185);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label6.Size = new System.Drawing.Size(74, 23);
            this.label6.TabIndex = 3;
            this.label6.Text = "Gender";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(43, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 23);
            this.label5.TabIndex = 2;
            this.label5.Text = "Date Of Birth";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(43, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 23);
            this.label4.TabIndex = 1;
            this.label4.Text = "Last Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(43, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 23);
            this.label3.TabIndex = 0;
            this.label3.Text = "First Name";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.ActiveLinkColor = System.Drawing.Color.Brown;
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Bauhaus 93", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkColor = System.Drawing.Color.DarkRed;
            this.linkLabel1.Location = new System.Drawing.Point(8, 9);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(73, 23);
            this.linkLabel1.TabIndex = 19;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "LogOut";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Lavender;
            this.label14.Font = new System.Drawing.Font("Times New Roman", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label14.Location = new System.Drawing.Point(191, 9);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(333, 43);
            this.label14.TabIndex = 28;
            this.label14.Text = "Student Registration";
            // 
            // Registration_Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Violet;
            this.ClientSize = new System.Drawing.Size(734, 853);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.grpStudentRegistration);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Registration_Form2";
            this.Text = "Registration_Form2";
            this.Load += new System.EventHandler(this.Registration_Form2_Load);
            this.grpStudentRegistration.ResumeLayout(false);
            this.grpStudentRegistration.PerformLayout();
            this.grpParentDetails.ResumeLayout(false);
            this.grpParentDetails.PerformLayout();
            this.grpContactDetails.ResumeLayout(false);
            this.grpContactDetails.PerformLayout();
            this.grpBasicDetails.ResumeLayout(false);
            this.grpBasicDetails.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpStudentRegistration;
        private System.Windows.Forms.LinkLabel linkLabel3;
        private System.Windows.Forms.ComboBox cmbRegNo;
        private System.Windows.Forms.Label lblRegNo;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.GroupBox grpParentDetails;
        private System.Windows.Forms.TextBox txtContactNo;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtParentName;
        private System.Windows.Forms.TextBox txtNIC;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox grpContactDetails;
        private System.Windows.Forms.TextBox txtMobilePhone;
        private System.Windows.Forms.TextBox txtHomePhone;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox grpBasicDetails;
        private System.Windows.Forms.RadioButton rdbFemale;
        private System.Windows.Forms.RadioButton rdbMale;
        private System.Windows.Forms.DateTimePicker dtpDOB;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnSearch;
    }
}