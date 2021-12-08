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
    public partial class ViewStaffMembers : Form
    {
        public ViewStaffMembers()
        {
            InitializeComponent();
            BindGrid();
        }
        private void BindGrid()
        {
            string connetionString;
            MySqlConnection cnn;
            connetionString = "datasource=localhost;port=3306;username=root;password=";
            cnn = new MySqlConnection(connetionString);

            string query = "SELECT * FROM  hotelmanagementsystem.staff";
            MySqlCommand cmd = new MySqlCommand(query, cnn);
            cnn.Open();
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
        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
