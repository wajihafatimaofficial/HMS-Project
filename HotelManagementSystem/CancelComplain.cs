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
    public partial class CancelComplain : Form
    {
        public CancelComplain()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void SearchComplaints_Click(object sender, EventArgs e)
        {
            int i = Convert.ToInt32(Complaintid.Text);
            string connetionString;
            MySqlConnection cnn;
            connetionString = "datasource=localhost;port=3306;username=root;password=";
            cnn = new MySqlConnection(connetionString);

            string query = "SELECT * FROM  hotelmanagementsystem.complaints WHERE ID = " + i;
            MySqlCommand cmd = new MySqlCommand(query, cnn);
            cnn.Open();
            cmd.CommandType = CommandType.Text;
            MySqlDataReader dr = cmd.ExecuteReader();

            try
            {
                dr.Read();

                
                if (dr["Status"].ToString() == "Open")
                {
                    NameData.Text = dr["Name"].ToString();
                    EmailData.Text = dr["Email"].ToString();
                    ContactData.Text = dr["Contact"].ToString();
                    SubjectData.Text = dr["Subject"].ToString();
                    DatedData.Text = dr["Date"].ToString();
                    DetailsData.Text = dr["Details"].ToString();
                    StatusData.Text = dr["Status"].ToString();
                   

                    DelComplaints.Show();




                }
                else
                {
                    ResetAll();
                    string box_msg = "This complaint has been closed already";

                    string box_title = "Invalid operation";

                    MessageBox.Show(box_msg, box_title, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception)
            {

                ResetAll();
                string box_msg = "Reservation record for ID " + i + " doesnot exsist.";

                string box_title = "Information";

                MessageBox.Show(box_msg, box_title, MessageBoxButtons.OK, MessageBoxIcon.Error);


            }
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            ResetAll();
        }

        private void DelComplaints_Click(object sender, EventArgs e)
        {
            int i = Convert.ToInt32(Complaintid.Text);
            string box_msg = "Are you sure you want to deleted the complain with ID : " + i;

            string box_title = "Confirmation!";

            DialogResult dialogResult = MessageBox.Show(box_msg, box_title, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (dialogResult == DialogResult.Yes)
            {
                string connetionString;
                MySqlConnection cnn;
                connetionString = "datasource=localhost;port=3306;username=root;password=";
                cnn = new MySqlConnection(connetionString);
                cnn.Open();
                string query = "DELETE FROM hotelmanagementsystem.complaints WHERE ID = " + i;
                MySqlCommand cmd = new MySqlCommand(query, cnn);

                cmd.CommandType = CommandType.Text;
                MySqlDataReader dr = cmd.ExecuteReader();
                cnn.Close();

                string msg = "Complaint with ID  " + i + " has been cancelled!";

                string title = "Complaint Cancelled!";

                MessageBox.Show(msg, title, MessageBoxButtons.OK, MessageBoxIcon.Information);

                ResetAll();
            }

            else { }
        }
        public void ResetAll()
        {
            Complaintid.Clear();
            NameData.Text = "";
            EmailData.Text = "";
            ContactData.Text = "";
            DetailsData.Text = "";
            SubjectData.Text = "";
            DatedData.Text = "";
           StatusData.Text = "";
          
        }
    }
}
