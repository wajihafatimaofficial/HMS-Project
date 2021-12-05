namespace HotelManagementSystem
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Checkouts = new System.Windows.Forms.Button();
            this.Staff = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Complaints_Feedback = new System.Windows.Forms.Button();
            this.ReservationManagement = new System.Windows.Forms.Button();
            this.mainpanel = new System.Windows.Forms.Panel();
            this.Welcomelabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.mainpanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.Checkouts);
            this.panel1.Controls.Add(this.Staff);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.Complaints_Feedback);
            this.panel1.Controls.Add(this.ReservationManagement);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 569);
            this.panel1.TabIndex = 0;
            // 
            // Checkouts
            // 
            this.Checkouts.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Checkouts.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Checkouts.FlatAppearance.BorderSize = 0;
            this.Checkouts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Checkouts.ForeColor = System.Drawing.Color.White;
            this.Checkouts.Location = new System.Drawing.Point(12, 305);
            this.Checkouts.Name = "Checkouts";
            this.Checkouts.Size = new System.Drawing.Size(100, 29);
            this.Checkouts.TabIndex = 6;
            this.Checkouts.Text = "Checkouts";
            this.Checkouts.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Checkouts.UseVisualStyleBackColor = false;
            // 
            // Staff
            // 
            this.Staff.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Staff.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Staff.FlatAppearance.BorderSize = 0;
            this.Staff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Staff.ForeColor = System.Drawing.Color.White;
            this.Staff.Location = new System.Drawing.Point(12, 181);
            this.Staff.Name = "Staff";
            this.Staff.Size = new System.Drawing.Size(100, 29);
            this.Staff.TabIndex = 5;
            this.Staff.Text = "Staff";
            this.Staff.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Staff.UseVisualStyleBackColor = false;
            this.Staff.Click += new System.EventHandler(this.Staff_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::HotelManagementSystem.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(0, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 102);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // Complaints_Feedback
            // 
            this.Complaints_Feedback.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Complaints_Feedback.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Complaints_Feedback.FlatAppearance.BorderSize = 0;
            this.Complaints_Feedback.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Complaints_Feedback.ForeColor = System.Drawing.Color.White;
            this.Complaints_Feedback.Location = new System.Drawing.Point(12, 376);
            this.Complaints_Feedback.Name = "Complaints_Feedback";
            this.Complaints_Feedback.Size = new System.Drawing.Size(158, 29);
            this.Complaints_Feedback.TabIndex = 2;
            this.Complaints_Feedback.Text = "Complaints/Feedbacks";
            this.Complaints_Feedback.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Complaints_Feedback.UseVisualStyleBackColor = false;
            this.Complaints_Feedback.Click += new System.EventHandler(this.Complaints_Feedback_Click);
            // 
            // ReservationManagement
            // 
            this.ReservationManagement.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ReservationManagement.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.ReservationManagement.FlatAppearance.BorderSize = 0;
            this.ReservationManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ReservationManagement.ForeColor = System.Drawing.Color.White;
            this.ReservationManagement.Location = new System.Drawing.Point(12, 241);
            this.ReservationManagement.Name = "ReservationManagement";
            this.ReservationManagement.Size = new System.Drawing.Size(141, 29);
            this.ReservationManagement.TabIndex = 0;
            this.ReservationManagement.Text = "Reservations";
            this.ReservationManagement.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ReservationManagement.UseVisualStyleBackColor = false;
            this.ReservationManagement.Click += new System.EventHandler(this.Button1_Click);
            // 
            // mainpanel
            // 
            this.mainpanel.BackColor = System.Drawing.Color.White;
            this.mainpanel.Controls.Add(this.Welcomelabel);
            this.mainpanel.Location = new System.Drawing.Point(196, 0);
            this.mainpanel.Name = "mainpanel";
            this.mainpanel.Size = new System.Drawing.Size(800, 569);
            this.mainpanel.TabIndex = 1;
            // 
            // Welcomelabel
            // 
            this.Welcomelabel.AutoSize = true;
            this.Welcomelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Welcomelabel.Location = new System.Drawing.Point(268, 241);
            this.Welcomelabel.Name = "Welcomelabel";
            this.Welcomelabel.Size = new System.Drawing.Size(239, 54);
            this.Welcomelabel.TabIndex = 0;
            this.Welcomelabel.Text = "Welcome!";
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1001, 570);
            this.Controls.Add(this.mainpanel);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "THE HALCYON";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.mainpanel.ResumeLayout(false);
            this.mainpanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel mainpanel;
        private System.Windows.Forms.Button ReservationManagement;
        private System.Windows.Forms.Button Complaints_Feedback;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Staff;
        private System.Windows.Forms.Button Checkouts;
        private System.Windows.Forms.Label Welcomelabel;
    }
}