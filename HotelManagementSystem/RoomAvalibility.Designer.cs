namespace HotelManagementSystem
{
    partial class RoomAvalibility
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
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.RoomType = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.CheckInDate = new System.Windows.Forms.DateTimePicker();
            this.avalibility = new System.Windows.Forms.Label();
            this.Check = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Impact", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(183, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(421, 53);
            this.label4.TabIndex = 23;
            this.label4.Text = "Check Room Avalibility";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(242, 226);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 16);
            this.label7.TabIndex = 24;
            this.label7.Text = "Room Type:";
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
            this.RoomType.Location = new System.Drawing.Point(360, 218);
            this.RoomType.Name = "RoomType";
            this.RoomType.Size = new System.Drawing.Size(182, 24);
            this.RoomType.TabIndex = 25;
            this.RoomType.SelectedIndexChanged += new System.EventHandler(this.RoomType_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(242, 291);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(87, 16);
            this.label9.TabIndex = 26;
            this.label9.Text = "CheckIn Date";
            // 
            // CheckInDate
            // 
            this.CheckInDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.CheckInDate.Location = new System.Drawing.Point(360, 291);
            this.CheckInDate.Name = "CheckInDate";
            this.CheckInDate.Size = new System.Drawing.Size(182, 22);
            this.CheckInDate.TabIndex = 27;
            // 
            // avalibility
            // 
            this.avalibility.AutoSize = true;
            this.avalibility.Cursor = System.Windows.Forms.Cursors.Default;
            this.avalibility.ForeColor = System.Drawing.Color.Blue;
            this.avalibility.Location = new System.Drawing.Point(259, 449);
            this.avalibility.Name = "avalibility";
            this.avalibility.Size = new System.Drawing.Size(0, 16);
            this.avalibility.TabIndex = 28;
            this.avalibility.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Check
            // 
            this.Check.BackColor = System.Drawing.Color.ForestGreen;
            this.Check.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Check.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Check.Location = new System.Drawing.Point(339, 361);
            this.Check.Name = "Check";
            this.Check.Size = new System.Drawing.Size(106, 32);
            this.Check.TabIndex = 29;
            this.Check.Text = "Check";
            this.Check.UseVisualStyleBackColor = false;
            this.Check.Click += new System.EventHandler(this.Check_Click);
            // 
            // RoomAvalibility
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 574);
            this.Controls.Add(this.Check);
            this.Controls.Add(this.avalibility);
            this.Controls.Add(this.CheckInDate);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.RoomType);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RoomAvalibility";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RoomAvalibility";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox RoomType;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker CheckInDate;
        private System.Windows.Forms.Label avalibility;
        private System.Windows.Forms.Button Check;
    }
}