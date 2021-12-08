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
using System.Text.RegularExpressions;
namespace HotelManagementSystem
{
    public partial class NewReservation : Form
    {
        public int TotalRooms = 40;
        public int TTypeRooms = 5;


        public NewReservation()
        {
            InitializeComponent();

           
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void NewReservation_Load(object sender, EventArgs e)
        {

        }

        private void Reset_Click(object sender, EventArgs e)
        {
            GuestName.Clear();
            Email.Clear();
            Contact.Clear();
            NIC.Clear();
           
            Address.Clear();
           
            CheckInDate.ResetText();
            CheckoutDate.ResetText();
        }
        private void CheckoutDate_ValueChanged(object sender, EventArgs e)
        {
            TimeSpan Period = Convert.ToDateTime(CheckoutDate.Value.Date) - Convert.ToDateTime(CheckInDate.Value.Date);
            CheckInPeriod.Text = Convert.ToString(Period.Days);
            cal();

        }
       
        
        private void Save_Click(object sender, EventArgs e)
        {
           
            try
            {

                if (GuestName.Text != "" && Email.Text != "" && NIC.Text != "" && Contact.Text != "" && Gender.Text != "" && Address.Text != "" && RoomType.Text != "" && TGuests.Text != "" && TAdults.Text != "" && TChildren.Text != "" && CheckInDate.Text != "" && CheckoutDate.Text != "" && Payment.Text != "" && payment_method.Text != "")
                {

                    string connetionString;
                    MySqlConnection cnn;
                    connetionString = "datasource=localhost;port=3306;username=root;password=";
                    cnn = new MySqlConnection(connetionString);


                    string q = "SELECT Count(RoomType) as total FROM  hotelmanagementsystem.reservations WHERE CheckInDate = '" + CheckInDate.Text+"' ";
                    MySqlCommand c = new MySqlCommand(q, cnn);
                    cnn.Open();
                    c.CommandType = CommandType.Text;
                    Int32 total = Convert.ToInt32(c.ExecuteScalar());

                    if (total < TotalRooms)
                    {
                        string query1 = "SELECT Count(RoomType) as Count FROM  hotelmanagementsystem.reservations WHERE RoomType = '" + RoomType.Text + "'  ";
                        MySqlCommand cmd1 = new MySqlCommand(query1, cnn);
                        cmd1.CommandType = CommandType.Text;
                        Int32 count = Convert.ToInt32(cmd1.ExecuteScalar());



                        if (count >= 5)
                        {
                            string check = Convert.ToString(CheckInDate.Text);
                            string query2 = "SELECT Count(CheckInDate) AS cd FROM  hotelmanagementsystem.reservations WHERE RoomType = '" + RoomType.Text + "' AND CheckInDate =  '"+ check+ "' " ;
                            MySqlCommand cmd2 = new MySqlCommand(query2, cnn);
                            cmd2.CommandType = CommandType.Text;
                            Int32 cd = Convert.ToInt32(cmd2.ExecuteScalar());
                           

                            if (cd>=5)
                            {
                                string box_msg = "All the " + RoomType.Text + " rooms are booked on " + CheckInDate.Text + ". Please choose another room type if reservation is required instantly.";

                                string box_title = "No " + RoomType.Text + "rooms available";

                                MessageBox.Show(box_msg, box_title, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            }
                            else {
                                string query = "Insert into hotelmanagementsystem.reservations(Name,Email,Contact,NIC,Gender,Address,RoomType,TotalGuests,TotalAdults,TotalChildrens,CheckInDate,CheckOutDate,CheckInPeriod,PaymentMethod,PaymentAmount) values('" + this.GuestName.Text + "', '" + this.Email.Text + "', '" + this.Contact.Text + "', '" + this.NIC.Text + "', '" + this.Gender.Text + "'  , '" + this.Address.Text + "' , '" + this.RoomType.Text + "', '" + this.TGuests.Text + "' , '" + this.TAdults.Text + "' , '" + this.TChildren.Text + "' , '" + this.CheckInDate.Text + "','" + this.CheckoutDate.Text + "' ,'" + this.CheckInPeriod.Text + "', '" + this.payment_method.Text + "' , '" + this.amountRs.Text + "')";

                                MySqlCommand cmd = new MySqlCommand(query, cnn);

                                MySqlDataReader myReader;
                                myReader = cmd.ExecuteReader();
                                MessageBox.Show("New Reservation Confirmed");
                            }

                        }
                        else
                        {

                            string query = "Insert into hotelmanagementsystem.reservations(Name,Email,Contact,NIC,Gender,Address,RoomType,TotalGuests,TotalAdults,TotalChildrens,CheckInDate,CheckOutDate,CheckInPeriod,PaymentMethod,PaymentAmount) values('" + this.GuestName.Text + "', '" + this.Email.Text + "', '" + this.Contact.Text + "', '" + this.NIC.Text + "', '" + this.Gender.Text + "'  , '" + this.Address.Text + "' , '" + this.RoomType.Text + "', '" + this.TGuests.Text + "' , '" + this.TAdults.Text + "' , '" + this.TChildren.Text + "' , '" + this.CheckInDate.Text + "','" + this.CheckoutDate.Text + "' ,'" + this.CheckInPeriod.Text + "', '" + this.payment_method.Text + "' , '" + this.amountRs.Text + "')";

                            MySqlCommand cmd = new MySqlCommand(query, cnn);

                            MySqlDataReader myReader;
                            myReader = cmd.ExecuteReader();
                            MessageBox.Show("New Reservation Confirmed");
                            cnn.Close();
                        }
                    }
                    else {
                        string box_msg = "All rooms are booked on " + CheckInDate.Text + ". Rooms can not be reserved furter for today.";

                        string box_title = "No rooms are available";

                        MessageBox.Show(box_msg, box_title, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);


                    }
                }

                
                //displaying empty fields message
                else
                {
                    string box_msg = "Please fill all Fields";

                    string box_title = "Information Required!";

                    MessageBox.Show(box_msg, box_title, MessageBoxButtons.RetryCancel, MessageBoxIcon.Information);


             
                }
                
            }
            catch (System.Data.SqlClient.SqlException)
            {

                MessageBox.Show("Connection failed !");
            }
            

        }



        private void Roomype_Selected(object sender, EventArgs e)
        {
            
        }

        
        
        public void RoomType_SelectedIndexChanged(object sender, EventArgs e)
        {
            cal();

            
        }
        

        public void RoomType_SelectedValueChanged(object sender, EventArgs e)
        {

            cal();
            
        }
        public void CheckInPeriod_SelectedIndexChanged(object sender, EventArgs e)
        {

            cal();
        }

        public void cal()
        {
            int damount= 0;
            int ramount = 0;
            int totalamount = 0;
            string r = Convert.ToString(RoomType.SelectedItem);

            if (r == "Single") { ramount = 1000; }
            if (r == "Double") { ramount = 2000; }
            if (r == "Triple") { ramount = 3000; }
            if (r == "Quad") { ramount = 4000; }
            if (r == "Queen") { ramount = 5000; }
            if (r == "King") { ramount = 6000; }
            if (r == "Twin") { ramount = 7000; }
            if (r == "Double-double") { ramount = 2000; }

            int d = Convert.ToInt32(CheckInPeriod.Text) ;
            damount = d * 1000;
            if (d == 1) { damount = 0; }
            totalamount = ramount + damount;
            amountRs.Text = Convert.ToString(totalamount);
            totalamount = 0;
            damount = 0;
            ramount = 0;
        }
        public void TChildren_SelectedValueChanged(object sender, EventArgs e)
        {
            
        }

        private void CheckInPeriod_SelectedValueChanged(object sender, EventArgs e)
        {
            cal();
        }

        public void TAdults_SelectedIndexChanged(object sender, EventArgs e)
        {
            CheckTotal();
            
        }

        public void CheckTotal()
        {
            int g = Convert.ToInt32(TGuests.Text);
            int a = Convert.ToInt32(TAdults.Text);
            if (g > a)
            {
                TChildren.Text = Convert.ToString(g - a);

            }
            if (a > g)
            {
                TGuests.Text = Convert.ToString(a);
                TChildren.Text = "0";
            }

            if (a == g)
            {

                TChildren.Text = "0";
            }
        }

         public void TChildren_SelectedIndexChanged(object sender, EventArgs e)
        {
            


        }

        private void Name_validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(GuestName.Text))
            {
                e.Cancel = true;
                GuestName.Focus();
                Nameerror.SetError(GuestName, "Name should not be left blank!");
            }
            else
            {
                e.Cancel = false;
                Nameerror.SetError(GuestName, "");
            }
        }

