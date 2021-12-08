namespace HotelManagementSystem
{
    partial class Complains
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
            this.viewpolicy = new System.Windows.Forms.Button();
            this.CancelComplain = new System.Windows.Forms.Button();
            this.View_Complains = new System.Windows.Forms.Button();
            this.new_complain = new System.Windows.Forms.Button();
            this.complain_panel = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.Controls.Add(this.viewpolicy);
            this.panel1.Controls.Add(this.CancelComplain);
            this.panel1.Controls.Add(this.View_Complains);
            this.panel1.Controls.Add(this.new_complain);
            this.panel1.Location = new System.Drawing.Point(-9, -4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(880, 50);
            this.panel1.TabIndex = 1;
            // 
            // viewpolicy
            // 
            this.viewpolicy.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.viewpolicy.FlatAppearance.BorderSize = 0;
            this.viewpolicy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.viewpolicy.Location = new System.Drawing.Point(493, 4);
            this.viewpolicy.Name = "viewpolicy";
            this.viewpolicy.Size = new System.Drawing.Size(162, 43);
            this.viewpolicy.TabIndex = 2;
            this.viewpolicy.Text = "View Policy";
            this.viewpolicy.UseVisualStyleBackColor = true;
            // 
            // CancelComplain
            // 
            this.CancelComplain.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.CancelComplain.FlatAppearance.BorderSize = 0;
            this.CancelComplain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelComplain.Location = new System.Drawing.Point(171, 3);
            this.CancelComplain.Name = "CancelComplain";
            this.CancelComplain.Size = new System.Drawing.Size(162, 43);
            this.CancelComplain.TabIndex = 1;
            this.CancelComplain.Text = "Cancel Complaint";
            this.CancelComplain.UseVisualStyleBackColor = true;
            this.CancelComplain.Click += new System.EventHandler(this.CancelComplain_Click);
            // 
            // View_Complains
            // 
            this.View_Complains.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.View_Complains.FlatAppearance.BorderSize = 0;
            this.View_Complains.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.View_Complains.Location = new System.Drawing.Point(339, 3);
            this.View_Complains.Name = "View_Complains";
            this.View_Complains.Size = new System.Drawing.Size(162, 43);
            this.View_Complains.TabIndex = 1;
            this.View_Complains.Text = "View Complaints";
            this.View_Complains.UseVisualStyleBackColor = true;
            this.View_Complains.Click += new System.EventHandler(this.View_Complains_Click);
            // 
            // new_complain
            // 
            this.new_complain.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.new_complain.FlatAppearance.BorderSize = 0;
            this.new_complain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.new_complain.Location = new System.Drawing.Point(3, 3);
            this.new_complain.Name = "new_complain";
            this.new_complain.Size = new System.Drawing.Size(162, 43);
            this.new_complain.TabIndex = 0;
            this.new_complain.Text = "New Complaint";
            this.new_complain.UseVisualStyleBackColor = true;
            this.new_complain.Click += new System.EventHandler(this.new_complain_Click);
            // 
            // complain_panel
            // 
            this.complain_panel.BackColor = System.Drawing.Color.White;
            this.complain_panel.BackgroundImage = global::HotelManagementSystem.Properties.Resources.complain1;
            this.complain_panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.complain_panel.Location = new System.Drawing.Point(-1, 43);
            this.complain_panel.Name = "complain_panel";
            this.complain_panel.Size = new System.Drawing.Size(784, 579);
            this.complain_panel.TabIndex = 2;
            // 
            // Complains
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 600);
            this.Controls.Add(this.complain_panel);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Complains";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Complains";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button viewpolicy;
        private System.Windows.Forms.Button CancelComplain;
        private System.Windows.Forms.Button View_Complains;
        private System.Windows.Forms.Button new_complain;
        private System.Windows.Forms.Panel complain_panel;
    }
}