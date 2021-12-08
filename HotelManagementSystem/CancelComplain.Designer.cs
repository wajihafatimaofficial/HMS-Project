namespace HotelManagementSystem
{
    partial class CancelComplain
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SearchComplaints = new System.Windows.Forms.Button();
            this.Reset = new System.Windows.Forms.Button();
            this.Complaintid = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.DelComplaints = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.NameData = new System.Windows.Forms.TextBox();
            this.EmailData = new System.Windows.Forms.TextBox();
            this.ContactData = new System.Windows.Forms.TextBox();
            this.SubjectData = new System.Windows.Forms.TextBox();
            this.StatusData = new System.Windows.Forms.TextBox();
            this.DatedData = new System.Windows.Forms.TextBox();
            this.DetailsData = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(223, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(353, 53);
            this.label1.TabIndex = 20;
            this.label1.Text = "Cancel Complaints";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.SearchComplaints);
            this.groupBox1.Controls.Add(this.Reset);
            this.groupBox1.Controls.Add(this.Complaintid);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(123, 123);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(552, 102);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search for Reservation";
            // 
            // SearchComplaints
            // 
            this.SearchComplaints.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.SearchComplaints.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchComplaints.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.SearchComplaints.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.SearchComplaints.Location = new System.Drawing.Point(280, 41);
            this.SearchComplaints.Name = "SearchComplaints";
            this.SearchComplaints.Size = new System.Drawing.Size(106, 32);
            this.SearchComplaints.TabIndex = 18;
            this.SearchComplaints.Text = "Search";
            this.SearchComplaints.UseVisualStyleBackColor = false;
            this.SearchComplaints.Click += new System.EventHandler(this.SearchComplaints_Click);
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
            // Complaintid
            // 
            this.Complaintid.Location = new System.Drawing.Point(95, 46);
            this.Complaintid.Name = "Complaintid";
            this.Complaintid.Size = new System.Drawing.Size(168, 22);
            this.Complaintid.TabIndex = 19;
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.DetailsData);
            this.groupBox2.Controls.Add(this.DatedData);
            this.groupBox2.Controls.Add(this.StatusData);
            this.groupBox2.Controls.Add(this.SubjectData);
            this.groupBox2.Controls.Add(this.ContactData);
            this.groupBox2.Controls.Add(this.EmailData);
            this.groupBox2.Controls.Add(this.NameData);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.DelComplaints);
            this.groupBox2.Location = new System.Drawing.Point(47, 260);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(720, 302);
            this.groupBox2.TabIndex = 54;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Complaint Details";
            // 
            // DelComplaints
            // 
            this.DelComplaints.BackColor = System.Drawing.Color.Red;
            this.DelComplaints.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DelComplaints.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DelComplaints.Location = new System.Drawing.Point(524, 264);
            this.DelComplaints.Name = "DelComplaints";
            this.DelComplaints.Size = new System.Drawing.Size(157, 32);
            this.DelComplaints.TabIndex = 51;
            this.DelComplaints.Text = "DELETE";
            this.DelComplaints.UseVisualStyleBackColor = false;
            this.DelComplaints.Visible = false;
            this.DelComplaints.Click += new System.EventHandler(this.DelComplaints_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(36, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 22);
            this.label3.TabIndex = 52;
            this.label3.Text = "Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(254, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 22);
            this.label4.TabIndex = 53;
            this.label4.Text = "Email:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(36, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 22);
            this.label5.TabIndex = 54;
            this.label5.Text = "Contact:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(254, 109);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 22);
            this.label6.TabIndex = 55;
            this.label6.Text = "Subject:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(36, 165);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 22);
            this.label7.TabIndex = 56;
            this.label7.Text = "Details:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(476, 55);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(52, 22);
            this.label14.TabIndex = 57;
            this.label14.Text = "Dated:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(476, 109);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 22);
            this.label8.TabIndex = 58;
            this.label8.Text = "Status:";
            // 
            // NameData
            // 
            this.NameData.Enabled = false;
            this.NameData.Location = new System.Drawing.Point(96, 57);
            this.NameData.Name = "NameData";
            this.NameData.Size = new System.Drawing.Size(146, 22);
            this.NameData.TabIndex = 59;
            // 
            // EmailData
            // 
            this.EmailData.Enabled = false;
            this.EmailData.Location = new System.Drawing.Point(311, 57);
            this.EmailData.Name = "EmailData";
            this.EmailData.Size = new System.Drawing.Size(146, 22);
            this.EmailData.TabIndex = 60;
            // 
            // ContactData
            // 
            this.ContactData.Enabled = false;
            this.ContactData.Location = new System.Drawing.Point(96, 111);
            this.ContactData.Name = "ContactData";
            this.ContactData.Size = new System.Drawing.Size(146, 22);
            this.ContactData.TabIndex = 61;
            // 
            // SubjectData
            // 
            this.SubjectData.Enabled = false;
            this.SubjectData.Location = new System.Drawing.Point(311, 111);
            this.SubjectData.Name = "SubjectData";
            this.SubjectData.Size = new System.Drawing.Size(146, 22);
            this.SubjectData.TabIndex = 62;
            // 
            // StatusData
            // 
            this.StatusData.Enabled = false;
            this.StatusData.Location = new System.Drawing.Point(535, 109);
            this.StatusData.Name = "StatusData";
            this.StatusData.Size = new System.Drawing.Size(146, 22);
            this.StatusData.TabIndex = 63;
            // 
            // DatedData
            // 
            this.DatedData.Enabled = false;
            this.DatedData.Location = new System.Drawing.Point(535, 57);
            this.DatedData.Name = "DatedData";
            this.DatedData.Size = new System.Drawing.Size(146, 22);
            this.DatedData.TabIndex = 64;
            // 
            // DetailsData
            // 
            this.DetailsData.Location = new System.Drawing.Point(96, 165);
            this.DetailsData.MaxLength = 200;
            this.DetailsData.Multiline = true;
            this.DetailsData.Name = "DetailsData";
            this.DetailsData.Size = new System.Drawing.Size(585, 59);
            this.DetailsData.TabIndex = 55;
            // 
            // CancelComplain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 574);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CancelComplain";
            this.Text = "CancelComplain";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button SearchComplaints;
        private System.Windows.Forms.Button Reset;
        private System.Windows.Forms.TextBox Complaintid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button DelComplaints;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox DatedData;
        private System.Windows.Forms.TextBox StatusData;
        private System.Windows.Forms.TextBox SubjectData;
        private System.Windows.Forms.TextBox ContactData;
        private System.Windows.Forms.TextBox EmailData;
        private System.Windows.Forms.TextBox NameData;
        private System.Windows.Forms.TextBox DetailsData;
    }
}