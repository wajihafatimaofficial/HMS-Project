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
    public partial class ViewMemberDetail : Form
    {
        public ViewMemberDetail()
        {
            InitializeComponent();
            
        }
        public void BindGrid()
        {
            string connetionString;

            MySqlConnection cnn;
            connetionString = "datasource=localhost;port=3306;username=root;password=";
            cnn = new MySqlConnection(connetionString);

            string q = "SELECT Count(Name) as name FROM  hotelmanagementsystem.staff WHERE Name = '" + ask.Text + "' ";
            MySqlCommand c = new MySqlCommand(q, cnn);
            cnn.Open();
            c.CommandType = CommandType.Text;
            Int32 total = Convert.ToInt32(c.ExecuteScalar());

            if (total!=0) {
                string query = "SELECT * FROM  hotelmanagementsystem.staff WHERE Name = '" + ask.Text + "' ";

                MySqlCommand cmd = new MySqlCommand(query, cnn);
                
                cmd.CommandType = CommandType.Text;


                using (MySqlDataAdapter sda = new MySqlDataAdapter(cmd))
                {
                    using (DataTable dt = new DataTable())
                    {
                        sda.Fill(dt);
                        dataGridView2.DataSource = dt;
                    }
                }
            }
            else
            {
                string box_msg = "There is no staff member named " + ask.Text + " in the hotel.";

                string box_title = "Member not found";

                MessageBox.Show(box_msg, box_title, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
        }
            private void ViewMemberDetail_Load(object sender, EventArgs e)
        {

        }

            private void Check_Click(object sender, EventArgs e)
        {
            BindGrid();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ask_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar))
            {
                MessageBox.Show("Numbers can't be used for search. Use charachters only.");
                e.Handled = true;
            }
            if ( Char.IsSymbol(e.KeyChar) )
            {
                MessageBox.Show("Symbols can't be used for search. Use charachters only.");
                e.Handled = true;
            }
            if ( Char.IsPunctuation(e.KeyChar))
            {
                MessageBox.Show("Punctuations can't be used for search. Use charachters only.");
                e.Handled = true;
            }
        }
    }
}
