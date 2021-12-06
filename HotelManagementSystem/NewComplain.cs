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
    public partial class NewComplain : Form
    {
        public NewComplain()
        {
            InitializeComponent();
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            ComplainerName.Clear();
            Email.Clear();
            Contact.Clear();
           
            ComplainDetails.Clear();
        }

        private void Save_Click(object sender, EventArgs e)
        {

            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                MessageBox.Show(ComplainerName.Text, "Demo App - Message!");

            }
            try
            {

                if (ComplainerName.Text != "" && Email.Text != ""  && Contact.Text != "" && ComplainSubject.Text != "" && ComplainDetails.Text != "" && ComplainDate.Text != "" )
                {


                    string connetionString;
                    MySqlConnection cnn;
                    connetionString = "datasource=localhost;port=3306;username=root;password=";
                    cnn = new MySqlConnection(connetionString);


                    string query = "Insert into hotelmanagementsystem.complaints(Name,Email,Contact,Subject,Details,Date) values('" + this.ComplainerName.Text + "', '" + this.Email.Text + "', '" + this.Contact.Text + "','" + this.ComplainSubject.Text + "' ,'" + this.ComplainDetails.Text + "','" + this.ComplainDate.Text + "' )";

                    MySqlCommand cmd = new MySqlCommand(query, cnn);
                    cnn.Open();
                    MySqlDataReader myReader;
                    myReader = cmd.ExecuteReader();
                    MessageBox.Show("Complaint has been registered successfully!");
                    cnn.Close();
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

        private void Contact_Validating(object sender, CancelEventArgs e)
        {

            if (string.IsNullOrWhiteSpace(Contact.Text))
            {
                e.Cancel = true;
                Contact.Focus();
                ContactError.SetError(Contact, "Contact should not be left blank!");
            }

            if (Contact.Text.Length != 11)
            {
                e.Cancel = true;
                Contact.Focus();
                ContactError.SetError(Contact, "Contact number must contain 11 digits!");
            }

            else
            {
                e.Cancel = false;
                ContactError.SetError(Contact, "");
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
                Contact.Text = Contact.Text.Remove(Contact.Text.Length - 1);
            }
        }

        private void ComplainerName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar) || Char.IsSymbol(e.KeyChar) || Char.IsWhiteSpace(e.KeyChar) || Char.IsPunctuation(e.KeyChar))
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
