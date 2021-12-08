namespace HotelManagementSystem
{
    partial class Staff
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.CheckAvalibility = new System.Windows.Forms.Button();
            this.RemoveMember = new System.Windows.Forms.Button();
            this.View_Staff = new System.Windows.Forms.Button();
            this.new_member = new System.Windows.Forms.Button();
            this.reservation_panel = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.Controls.Add(this.CheckAvalibility);
            this.panel1.Controls.Add(this.RemoveMember);
            this.panel1.Controls.Add(this.View_Staff);
            this.panel1.Controls.Add(this.new_member);
            this.panel1.Location = new System.Drawing.Point(-3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(876, 46);
            this.panel1.TabIndex = 1;
            // 
            // CheckAvalibility
            // 
            this.CheckAvalibility.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.CheckAvalibility.FlatAppearance.BorderSize = 0;
            this.CheckAvalibility.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CheckAvalibility.Location = new System.Drawing.Point(487, 3);
            this.CheckAvalibility.Name = "CheckAvalibility";
            this.CheckAvalibility.Size = new System.Drawing.Size(243, 43);
            this.CheckAvalibility.TabIndex = 3;
            this.CheckAvalibility.Text = "Search Member Details";
            this.CheckAvalibility.UseVisualStyleBackColor = true;
            this.CheckAvalibility.Click += new System.EventHandler(this.CheckAvalibility_Click);
            // 
            // RemoveMember
            // 
            this.RemoveMember.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.RemoveMember.FlatAppearance.BorderSize = 0;
            this.RemoveMember.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RemoveMember.Location = new System.Drawing.Point(151, 3);
            this.RemoveMember.Name = "RemoveMember";
            this.RemoveMember.Size = new System.Drawing.Size(162, 43);
            this.RemoveMember.TabIndex = 1;
            this.RemoveMember.Text = "Remove Member";
            this.RemoveMember.UseVisualStyleBackColor = true;
            this.RemoveMember.Click += new System.EventHandler(this.RemoveMember_Click);
            // 
            // View_Staff
            // 
            this.View_Staff.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.View_Staff.FlatAppearance.BorderSize = 0;
            this.View_Staff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.View_Staff.Location = new System.Drawing.Point(319, 3);
            this.View_Staff.Name = "View_Staff";
            this.View_Staff.Size = new System.Drawing.Size(162, 43);
            this.View_Staff.TabIndex = 1;
            this.View_Staff.Text = "View Staff Details";
            this.View_Staff.UseVisualStyleBackColor = true;
            this.View_Staff.Click += new System.EventHandler(this.View_Staff_Click);
            // 
            // new_member
            // 
            this.new_member.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.new_member.FlatAppearance.BorderSize = 0;
            this.new_member.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.new_member.Location = new System.Drawing.Point(3, 3);
            this.new_member.Name = "new_member";
            this.new_member.Size = new System.Drawing.Size(162, 43);
            this.new_member.TabIndex = 0;
            this.new_member.Text = "Add New Member";
            this.new_member.UseVisualStyleBackColor = true;
            this.new_member.Click += new System.EventHandler(this.new_member_Click);
            // 
            // reservation_panel
            // 
            this.reservation_panel.BackColor = System.Drawing.Color.White;
            this.reservation_panel.BackgroundImage = global::HotelManagementSystem.Properties.Resources.staff;
            this.reservation_panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.reservation_panel.Location = new System.Drawing.Point(0, 32);
            this.reservation_panel.Name = "reservation_panel";
            this.reservation_panel.Size = new System.Drawing.Size(782, 579);
            this.reservation_panel.TabIndex = 2;
            // 
            // Staff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 616);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.reservation_panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Staff";
            this.Text = "Staff";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel reservation_panel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button CheckAvalibility;
        private System.Windows.Forms.Button RemoveMember;
        private System.Windows.Forms.Button View_Staff;
        private System.Windows.Forms.Button new_member;
    }
}