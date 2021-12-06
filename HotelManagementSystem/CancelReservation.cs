using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using MySql.Data.MySqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManagementSystem
{
    public partial class CancelReservations : Form
    {
        public CancelReservations()
        {
            InitializeComponent();
        
        }

        private void EditReservation_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void reservationid_TextChanged(object sender, EventArgs e)
        {
            
        }

        public void SearchReservation_Click(object sender, EventArgs e)
        {
            int i = Convert.ToInt32(reservationid.Text);
            string connetionString;
            MySqlConnection cnn;
             connetionString = "datasource=localhost;port=3306;username=root;password=";
            cnn = new MySqlConnection(connetionString);

            string query = "SELECT * FROM  hotelmanagementsystem.reservations WHERE ID = " + i;
            MySqlCommand cmd = new MySqlCommand(query, cnn);
            cnn.Open();
            cmd.CommandType = CommandType.Text;
            MySqlDataReader dr = cmd.ExecuteReader();

            dr.Read();
          
            TimeSpan Period = Convert.ToDateTime(DateTime.Today.Date) - Convert.ToDateTime(dr["CheckInDate"]);

            if (Period.Days < 0)
            {
                if (dr.Read())
                {
                    NameData.Text = dr["Name"].ToString();
                    EmailData.Text = dr["Email"].ToString();
                    ContactData.Text = dr["Contact"].ToString();
                    NICData.Text = dr["NIC"].ToString();
                    GenderData.Text = dr["Gender"].ToString();
                    AddressData.Text = dr["Address"].ToString();
                    RoomTypeData.Text = dr["RoomType"].ToString();
                    TGuestsData.Text = dr["TotalGuests"].ToString();
                    TAdultsData.Text = dr["TotalAdults"].ToString();
                    TChildrenData.Text = dr["TotalChildrens"].ToString();
                    CheckinDateData.Text = dr["CheckInDate"].ToString();
                    CheckoutDateData.Text = dr["CheckOutDate"].ToString();
                    ChecinPeriodData.Text = dr["CheckInPeriod"].ToString();
                    PayMethodData.Text = dr["PaymentMethod"].ToString();
                    PayAmountData.Text = dr["PaymentAmount"].ToString();

                    DelReservation.Show();

                }
                else
                {
                    string box_msg = "No record found for Guest ID " + i;

                    string box_title = "Data not found";

                    MessageBox.Show(box_msg, box_title, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                cnn.Close();
            }
            else
            {
                string box_msg = "This reservation has been closed already";

                string box_title = "Invalid operation";

                MessageBox.Show(box_msg, box_title, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void Reset_Click(object sender, EventArgs e)
        {
            ResetAll();
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void DelReservation_Click(object sender, EventArgs e)
        {
            int i = Convert.ToInt32(reservationid.Text);
            string box_msg = "Are you sure you want to deleted the reservation with ID : " +i;

            string box_title = "Confirmation!";

            DialogResult dialogResult= MessageBox.Show(box_msg, box_title, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (dialogResult == DialogResult.Yes)
            {
                string connetionString;
                MySqlConnection cnn;
                connetionString = "datasource=localhost;port=3306;username=root;password=";
                cnn = new MySqlConnection(connetionString);
                cnn.Open();
                string query = "DELETE FROM hotelmanagementsystem.reservations WHERE ID = " + i;
                MySqlCommand cmd = new MySqlCommand(query, cnn);

                cmd.CommandType = CommandType.Text;
                MySqlDataReader dr = cmd.ExecuteReader();
                cnn.Close();

                string msg = "Reservation for ID  " + i +" has been cancelled!";

                string title = "Reservation Cancelled!";

                MessageBox.Show(msg, title, MessageBoxButtons.OK, MessageBoxIcon.Information);

                ResetAll();
            }

            else { }
        }
        public void ResetAll()
        {
            reservationid.Clear();
            NameData.Text = "";
            EmailData.Text = "";
            ContactData.Text = "";
            NICData.Text = "";
            GenderData.Text = "";
            AddressData.Text = "";
            RoomTypeData.Text = "";
            TGuestsData.Text = "";
            TAdultsData.Text = "";
            TChildrenData.Text = "";
            CheckinDateData.Text = "";
            CheckoutDateData.Text = "";
            ChecinPeriodData.Text = "";
            PayMethodData.Text = "";
            PayAmountData.Text = "";
        }
    }
}
