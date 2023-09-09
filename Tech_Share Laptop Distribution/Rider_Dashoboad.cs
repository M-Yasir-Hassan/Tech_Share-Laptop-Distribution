using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tech_Share_Laptop_Distribution
{
    public partial class Rider_Dashoboad : Form
    {
        public Rider_Dashoboad()
        {
            InitializeComponent();
        }

        private void btnlogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            LogIn h = new LogIn();
            h.Show();
        }

        private void btnaddrider_Click(object sender, EventArgs e)
        {
            this.Hide();
            View_Shops_Rider m = new View_Shops_Rider();
            m.Show();
        }

        private void btnstockdetails_Click(object sender, EventArgs e)
        {
            this.Hide();
            Delivery_Details_Rider l = new Delivery_Details_Rider();
            l.Show();
        }

        private void btnreports_Click(object sender, EventArgs e)
        {
            this.Hide();
            ViewStock v = new ViewStock();
            v.Show();
        }

        private void btnmanagesales_Click(object sender, EventArgs e)
        {
            this.Hide();
            File_Complain u = new File_Complain();
            u.Show();
        }


        private void btnviewrider_Click(object sender, EventArgs e)
        {
            this.Hide();
            Manage_Route n = new Manage_Route();
            n.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
