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
    public partial class addStaff : Form
    {
      
        public addStaff()
        {
            InitializeComponent();
        }

        private void addStaff_Load(object sender, EventArgs e)
        {

        }

        private void Save_Click(object sender, EventArgs e)
        {

            try
            {

                if (MemberName.Text != "" && NIC.Text != "" && Contact.Text != "" && Gender.Text != "" && Address.Text != "" && DateOfBirth.Text != "" && Nationality.Text != "" && Religion.Text != "" && Qualification.Text != "" && EmploymentType.Text != "" && JoiningDate.Text != "" && WageMethod.Text != "" && WageType.Text != ""  && SetWage.Text != "")
                {

                    string connetionString;
                    MySqlConnection cnn;
                    connetionString = "datasource=localhost;port=3306;username=root;password=";
                    cnn = new MySqlConnection(connetionString);

                     string query = "INSERT into hotelmanagementsystem.staff(Name,Email,Contact,NIC,Gender,Address,DateOfBirth,Nationality,Religion,Qualification,EmploymentType,JoiningDate,PayMethod,PayType,PaySet) values('" + this.MemberName.Text + "', '" + this.Email.Text + "', '" + this.Contact.Text + "', '" + this.NIC.Text + "', '" + this.Gender.Text + "'  , '" + this.Address.Text + "' , '" + this.DateOfBirth.Text + "', '" + this.Nationality.Text + "' , '" + this.Religion.Text + "' , '" + this.Qualification.Text + "' , '" + this.EmploymentType.Text + "','" + this.JoiningDate.Text + "' ,'" + this.WageMethod.Text + "', '" + this.WageType.Text + "', '" + this.SetWage.Text + "')";

                    MySqlCommand cmd = new MySqlCommand(query, cnn);
                    cnn.Open();
                    MySqlDataReader myReader;
                   myReader = cmd.ExecuteReader();
                    MessageBox.Show("New staff member added successfully!");
                            
                    cnn.Close();
                       
                   
                }


                //displaying empty fields message
                else
                {
                    string box_msg = "All fields except Email, are mandatory to be filled.";

                    string box_title = "Incomplete Information!";

                    MessageBox.Show(box_msg, box_title, MessageBoxButtons.RetryCancel, MessageBoxIcon.Information);



                }

            }
            catch (System.Data.SqlClient.SqlException)
            {

                MessageBox.Show("Connection failed !");
            }
        }

        private void WageType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (WageType.Text == "Monthly") {
                per.Text = "per month";
                
            }

            else { per.Text = "per hour";
            
            
            }

        }

        private void NIC_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void Contact_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void SetWage_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void MemberName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar) || Char.IsSymbol(e.KeyChar) || Char.IsPunctuation(e.KeyChar))
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
    }
}
