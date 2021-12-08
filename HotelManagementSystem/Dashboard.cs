using System;
using System.Windows.Forms;

namespace HotelManagementSystem
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
            

        }
        public void loadform(object Form)
        {
            if (this.mainpanel.Controls.Count > 0)
                this.mainpanel.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.mainpanel.Controls.Add(f);
            this.mainpanel.Tag = f;
            f.Show();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            loadform(new reservations());
        }

        private void Checkouts_Click(object sender, EventArgs e)
        {
            loadform(new Checkouts());
        }

        private void Complaints_Feedback_Click(object sender, EventArgs e)
        {
            loadform(new Complains());
        }

        private void Staff_Click(object sender, EventArgs e)
        {
            loadform(new Staff());
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();


        }
    }
}
