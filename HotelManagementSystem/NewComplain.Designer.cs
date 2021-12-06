namespace HotelManagementSystem
{
    partial class NewComplain
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
            this.label1 = new System.Windows.Forms.Label();
            this.complainerInfo = new System.Windows.Forms.GroupBox();
            this.ComplainSubject = new System.Windows.Forms.ComboBox();
            this.ComplainerName = new System.Windows.Forms.TextBox();
            this.Contact = new System.Windows.Forms.TextBox();
            this.ComplainDetails = new System.Windows.Forms.TextBox();
            this.Email = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.ComplainDate = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Reset = new System.Windows.Forms.Button();
            this.Save = new System.Windows.Forms.Button();
            this.ContactError = new System.Windows.Forms.ErrorProvider(this.components);
            this.EmailError = new System.Windows.Forms.ErrorProvider(this.components);
            this.complainerInfo.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ContactError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmailError)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(268, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(271, 53);
            this.label1.TabIndex = 1;
            this.label1.Text = "New Complain";
            // 
            // complainerInfo
            // 
            this.complainerInfo.Controls.Add(this.ComplainerName);
            this.complainerInfo.Controls.Add(this.Contact);
            this.complainerInfo.Controls.Add(this.Email);
            this.complainerInfo.Controls.Add(this.label2);
            this.complainerInfo.Controls.Add(this.label3);
            this.complainerInfo.Controls.Add(this.label4);
            this.complainerInfo.Location = new System.Drawing.Point(45, 129);
            this.complainerInfo.Name = "complainerInfo";
            this.complainerInfo.Size = new System.Drawing.Size(672, 129);
            this.complainerInfo.TabIndex = 13;
            this.complainerInfo.TabStop = false;
            this.complainerInfo.Text = "Complainer\'s Information";
            // 
            // ComplainSubject
            // 
            this.ComplainSubject.DisplayMember = "Select Gender";
            this.ComplainSubject.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComplainSubject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ComplainSubject.Items.AddRange(new object[] {
            "Wifi",
            "Food",
            "Booking",
            "Comfort",
            "Reception",
            "Room Service",
            "Staff (Attitude)",
            "Staff (Service)",
            "Response Time",
            "Facilities/Amenities"});
            this.ComplainSubject.Location = new System.Drawing.Point(435, 46);
            this.ComplainSubject.Name = "ComplainSubject";
            this.ComplainSubject.Size = new System.Drawing.Size(188, 24);
            this.ComplainSubject.TabIndex = 18;
            // 
            // ComplainerName
            // 
            this.ComplainerName.Location = new System.Drawing.Point(72, 35);
            this.ComplainerName.Name = "ComplainerName";
            this.ComplainerName.Size = new System.Drawing.Size(188, 22);
            this.ComplainerName.TabIndex = 16;
            this.ComplainerName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ComplainerName_KeyPress);
            // 
            // Contact
            // 
            this.Contact.Location = new System.Drawing.Point(72, 86);
            this.Contact.MaxLength = 11;
            this.Contact.Name = "Contact";
            this.Contact.Size = new System.Drawing.Size(188, 22);
            this.Contact.TabIndex = 14;
            this.Contact.TextChanged += new System.EventHandler(this.Contact_TextChanged);
            this.Contact.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Contact_KeyPress);
            this.Contact.Validating += new System.ComponentModel.CancelEventHandler(this.Contact_Validating);
            // 
            // ComplainDetails
            // 
            this.ComplainDetails.Location = new System.Drawing.Point(72, 100);
            this.ComplainDetails.MaxLength = 200;
            this.ComplainDetails.Multiline = true;
            this.ComplainDetails.Name = "ComplainDetails";
            this.ComplainDetails.Size = new System.Drawing.Size(551, 76);
            this.ComplainDetails.TabIndex = 15;
            // 
            // Email
            // 
            this.Email.Location = new System.Drawing.Point(435, 38);
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(372, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Email:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Contact:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Date:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(372, 53);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(55, 16);
            this.label12.TabIndex = 11;
            this.label12.Text = "Subject:";
            // 
            // ComplainDate
            // 
            this.ComplainDate.Location = new System.Drawing.Point(72, 48);
            this.ComplainDate.Name = "ComplainDate";
            this.ComplainDate.Size = new System.Drawing.Size(188, 22);
            this.ComplainDate.TabIndex = 19;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.ComplainDate);
            this.groupBox1.Controls.Add(this.ComplainDetails);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.ComplainSubject);
            this.groupBox1.Location = new System.Drawing.Point(45, 279);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(672, 198);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Complain Details";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 16);
            this.label5.TabIndex = 20;
            this.label5.Text = "Details:";
            // 
            // Reset
            // 
            this.Reset.BackColor = System.Drawing.Color.Red;
            this.Reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Reset.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Reset.Location = new System.Drawing.Point(258, 500);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(106, 32);
            this.Reset.TabIndex = 21;
            this.Reset.Text = "Reset";
            this.Reset.UseVisualStyleBackColor = false;
            this.Reset.Click += new System.EventHandler(this.Reset_Click);
            // 
            // Save
            // 
            this.Save.BackColor = System.Drawing.Color.ForestGreen;
            this.Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Save.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Save.Location = new System.Drawing.Point(403, 500);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(106, 32);
            this.Save.TabIndex = 22;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = false;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // ContactError
            // 
            this.ContactError.ContainerControl = this;
            // 
            // EmailError
            // 
            this.EmailError.ContainerControl = this;
            // 
            // NewComplain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 553);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.Reset);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.complainerInfo);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NewComplain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NewComplain";
            this.complainerInfo.ResumeLayout(false);
            this.complainerInfo.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ContactError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmailError)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox complainerInfo;
        private System.Windows.Forms.ComboBox ComplainSubject;
        private System.Windows.Forms.TextBox ComplainerName;
        private System.Windows.Forms.TextBox Contact;
        private System.Windows.Forms.TextBox ComplainDetails;
        private System.Windows.Forms.TextBox Email;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker ComplainDate;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Reset;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.ErrorProvider ContactError;
        private System.Windows.Forms.ErrorProvider EmailError;
    }
}