        private void NIC_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(NIC.Text, "[^0-9]"))
            {
               
                NIC.Focus();
                MessageBox.Show("Please enter only numbers.");
                NIC.Text = NIC.Text.Remove(NIC.Text.Length - 1);
            }
        
        }

        private void NIC_validating(object sender, CancelEventArgs e)
        {
            
            if (string.IsNullOrWhiteSpace(NIC.Text))
            {
                e.Cancel = true;
                NIC.Focus();
                Nameerror.SetError(NIC, "NIC should not be left blank!");
            }

            if (NIC.Text.Length!=13)
            {
                e.Cancel = true;
                NIC.Focus();
                Nameerror.SetError(NIC, "NIC must contain 13 digits!");
            }

            else
            {
                e.Cancel = false;
                Nameerror.SetError(NIC, "");
            }
        }

        private void NIC_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void contac_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Contact.Text))
            {
                e.Cancel = true;
                Contact.Focus();
                contactError.SetError(Contact, "Contact should not be left blank!");
            }

            if (Contact.Text.Length != 11)
            {
                e.Cancel = true;
                Contact.Focus();
                contactError.SetError(Contact, "Contact number must contain 11 digits!");
            }

            else
            {
                e.Cancel = false;
                contactError.SetError(Contact, "");
            }
        }

        private void Contact_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void Contact_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(Contact.Text, "[^0-9]"))
            {

                Contact.Focus();
                MessageBox.Show("Please enter only numbers.");
                Contact.Text = Contact.Text.Remove(Contact.Text.Length - Contact.SelectionLength);
            }
        }

        private void GuestName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar) || Char.IsSymbol(e.KeyChar)  || Char.IsPunctuation(e.KeyChar))
            {
                MessageBox.Show("Name field can only contains characters.");
                e.Handled = true;
            }
        }

        private void Email_Validating(object sender, CancelEventArgs e)
        {
            Regex regex = new Regex(@"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$");
            bool isValid = regex.IsMatch(Email.Text.Trim());
            if (!isValid)
            {
                e.Cancel = true;
                Email.Focus();
                EmailError.SetError(Email, "Invalid email format!");
            }
            else
            {
                e.Cancel = false;
                EmailError.SetError(Email, "");
            }
        }

        private void Payment_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }


}
