namespace HotelManagementSystem
{
    partial class addStaff
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
            this.components = new System.ComponentModel.Container();
            this.Payment = new System.Windows.Forms.GroupBox();
            this.SetWage = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.WageType = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.WageMethod = new System.Windows.Forms.ComboBox();
            this.per = new System.Windows.Forms.Label();
            this.paymethod = new System.Windows.Forms.Label();
            this.Save = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.Qualification = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.Gender = new System.Windows.Forms.ComboBox();
            this.Religion = new System.Windows.Forms.ComboBox();
            this.Address = new System.Windows.Forms.TextBox();
            this.Nationality = new System.Windows.Forms.ComboBox();
            this.MemberName = new System.Windows.Forms.TextBox();
            this.NIC = new System.Windows.Forms.TextBox();
            this.Contact = new System.Windows.Forms.TextBox();
            this.Email = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.TGuestsLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TAdultsLabel = new System.Windows.Forms.Label();
            this.TChikdernLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.JoiningDate = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.EmploymentType = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.EmailError = new System.Windows.Forms.ErrorProvider(this.components);
            this.Payment.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EmailError)).BeginInit();
            this.SuspendLayout();
            // 
            // Payment
            // 
            this.Payment.Controls.Add(this.SetWage);
            this.Payment.Controls.Add(this.label8);
            this.Payment.Controls.Add(this.WageType);
            this.Payment.Controls.Add(this.label14);
            this.Payment.Controls.Add(this.label13);
            this.Payment.Controls.Add(this.WageMethod);
            this.Payment.Controls.Add(this.per);
            this.Payment.Controls.Add(this.paymethod);
            this.Payment.Location = new System.Drawing.Point(64, 425);
            this.Payment.Name = "Payment";
            this.Payment.Size = new System.Drawing.Size(655, 93);
            this.Payment.TabIndex = 22;
            this.Payment.TabStop = false;
            this.Payment.Text = "Pay Details";
            // 
            // SetWage
            // 
            this.SetWage.Location = new System.Drawing.Point(508, 44);
            this.SetWage.Name = "SetWage";
            this.SetWage.Size = new System.Drawing.Size(118, 22);
            this.SetWage.TabIndex = 21;
            this.SetWage.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SetWage_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(421, 47);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 16);
            this.label8.TabIndex = 21;
            this.label8.Text = "Set Wage:";
            // 
            // WageType
            // 
            this.WageType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.WageType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.WageType.FormattingEnabled = true;
            this.WageType.Items.AddRange(new object[] {
            "Hourly",
            "Monthly"});
            this.WageType.Location = new System.Drawing.Point(283, 44);
            this.WageType.Name = "WageType";
            this.WageType.Size = new System.Drawing.Size(118, 24);
            this.WageType.TabIndex = 19;
            this.WageType.SelectedIndexChanged += new System.EventHandler(this.WageType_SelectedIndexChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(230, 47);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(42, 16);
            this.label14.TabIndex = 18;
            this.label14.Text = "Type:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(280, 87);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(0, 16);
            this.label13.TabIndex = 11;
            // 
            // WageMethod
            // 
            this.WageMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.WageMethod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.WageMethod.FormattingEnabled = true;
            this.WageMethod.Items.AddRange(new object[] {
            "Cash",
            "EasyPaisa",
            "JazzCash"});
            this.WageMethod.Location = new System.Drawing.Point(79, 44);
            this.WageMethod.Name = "WageMethod";
            this.WageMethod.Size = new System.Drawing.Size(118, 24);
            this.WageMethod.TabIndex = 17;
            // 
            // per
            // 
            this.per.AutoSize = true;
            this.per.Cursor = System.Windows.Forms.Cursors.Default;
            this.per.ForeColor = System.Drawing.Color.Blue;
            this.per.Location = new System.Drawing.Point(421, 63);
            this.per.Name = "per";
            this.per.Size = new System.Drawing.Size(0, 16);
            this.per.TabIndex = 13;
            // 
            // paymethod
            // 
            this.paymethod.AutoSize = true;
            this.paymethod.Location = new System.Drawing.Point(6, 47);
            this.paymethod.Name = "paymethod";
            this.paymethod.Size = new System.Drawing.Size(55, 16);
            this.paymethod.TabIndex = 14;
            this.paymethod.Text = "Method:";
            // 
            // Save
            // 
            this.Save.BackColor = System.Drawing.Color.ForestGreen;
            this.Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Save.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Save.Location = new System.Drawing.Point(255, 531);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(218, 32);
            this.Save.TabIndex = 20;
            this.Save.Text = "Add Staff Member";
            this.Save.UseVisualStyleBackColor = false;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DateOfBirth);
            this.groupBox1.Controls.Add(this.Qualification);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.Gender);
            this.groupBox1.Controls.Add(this.Religion);
            this.groupBox1.Controls.Add(this.Address);
            this.groupBox1.Controls.Add(this.Nationality);
            this.groupBox1.Controls.Add(this.MemberName);
            this.groupBox1.Controls.Add(this.NIC);
            this.groupBox1.Controls.Add(this.Contact);
            this.groupBox1.Controls.Add(this.Email);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.TGuestsLabel);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.TAdultsLabel);
            this.groupBox1.Controls.Add(this.TChikdernLabel);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(64, 100);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(655, 238);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Personal Details";
            // 
            // DateOfBirth
            // 
            this.DateOfBirth.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateOfBirth.Location = new System.Drawing.Point(438, 121);
            this.DateOfBirth.Name = "DateOfBirth";
            this.DateOfBirth.Size = new System.Drawing.Size(188, 22);
            this.DateOfBirth.TabIndex = 20;
            // 
            // Qualification
            // 
            this.Qualification.Location = new System.Drawing.Point(438, 160);
            this.Qualification.Name = "Qualification";
            this.Qualification.Size = new System.Drawing.Size(188, 22);
            this.Qualification.TabIndex = 20;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(326, 160);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(83, 16);
            this.label15.TabIndex = 19;
            this.label15.Text = "Qualification:";
            // 
            // Gender
            // 
            this.Gender.DisplayMember = "Select Gender";
            this.Gender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Gender.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Gender.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Other"});
            this.Gender.Location = new System.Drawing.Point(94, 195);
            this.Gender.Name = "Gender";
            this.Gender.Size = new System.Drawing.Size(188, 24);
            this.Gender.TabIndex = 18;
            // 
            // Religion
            // 
            this.Religion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Religion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Religion.FormattingEnabled = true;
            this.Religion.Items.AddRange(new object[] {
            "Islam",
            "Baha\'i",
            "Buddhism",
            "Christianity",
            "Confucianism",
            "Hinduism",
            "Jainism",
            "Judaism",
            "Shinto",
            "Sikhism",
            "Taoism",
            "Zoroastrianism"});
            this.Religion.Location = new System.Drawing.Point(438, 75);
            this.Religion.Name = "Religion";
            this.Religion.Size = new System.Drawing.Size(188, 24);
            this.Religion.TabIndex = 15;
            // 
            // Address
            // 
            this.Address.Location = new System.Drawing.Point(438, 197);
            this.Address.Name = "Address";
            this.Address.Size = new System.Drawing.Size(188, 22);
            this.Address.TabIndex = 17;
            // 
            // Nationality
            // 
            this.Nationality.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Nationality.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Nationality.FormattingEnabled = true;
            this.Nationality.Items.AddRange(new object[] {
            "Pakistani",
            "Afghan",
            "Indian",
            "Bangladeshi",
            "Chinese",
            "English",
            "American"});
            this.Nationality.Location = new System.Drawing.Point(438, 38);
            this.Nationality.Name = "Nationality";
            this.Nationality.Size = new System.Drawing.Size(188, 24);
            this.Nationality.TabIndex = 16;
            // 
            // MemberName
            // 
            this.MemberName.Location = new System.Drawing.Point(94, 41);
            this.MemberName.Name = "MemberName";
            this.MemberName.Size = new System.Drawing.Size(188, 22);
            this.MemberName.TabIndex = 16;
            this.MemberName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MemberName_KeyPress);
            // 
            // NIC
            // 
            this.NIC.Location = new System.Drawing.Point(94, 121);
            this.NIC.MaxLength = 13;
            this.NIC.Name = "NIC";
            this.NIC.Size = new System.Drawing.Size(188, 22);
            this.NIC.TabIndex = 14;
            this.NIC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NIC_KeyPress);
            // 
            // Contact
            // 
            this.Contact.Location = new System.Drawing.Point(94, 160);
            this.Contact.MaxLength = 11;
            this.Contact.Name = "Contact";
            this.Contact.Size = new System.Drawing.Size(188, 22);
            this.Contact.TabIndex = 15;
            this.Contact.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Contact_KeyPress);
            // 
            // Email
            // 
            this.Email.Location = new System.Drawing.Point(94, 80);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(188, 22);
            this.Email.TabIndex = 14;
            this.Email.Validating += new System.ComponentModel.CancelEventHandler(this.Email_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(326, 198);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(61, 16);
            this.label12.TabIndex = 11;
            this.label12.Text = "Address:";
            // 
            // TGuestsLabel
            // 
            this.TGuestsLabel.AutoSize = true;
            this.TGuestsLabel.Location = new System.Drawing.Point(326, 121);
            this.TGuestsLabel.Name = "TGuestsLabel";
            this.TGuestsLabel.Size = new System.Drawing.Size(82, 16);
            this.TGuestsLabel.TabIndex = 7;
            this.TGuestsLabel.Text = "Date of Birth:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Email:";
            // 
            // TAdultsLabel
            // 
            this.TAdultsLabel.AutoSize = true;
            this.TAdultsLabel.Location = new System.Drawing.Point(326, 83);
            this.TAdultsLabel.Name = "TAdultsLabel";
            this.TAdultsLabel.Size = new System.Drawing.Size(60, 16);
            this.TAdultsLabel.TabIndex = 9;
            this.TAdultsLabel.Text = "Religion:";
            // 
            // TChikdernLabel
            // 
            this.TChikdernLabel.AutoSize = true;
            this.TChikdernLabel.Location = new System.Drawing.Point(326, 44);
            this.TChikdernLabel.Name = "TChikdernLabel";
            this.TChikdernLabel.Size = new System.Drawing.Size(70, 16);
            this.TChikdernLabel.TabIndex = 10;
            this.TChikdernLabel.Text = "Nationaliy:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "NIC No.:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Contact:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 198);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Gender:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(235, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(330, 53);
            this.label1.TabIndex = 17;
            this.label1.Text = "Add Staff Member";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(326, 37);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 16);
            this.label9.TabIndex = 8;
            this.label9.Text = "Joining Date";
            // 
            // JoiningDate
            // 
            this.JoiningDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.JoiningDate.Location = new System.Drawing.Point(438, 32);
            this.JoiningDate.Name = "JoiningDate";
            this.JoiningDate.Size = new System.Drawing.Size(188, 22);
            this.JoiningDate.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 37);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "Type:";
            // 
            // EmploymentType
            // 
            this.EmploymentType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.EmploymentType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EmploymentType.FormattingEnabled = true;
            this.EmploymentType.Items.AddRange(new object[] {
            "Full-Time",
            "Part-Time",
            "Contigent",
            "Temporary"});
            this.EmploymentType.Location = new System.Drawing.Point(94, 31);
            this.EmploymentType.Name = "EmploymentType";
            this.EmploymentType.Size = new System.Drawing.Size(188, 24);
            this.EmploymentType.TabIndex = 13;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.EmploymentType);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.JoiningDate);
            this.groupBox2.Location = new System.Drawing.Point(64, 348);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(655, 68);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Employment Details";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.ForestGreen;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(288, 530);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(218, 32);
            this.button1.TabIndex = 20;
            this.button1.Text = "Add Staff Member";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Save_Click);
            // 
            // EmailError
            // 
            this.EmailError.ContainerControl = this;
            // 
            // addStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 574);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.Payment);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "addStaff";
            this.Text = "yy";
            this.Payment.ResumeLayout(false);
            this.Payment.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EmailError)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox Payment;
        private System.Windows.Forms.ComboBox WageMethod;
        private System.Windows.Forms.Label paymethod;
        private System.Windows.Forms.Label per;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox Gender;
        private System.Windows.Forms.TextBox Address;
        private System.Windows.Forms.TextBox MemberName;
        private System.Windows.Forms.TextBox NIC;
        private System.Windows.Forms.TextBox Contact;
        private System.Windows.Forms.TextBox Email;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox WageType;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox Qualification;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker DateOfBirth;
        private System.Windows.Forms.ComboBox Nationality;
        private System.Windows.Forms.ComboBox Religion;
        private System.Windows.Forms.ComboBox EmploymentType;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DateTimePicker JoiningDate;
        private System.Windows.Forms.Label TGuestsLabel;
        private System.Windows.Forms.Label TChikdernLabel;
        private System.Windows.Forms.Label TAdultsLabel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox SetWage;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ErrorProvider EmailError;
    }
}