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
    public partial class ViewReservations : Form
    {
        public ViewReservations()
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

            string query = "SELECT * FROM  hotelmanagementsystem.reservations";
            MySqlCommand cmd = new MySqlCommand(query, cnn);
            cnn.Open();
            cmd.CommandType = CommandType.Text;
                    using (MySqlDataAdapter sda = new MySqlDataAdapter(cmd))
                    {
                        using (DataTable dt = new DataTable())
                        {
                            sda.Fill(dt);
                            dataGridView1.DataSource = dt;
                        }
                    }
                
            
        }

    }
}
