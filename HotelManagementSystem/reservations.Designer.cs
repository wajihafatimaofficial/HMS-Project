﻿namespace HotelManagementSystem
{
    partial class reservations
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
            this.CancelReservation = new System.Windows.Forms.Button();
            this.View_Reservations = new System.Windows.Forms.Button();
            this.new_reservation = new System.Windows.Forms.Button();
            this.priceList = new System.Windows.Forms.Button();
            this.reservation_panel = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.Controls.Add(this.priceList);
            this.panel1.Controls.Add(this.CancelReservation);
            this.panel1.Controls.Add(this.View_Reservations);
            this.panel1.Controls.Add(this.new_reservation);
            this.panel1.Location = new System.Drawing.Point(-2, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(801, 46);
            this.panel1.TabIndex = 0;
            // 
            // CancelReservation
            // 
            this.CancelReservation.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.CancelReservation.FlatAppearance.BorderSize = 0;
            this.CancelReservation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelReservation.Location = new System.Drawing.Point(171, 3);
            this.CancelReservation.Name = "CancelReservation";
            this.CancelReservation.Size = new System.Drawing.Size(162, 43);
            this.CancelReservation.TabIndex = 1;
            this.CancelReservation.Text = "Cancel Reservation";
            this.CancelReservation.UseVisualStyleBackColor = true;
            this.CancelReservation.Click += new System.EventHandler(this.CancelReservation_Click);
            // 
            // View_Reservations
            // 
            this.View_Reservations.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.View_Reservations.FlatAppearance.BorderSize = 0;
            this.View_Reservations.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.View_Reservations.Location = new System.Drawing.Point(339, 3);
            this.View_Reservations.Name = "View_Reservations";
            this.View_Reservations.Size = new System.Drawing.Size(162, 43);
            this.View_Reservations.TabIndex = 1;
            this.View_Reservations.Text = "View Reservations";
            this.View_Reservations.UseVisualStyleBackColor = true;
            this.View_Reservations.Click += new System.EventHandler(this.View_Reservations_Click);
            // 
            // new_reservation
            // 
            this.new_reservation.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.new_reservation.FlatAppearance.BorderSize = 0;
            this.new_reservation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.new_reservation.Location = new System.Drawing.Point(3, 3);
            this.new_reservation.Name = "new_reservation";
            this.new_reservation.Size = new System.Drawing.Size(162, 43);
            this.new_reservation.TabIndex = 0;
            this.new_reservation.Text = "New Reservation";
            this.new_reservation.UseVisualStyleBackColor = true;
            this.new_reservation.Click += new System.EventHandler(this.new_reservation_Click);
            // 
            // priceList
            // 
            this.priceList.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.priceList.FlatAppearance.BorderSize = 0;
            this.priceList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.priceList.Location = new System.Drawing.Point(507, 3);
            this.priceList.Name = "priceList";
            this.priceList.Size = new System.Drawing.Size(162, 43);
            this.priceList.TabIndex = 2;
            this.priceList.Text = "View Price List";
            this.priceList.UseVisualStyleBackColor = true;
            this.priceList.Click += new System.EventHandler(this.priceList_Click);
            // 
            // reservation_panel
            // 
            this.reservation_panel.BackgroundImage = global::HotelManagementSystem.Properties.Resources.logo;
            this.reservation_panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.reservation_panel.Location = new System.Drawing.Point(1, 37);
            this.reservation_panel.Name = "reservation_panel";
            this.reservation_panel.Size = new System.Drawing.Size(800, 550);
            this.reservation_panel.TabIndex = 1;
            // 
            // reservations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 579);
            this.Controls.Add(this.reservation_panel);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "reservations";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button new_reservation;
        private System.Windows.Forms.Button CancelReservation;
        private System.Windows.Forms.Button View_Reservations;
        private System.Windows.Forms.Panel reservation_panel;
        private System.Windows.Forms.Button priceList;
    }
}