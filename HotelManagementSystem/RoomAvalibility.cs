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
    public partial class RoomAvalibility : Form
    {
        public RoomAvalibility()
        {
            InitializeComponent();
        }

        private void Check_Click(object sender, EventArgs e)
        {
            try
            {

                if (RoomType.Text != "" && CheckInDate.Text != "")
                {

                    string connetionString;
                    MySqlConnection cnn;
                    connetionString = "datasource=localhost;port=3306;username=root;password=";
                    cnn = new MySqlConnection(connetionString);


                    string q = "SELECT Count(RoomType) as total FROM  hotelmanagementsystem.reservations WHERE CheckInDate = '" + CheckInDate.Text + "' ";
                    MySqlCommand c = new MySqlCommand(q, cnn);
                    cnn.Open();
                    c.CommandType = CommandType.Text;
                    Int32 total = Convert.ToInt32(c.ExecuteScalar());

                    if (total < 40)
                    {
                        string query1 = "SELECT Count(RoomType) as Count FROM  hotelmanagementsystem.reservations WHERE RoomType = '" + RoomType.Text + "'  ";
                        MySqlCommand cmd1 = new MySqlCommand(query1, cnn);
                        cmd1.CommandType = CommandType.Text;
                        Int32 count = Convert.ToInt32(cmd1.ExecuteScalar());



                        if (count >= 5)
                        {
                            string check = Convert.ToString(CheckInDate.Text);
                            string query2 = "SELECT Count(CheckInDate) AS cd FROM  hotelmanagementsystem.reservations WHERE RoomType = '" + RoomType.Text + "' AND CheckInDate =  '" + check + "' ";
                            MySqlCommand cmd2 = new MySqlCommand(query2, cnn);
                            cmd2.CommandType = CommandType.Text;
                            Int32 cd = Convert.ToInt32(cmd2.ExecuteScalar());


                            if (cd >= 5)
                            {
                                avalibility.Text = "All the " + RoomType.Text + " rooms are booked on " + CheckInDate.Text + ".";
                                avalibility.ForeColor = Color.Red;
                            }
                            else
                            {
                                int aroom = 5 - cd;
                              
                                avalibility.Text = aroom+ " "+ RoomType.Text + " room(s) are available";
                                avalibility.ForeColor = Color.Blue;
                            }

                        }
                        else
                        {
                            avalibility.ForeColor = Color.Blue;
                            avalibility.Text = "Room(s) available";
                        }
                    }
                    else
                    {
                        avalibility.Text = "All type of rooms are booked on " + CheckInDate.Text + ".";
                        avalibility.ForeColor = Color.Red;



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

        private void RoomType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
