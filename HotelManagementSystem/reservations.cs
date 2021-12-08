using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManagementSystem
{
    public partial class reservations : Form
    {
        public reservations()
        {
            InitializeComponent();
        }

        public void loadform2(object Form)
        {
            if (this.reservation_panel.Controls.Count > 0)
                this.reservation_panel.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.reservation_panel.Controls.Add(f);
            this.reservation_panel.Tag = f;
            f.Show();
        }

        private void new_reservation_Click(object sender, EventArgs e)
        {
            loadform2(new NewReservation());
        }

        private void CancelReservation_Click(object sender, EventArgs e)
        {
            loadform2(new CancelReservations());
        }

        private void View_Reservations_Click(object sender, EventArgs e)
        {
            loadform2(new ViewReservations());
       }

        private void priceList_Click(object sender, EventArgs e)
        {
            loadform2(new priceList());
        }

        private void CheckAvalibility_Click(object sender, EventArgs e)
        {
            loadform2(new RoomAvalibility());
        }

        private void reservation_panel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
