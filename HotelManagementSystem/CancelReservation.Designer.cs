namespace HotelManagementSystem
{
    partial class CancelReservations
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
            this.label2 = new System.Windows.Forms.Label();
            this.SearchReservation = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Reset = new System.Windows.Forms.Button();
            this.reservationid = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.NameData = new System.Windows.Forms.TextBox();
            this.EmailData = new System.Windows.Forms.TextBox();
            this.NICData = new System.Windows.Forms.TextBox();
            this.ContactData = new System.Windows.Forms.TextBox();
            this.AddressData = new System.Windows.Forms.TextBox();
            this.TGuestsData = new System.Windows.Forms.TextBox();
            this.GenderData = new System.Windows.Forms.TextBox();
            this.RoomTypeData = new System.Windows.Forms.TextBox();
            this.TChildrenData = new System.Windows.Forms.TextBox();
            this.ChecinPeriodData = new System.Windows.Forms.TextBox();
            this.CheckinDateData = new System.Windows.Forms.TextBox();
            this.PayMethodData = new System.Windows.Forms.TextBox();
            this.TAdultsData = new System.Windows.Forms.TextBox();
            this.PayAmountData = new System.Windows.Forms.TextBox();
            this.CheckoutDateData = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.RoomNoData = new System.Windows.Forms.TextBox();
            this.DelReservation = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(215, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(364, 53);
            this.label1.TabIndex = 2;
            this.label1.Text = "Cancel Reservation";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "Enter ID:";
            // 
            // SearchReservation
            // 
            this.SearchReservation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.SearchReservation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchReservation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.SearchReservation.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.SearchReservation.Location = new System.Drawing.Point(280, 41);
            this.SearchReservation.Name = "SearchReservation";
            this.SearchReservation.Size = new System.Drawing.Size(106, 32);
            this.SearchReservation.TabIndex = 18;
            this.SearchReservation.Text = "Search";
            this.SearchReservation.UseVisualStyleBackColor = false;
            this.SearchReservation.Click += new System.EventHandler(this.SearchReservation_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.SearchReservation);
            this.groupBox1.Controls.Add(this.Reset);
            this.groupBox1.Controls.Add(this.reservationid);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(115, 105);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(552, 102);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search for Reservation";
            // 
            // Reset
            // 
            this.Reset.BackColor = System.Drawing.Color.Red;
            this.Reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Reset.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Reset.Location = new System.Drawing.Point(392, 41);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(106, 32);
            this.Reset.TabIndex = 20;
            this.Reset.Text = "Reset";
            this.Reset.UseVisualStyleBackColor = false;
            this.Reset.Click += new System.EventHandler(this.Reset_Click);
            // 
            // reservationid
            // 
            this.reservationid.Location = new System.Drawing.Point(95, 46);
            this.reservationid.Name = "reservationid";
            this.reservationid.Size = new System.Drawing.Size(168, 22);
            this.reservationid.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(49, 292);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 22);
            this.label3.TabIndex = 21;
            this.label3.Text = "Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(49, 332);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 22);
            this.label4.TabIndex = 22;
            this.label4.Text = "Email:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(287, 294);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 22);
            this.label5.TabIndex = 23;
            this.label5.Text = "Contact:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(49, 373);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 22);
            this.label6.TabIndex = 24;
            this.label6.Text = "Gender:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(517, 292);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 22);
            this.label7.TabIndex = 25;
            this.label7.Text = "NIC:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(287, 332);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 22);
            this.label8.TabIndex = 26;
            this.label8.Text = "Address:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(287, 417);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 22);
            this.label9.TabIndex = 27;
            this.label9.Text = "Total Adults:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(287, 371);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(90, 22);
            this.label10.TabIndex = 27;
            this.label10.Text = "Room Type:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(49, 415);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(93, 22);
            this.label11.TabIndex = 28;
            this.label11.Text = "Total Guests:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(517, 417);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(103, 22);
            this.label12.TabIndex = 29;
            this.label12.Text = "Total Children:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(517, 461);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(112, 22);
            this.label13.TabIndex = 30;
            this.label13.Text = "Checkin Period:";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(49, 457);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(100, 22);
            this.label14.TabIndex = 31;
            this.label14.Text = "Checkin Date:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(49, 501);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(123, 22);
            this.label15.TabIndex = 32;
            this.label15.Text = "Payment Method:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(287, 501);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(125, 22);
            this.label16.TabIndex = 33;
            this.label16.Text = "Payment Amount:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(287, 461);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(108, 22);
            this.label17.TabIndex = 34;
            this.label17.Text = "Checkout Date:";
            // 
            // NameData
            // 
            this.NameData.Enabled = false;
            this.NameData.Location = new System.Drawing.Point(127, 294);
            this.NameData.Name = "NameData";
            this.NameData.Size = new System.Drawing.Size(146, 22);
            this.NameData.TabIndex = 21;
            // 
            // EmailData
            // 
            this.EmailData.Enabled = false;
            this.EmailData.Location = new System.Drawing.Point(124, 334);
            this.EmailData.Name = "EmailData";
            this.EmailData.Size = new System.Drawing.Size(146, 22);
            this.EmailData.TabIndex = 35;
            // 
            // NICData
            // 
            this.NICData.Enabled = false;
            this.NICData.Location = new System.Drawing.Point(562, 292);
            this.NICData.Name = "NICData";
            this.NICData.Size = new System.Drawing.Size(163, 22);
            this.NICData.TabIndex = 36;
            // 
            // ContactData
            // 
            this.ContactData.Enabled = false;
            this.ContactData.Location = new System.Drawing.Point(369, 294);
            this.ContactData.Name = "ContactData";
            this.ContactData.Size = new System.Drawing.Size(132, 22);
            this.ContactData.TabIndex = 37;
            // 
            // AddressData
            // 
            this.AddressData.Enabled = false;
            this.AddressData.Location = new System.Drawing.Point(369, 332);
            this.AddressData.Name = "AddressData";
            this.AddressData.Size = new System.Drawing.Size(356, 22);
            this.AddressData.TabIndex = 38;
            // 
            // TGuestsData
            // 
            this.TGuestsData.Enabled = false;
            this.TGuestsData.Location = new System.Drawing.Point(161, 419);
            this.TGuestsData.Name = "TGuestsData";
            this.TGuestsData.Size = new System.Drawing.Size(109, 22);
            this.TGuestsData.TabIndex = 39;
            // 
            // GenderData
            // 
            this.GenderData.Enabled = false;
            this.GenderData.Location = new System.Drawing.Point(134, 373);
            this.GenderData.Name = "GenderData";
            this.GenderData.Size = new System.Drawing.Size(136, 22);
            this.GenderData.TabIndex = 40;
            // 
            // RoomTypeData
            // 
            this.RoomTypeData.Enabled = false;
            this.RoomTypeData.Location = new System.Drawing.Point(383, 371);
            this.RoomTypeData.Name = "RoomTypeData";
            this.RoomTypeData.Size = new System.Drawing.Size(131, 22);
            this.RoomTypeData.TabIndex = 41;
            // 
            // TChildrenData
            // 
            this.TChildrenData.Enabled = false;
            this.TChildrenData.Location = new System.Drawing.Point(640, 417);
            this.TChildrenData.Name = "TChildrenData";
            this.TChildrenData.Size = new System.Drawing.Size(85, 22);
            this.TChildrenData.TabIndex = 42;
            // 
            // ChecinPeriodData
            // 
            this.ChecinPeriodData.Enabled = false;
            this.ChecinPeriodData.Location = new System.Drawing.Point(640, 463);
            this.ChecinPeriodData.Name = "ChecinPeriodData";
            this.ChecinPeriodData.Size = new System.Drawing.Size(85, 22);
            this.ChecinPeriodData.TabIndex = 43;
            // 
            // CheckinDateData
            // 
            this.CheckinDateData.Enabled = false;
            this.CheckinDateData.Location = new System.Drawing.Point(178, 459);
            this.CheckinDateData.Name = "CheckinDateData";
            this.CheckinDateData.Size = new System.Drawing.Size(95, 22);
            this.CheckinDateData.TabIndex = 44;
            // 
            // PayMethodData
            // 
            this.PayMethodData.Enabled = false;
            this.PayMethodData.Location = new System.Drawing.Point(178, 501);
            this.PayMethodData.Name = "PayMethodData";
            this.PayMethodData.Size = new System.Drawing.Size(95, 22);
            this.PayMethodData.TabIndex = 45;
            // 
            // TAdultsData
            // 
            this.TAdultsData.Enabled = false;
            this.TAdultsData.Location = new System.Drawing.Point(401, 415);
            this.TAdultsData.Name = "TAdultsData";
            this.TAdultsData.Size = new System.Drawing.Size(110, 22);
            this.TAdultsData.TabIndex = 46;
            // 
            // PayAmountData
            // 
            this.PayAmountData.Enabled = false;
            this.PayAmountData.Location = new System.Drawing.Point(437, 503);
            this.PayAmountData.Name = "PayAmountData";
            this.PayAmountData.Size = new System.Drawing.Size(77, 22);
            this.PayAmountData.TabIndex = 47;
            // 
            // CheckoutDateData
            // 
            this.CheckoutDateData.Enabled = false;
            this.CheckoutDateData.Location = new System.Drawing.Point(414, 461);
            this.CheckoutDateData.Name = "CheckoutDateData";
            this.CheckoutDateData.Size = new System.Drawing.Size(97, 22);
            this.CheckoutDateData.TabIndex = 48;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(517, 373);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(101, 22);
            this.label18.TabIndex = 49;
            this.label18.Text = "Room Alloted:";
            // 
            // RoomNoData
            // 
            this.RoomNoData.Enabled = false;
            this.RoomNoData.Location = new System.Drawing.Point(640, 371);
            this.RoomNoData.Name = "RoomNoData";
            this.RoomNoData.Size = new System.Drawing.Size(85, 22);
            this.RoomNoData.TabIndex = 50;
            // 
            // DelReservation
            // 
            this.DelReservation.BackColor = System.Drawing.Color.Red;
            this.DelReservation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DelReservation.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DelReservation.Location = new System.Drawing.Point(537, 253);
            this.DelReservation.Name = "DelReservation";
            this.DelReservation.Size = new System.Drawing.Size(157, 32);
            this.DelReservation.TabIndex = 51;
            this.DelReservation.Text = "DELETE";
            this.DelReservation.UseVisualStyleBackColor = false;
            this.DelReservation.Visible = false;
            this.DelReservation.Click += new System.EventHandler(this.DelReservation_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.DelReservation);
            this.groupBox2.Location = new System.Drawing.Point(31, 248);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(720, 302);
            this.groupBox2.TabIndex = 53;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Reservation Details";
            // 
            // CancelReservations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 574);
            this.Controls.Add(this.RoomNoData);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.CheckoutDateData);
            this.Controls.Add(this.PayAmountData);
            this.Controls.Add(this.TAdultsData);
            this.Controls.Add(this.PayMethodData);
            this.Controls.Add(this.CheckinDateData);
            this.Controls.Add(this.ChecinPeriodData);
            this.Controls.Add(this.TChildrenData);
            this.Controls.Add(this.RoomTypeData);
            this.Controls.Add(this.GenderData);
            this.Controls.Add(this.TGuestsData);
            this.Controls.Add(this.AddressData);
            this.Controls.Add(this.ContactData);
            this.Controls.Add(this.NICData);
            this.Controls.Add(this.EmailData);
            this.Controls.Add(this.NameData);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CancelReservations";
            this.Text = "5";
            this.Load += new System.EventHandler(this.EditReservation_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button SearchReservation;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox reservationid;
        private System.Windows.Forms.Button Reset;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox NameData;
        private System.Windows.Forms.TextBox EmailData;
        private System.Windows.Forms.TextBox NICData;
        private System.Windows.Forms.TextBox ContactData;
        private System.Windows.Forms.TextBox AddressData;
        private System.Windows.Forms.TextBox TGuestsData;
        private System.Windows.Forms.TextBox GenderData;
        private System.Windows.Forms.TextBox RoomTypeData;
        private System.Windows.Forms.TextBox TChildrenData;
        private System.Windows.Forms.TextBox ChecinPeriodData;
        private System.Windows.Forms.TextBox CheckinDateData;
        private System.Windows.Forms.TextBox PayMethodData;
        private System.Windows.Forms.TextBox TAdultsData;
        private System.Windows.Forms.TextBox PayAmountData;
        private System.Windows.Forms.TextBox CheckoutDateData;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox RoomNoData;
        private System.Windows.Forms.Button DelReservation;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}