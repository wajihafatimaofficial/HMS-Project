namespace HotelManagementSystem
{
    partial class NewReservation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewReservation));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.TGuestsLabel = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.TAdultsLabel = new System.Windows.Forms.Label();
            this.TChikdernLabel = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Gender = new System.Windows.Forms.ComboBox();
            this.Address = new System.Windows.Forms.TextBox();
            this.GuestName = new System.Windows.Forms.TextBox();
            this.NIC = new System.Windows.Forms.TextBox();
            this.Contact = new System.Windows.Forms.TextBox();
            this.Email = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.CheckInPeriod = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.CheckoutDate = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.TChildren = new System.Windows.Forms.ComboBox();
            this.TAdults = new System.Windows.Forms.ComboBox();
            this.TGuests = new System.Windows.Forms.ComboBox();
            this.RoomType = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.CheckInDate = new System.Windows.Forms.DateTimePicker();
            this.Save = new System.Windows.Forms.Button();
            this.Reset = new System.Windows.Forms.Button();
            this.Payment = new System.Windows.Forms.GroupBox();
            this.payment_method = new System.Windows.Forms.ComboBox();
            this.paymethod = new System.Windows.Forms.Label();
            this.amountRs = new System.Windows.Forms.Label();
            this.Amount = new System.Windows.Forms.Label();
            this.Nameerror = new System.Windows.Forms.ErrorProvider(this.components);
            this.contactError = new System.Windows.Forms.ErrorProvider(this.components);
            this.EmailError = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.Payment.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Nameerror)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmailError)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(207, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(342, 53);
            this.label1.TabIndex = 0;
            this.label1.Text = "Room Reservation";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Contact:";
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
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 198);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Gender:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 41);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "Room Type:";
            // 
            // TGuestsLabel
            // 
            this.TGuestsLabel.AutoSize = true;
            this.TGuestsLabel.Location = new System.Drawing.Point(6, 83);
            this.TGuestsLabel.Name = "TGuestsLabel";
            this.TGuestsLabel.Size = new System.Drawing.Size(86, 16);
            this.TGuestsLabel.TabIndex = 7;
            this.TGuestsLabel.Text = "Total Guests:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 198);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(87, 16);
            this.label9.TabIndex = 8;
            this.label9.Text = "CheckIn Date";
            // 
            // TAdultsLabel
            // 
            this.TAdultsLabel.AutoSize = true;
            this.TAdultsLabel.Location = new System.Drawing.Point(6, 121);
            this.TAdultsLabel.Name = "TAdultsLabel";
            this.TAdultsLabel.Size = new System.Drawing.Size(81, 16);
            this.TAdultsLabel.TabIndex = 9;
            this.TAdultsLabel.Text = "Total Adults:";
            // 
            // TChikdernLabel
            // 
            this.TChikdernLabel.AutoSize = true;
            this.TChikdernLabel.Location = new System.Drawing.Point(6, 160);
            this.TChikdernLabel.Name = "TChikdernLabel";
            this.TChikdernLabel.Size = new System.Drawing.Size(93, 16);
            this.TChikdernLabel.TabIndex = 10;
            this.TChikdernLabel.Text = "Total Children:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 243);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(61, 16);
            this.label12.TabIndex = 11;
            this.label12.Text = "Address:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Gender);
            this.groupBox1.Controls.Add(this.Address);
            this.groupBox1.Controls.Add(this.GuestName);
            this.groupBox1.Controls.Add(this.NIC);
            this.groupBox1.Controls.Add(this.Contact);
            this.groupBox1.Controls.Add(this.Email);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(52, 108);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(297, 281);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Personal Information";
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
            this.Gender.Location = new System.Drawing.Point(72, 195);
            this.Gender.Name = "Gender";
            this.Gender.Size = new System.Drawing.Size(188, 24);
            this.Gender.TabIndex = 18;
            // 
            // Address
            // 
            this.Address.Location = new System.Drawing.Point(72, 238);
            this.Address.Name = "Address";
            this.Address.Size = new System.Drawing.Size(188, 22);
            this.Address.TabIndex = 17;
            // 
            // GuestName
            // 
            this.GuestName.Location = new System.Drawing.Point(72, 41);
            this.GuestName.Name = "GuestName";
            this.GuestName.Size = new System.Drawing.Size(188, 22);
            this.GuestName.TabIndex = 16;
            this.GuestName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.GuestName_KeyPress);
            this.GuestName.Validating += new System.ComponentModel.CancelEventHandler(this.Name_validating);
            // 
            // NIC
            // 
            this.NIC.Location = new System.Drawing.Point(72, 121);
            this.NIC.MaxLength = 13;
            this.NIC.Name = "NIC";
            this.NIC.Size = new System.Drawing.Size(188, 22);
            this.NIC.TabIndex = 14;
            this.NIC.TextChanged += new System.EventHandler(this.NIC_TextChanged);
            this.NIC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NIC_KeyPress);
            this.NIC.Validating += new System.ComponentModel.CancelEventHandler(this.NIC_validating);
            // 
            // Contact
            // 
            this.Contact.Location = new System.Drawing.Point(72, 160);
            this.Contact.MaxLength = 11;
            this.Contact.Name = "Contact";
            this.Contact.Size = new System.Drawing.Size(188, 22);
            this.Contact.TabIndex = 15;
            this.Contact.TextChanged += new System.EventHandler(this.Contact_TextChanged);
            this.Contact.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Contact_KeyPress);
            this.Contact.Validating += new System.ComponentModel.CancelEventHandler(this.contac_Validating);
            // 
            // Email
            // 
            this.Email.Location = new System.Drawing.Point(72, 80);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(188, 22);
            this.Email.TabIndex = 14;
            this.Email.Validating += new System.ComponentModel.CancelEventHandler(this.Email_Validating);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.CheckInPeriod);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.CheckoutDate);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.TChildren);
            this.groupBox2.Controls.Add(this.TAdults);
            this.groupBox2.Controls.Add(this.TGuests);
            this.groupBox2.Controls.Add(this.RoomType);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.CheckInDate);
            this.groupBox2.Controls.Add(this.TGuestsLabel);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.TChikdernLabel);
            this.groupBox2.Controls.Add(this.TAdultsLabel);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Location = new System.Drawing.Point(372, 108);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(335, 318);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Rserervation Details";
            // 
            // CheckInPeriod
            // 
            this.CheckInPeriod.AutoSize = true;
            this.CheckInPeriod.Cursor = System.Windows.Forms.Cursors.Default;
            this.CheckInPeriod.ForeColor = System.Drawing.Color.Blue;
            this.CheckInPeriod.Location = new System.Drawing.Point(126, 280);
            this.CheckInPeriod.Name = "CheckInPeriod";
            this.CheckInPeriod.Size = new System.Drawing.Size(14, 16);
            this.CheckInPeriod.TabIndex = 19;
            this.CheckInPeriod.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(188, 280);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 16);
            this.label8.TabIndex = 18;
            this.label8.Text = "Day(s)";
            // 
            // CheckoutDate
            // 
            this.CheckoutDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.CheckoutDate.Location = new System.Drawing.Point(117, 238);
            this.CheckoutDate.Name = "CheckoutDate";
            this.CheckoutDate.Size = new System.Drawing.Size(182, 22);
            this.CheckoutDate.TabIndex = 12;
            this.CheckoutDate.Value = new System.DateTime(2021, 12, 8, 0, 0, 0, 0);
            this.CheckoutDate.ValueChanged += new System.EventHandler(this.CheckoutDate_ValueChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 238);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(95, 16);
            this.label10.TabIndex = 17;
            this.label10.Text = "Checkout Date";
            // 
            // TChildren
            // 
            this.TChildren.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TChildren.Enabled = false;
            this.TChildren.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TChildren.FormattingEnabled = true;
            this.TChildren.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.TChildren.Location = new System.Drawing.Point(117, 153);
            this.TChildren.Name = "TChildren";
            this.TChildren.Size = new System.Drawing.Size(182, 24);
            this.TChildren.TabIndex = 16;
            this.TChildren.SelectedIndexChanged += new System.EventHandler(this.TChildren_SelectedIndexChanged);
            this.TChildren.SelectedValueChanged += new System.EventHandler(this.TChildren_SelectedValueChanged);
            // 
            // TAdults
            // 
            this.TAdults.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TAdults.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TAdults.FormattingEnabled = true;
            this.TAdults.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.TAdults.Location = new System.Drawing.Point(117, 118);
            this.TAdults.Name = "TAdults";
            this.TAdults.Size = new System.Drawing.Size(182, 24);
            this.TAdults.TabIndex = 15;
            this.TAdults.SelectedIndexChanged += new System.EventHandler(this.TAdults_SelectedIndexChanged);
            // 
            // TGuests
            // 
            this.TGuests.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TGuests.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TGuests.FormattingEnabled = true;
            this.TGuests.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.TGuests.Location = new System.Drawing.Point(117, 80);
            this.TGuests.Name = "TGuests";
            this.TGuests.Size = new System.Drawing.Size(182, 24);
            this.TGuests.TabIndex = 14;
            // 
            // RoomType
            // 
            this.RoomType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.RoomType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RoomType.FormattingEnabled = true;
            this.RoomType.Items.AddRange(new object[] {
            "Single",
            "Double",
            "Triple",
            "Quad",
            "Queen",
            "King",
            "Twin",
            "Double-double"});
            this.RoomType.Location = new System.Drawing.Point(117, 38);
            this.RoomType.Name = "RoomType";
            this.RoomType.Size = new System.Drawing.Size(182, 24);
            this.RoomType.TabIndex = 13;
            this.RoomType.DropDown += new System.EventHandler(this.Roomype_Selected);
            this.RoomType.SelectedIndexChanged += new System.EventHandler(this.RoomType_SelectedIndexChanged);
            this.RoomType.SelectedValueChanged += new System.EventHandler(this.RoomType_SelectedValueChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 280);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(98, 16);
            this.label13.TabIndex = 11;
            this.label13.Text = "CheckIn Period";
            // 
            // CheckInDate
            // 
            this.CheckInDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.CheckInDate.Location = new System.Drawing.Point(117, 193);
            this.CheckInDate.Name = "CheckInDate";
            this.CheckInDate.Size = new System.Drawing.Size(182, 22);
            this.CheckInDate.TabIndex = 12;
            // 
            // Save
            // 
            this.Save.BackColor = System.Drawing.Color.ForestGreen;
            this.Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Save.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Save.Location = new System.Drawing.Point(601, 488);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(106, 32);
            this.Save.TabIndex = 14;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = false;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // Reset
            // 
            this.Reset.BackColor = System.Drawing.Color.Red;
            this.Reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Reset.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Reset.Location = new System.Drawing.Point(406, 488);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(106, 32);
            this.Reset.TabIndex = 15;
            this.Reset.Text = "Reset";
            this.Reset.UseVisualStyleBackColor = false;
            this.Reset.Click += new System.EventHandler(this.Reset_Click);
            // 
            // Payment
            // 
            this.Payment.Controls.Add(this.payment_method);
            this.Payment.Controls.Add(this.paymethod);
            this.Payment.Controls.Add(this.amountRs);
            this.Payment.Controls.Add(this.Amount);
            this.Payment.Location = new System.Drawing.Point(52, 415);
            this.Payment.Name = "Payment";
            this.Payment.Size = new System.Drawing.Size(297, 113);
            this.Payment.TabIndex = 16;
            this.Payment.TabStop = false;
            this.Payment.Text = "Payment Details";
            // 
            // payment_method
            // 
            this.payment_method.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.payment_method.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.payment_method.FormattingEnabled = true;
            this.payment_method.Items.AddRange(new object[] {
            "Cash",
            "Card"});
            this.payment_method.Location = new System.Drawing.Point(123, 44);
            this.payment_method.Name = "payment_method";
            this.payment_method.Size = new System.Drawing.Size(137, 24);
            this.payment_method.TabIndex = 17;
            // 
            // paymethod
            // 
            this.paymethod.AutoSize = true;
            this.paymethod.Location = new System.Drawing.Point(6, 47);
            this.paymethod.Name = "paymethod";
            this.paymethod.Size = new System.Drawing.Size(111, 16);
            this.paymethod.TabIndex = 14;
            this.paymethod.Text = "Payment Method:";
            // 
            // amountRs
            // 
            this.amountRs.AutoSize = true;
            this.amountRs.Cursor = System.Windows.Forms.Cursors.Default;
            this.amountRs.ForeColor = System.Drawing.Color.Blue;
            this.amountRs.Location = new System.Drawing.Point(120, 89);
            this.amountRs.Name = "amountRs";
            this.amountRs.Size = new System.Drawing.Size(14, 16);
            this.amountRs.TabIndex = 13;
            this.amountRs.Text = "0";
            // 
            // Amount
            // 
            this.Amount.AutoSize = true;
            this.Amount.Location = new System.Drawing.Point(59, 89);
            this.Amount.Name = "Amount";
            this.Amount.Size = new System.Drawing.Size(55, 16);
            this.Amount.TabIndex = 12;
            this.Amount.Text = "Amount:";
            // 
            // Nameerror
            // 
            this.Nameerror.ContainerControl = this;
            // 
            // contactError
            // 
            this.contactError.ContainerControl = this;
            // 
            // EmailError
            // 
            this.EmailError.ContainerControl = this;
            // 
            // NewReservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 574);
            this.Controls.Add(this.Payment);
            this.Controls.Add(this.Reset);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "NewReservation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New Reservation";
            this.Load += new System.EventHandler(this.NewReservation_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.Payment.ResumeLayout(false);
            this.Payment.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Nameerror)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmailError)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label TGuestsLabel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label TAdultsLabel;
        private System.Windows.Forms.Label TChikdernLabel;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox RoomType;
        private System.Windows.Forms.DateTimePicker CheckInDate;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox GuestName;
        private System.Windows.Forms.TextBox NIC;
        private System.Windows.Forms.TextBox Contact;
        private System.Windows.Forms.TextBox Email;
        private System.Windows.Forms.TextBox Address;
        private System.Windows.Forms.ComboBox Gender;
        private System.Windows.Forms.ComboBox TChildren;
        private System.Windows.Forms.ComboBox TAdults;
        private System.Windows.Forms.ComboBox TGuests;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Button Reset;
        private System.Windows.Forms.GroupBox Payment;
        private System.Windows.Forms.ComboBox payment_method;
        private System.Windows.Forms.Label paymethod;
        private System.Windows.Forms.Label amountRs;
        private System.Windows.Forms.Label Amount;
        private System.Windows.Forms.ErrorProvider Nameerror;
        private System.Windows.Forms.ErrorProvider contactError;
        private System.Windows.Forms.ErrorProvider EmailError;
        private System.Windows.Forms.DateTimePicker CheckoutDate;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label CheckInPeriod;
    }
}