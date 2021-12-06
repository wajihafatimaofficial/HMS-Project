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
    public partial class Complains : Form
    {
        public Complains()
        {
            InitializeComponent();
        }

        public void loadform2(object Form)
        {
            if (this.complain_panel.Controls.Count > 0)
                this.complain_panel.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.complain_panel.Controls.Add(f);
            this.complain_panel.Tag = f;
            f.Show();
        }

        private void new_complain_Click(object sender, EventArgs e)
        {
            loadform2(new NewComplain());
        }

        private void CancelComplain_Click(object sender, EventArgs e)
        {
            loadform2(new CancelComplain());
        }

        private void View_Complains_Click(object sender, EventArgs e)
        {
            loadform2(new ViewComplain());
        }
    }
}
