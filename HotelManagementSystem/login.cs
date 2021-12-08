using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HotelManagementSystem
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        public void Loadform(object Form)
        {
            if (this.loginpanel.Controls.Count > 0)
                this.loginpanel.Controls.RemoveAt(0);
            Form l = Form as Form;
            l.TopLevel = false;
            l.Dock = DockStyle.Fill;
            this.loginpanel.Controls.Add(l);
            this.loginpanel.Tag = l;
            l.Show();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Login_button_Click(object sender, EventArgs e)
        {
           
        }

        private void Login_button_Click_1(object sender, EventArgs e)
        {
            if (UserID.Text == "admin123" && Password.Text == "admin123"){
           Dashboard win2 = new Dashboard();
            win2.Show();
               
        }
           else if (UserID.Text == "admin123" && Password.Text != "admin123")
            {
         
                string box_msg = "Invalid Password";

                string box_title = "Login Error";

                MessageBox.Show(box_msg, box_title, MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);

            }
            else  if (UserID.Text != "admin123" && Password.Text == "admin123")
            {
              
                string box_msg = "Invalid User ID";

                string box_title = "Login Error";

                MessageBox.Show(box_msg, box_title, MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);

            }

            else
            {


                string box_msg = "Invalid User ID and Password";

                string box_title = "Login Error";

                MessageBox.Show(box_msg, box_title, MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            
            }

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
