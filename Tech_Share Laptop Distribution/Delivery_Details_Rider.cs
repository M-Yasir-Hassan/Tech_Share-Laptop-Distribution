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
    public partial class Delivery_Details_Rider : Form
    {
        public Delivery_Details_Rider()
        {
            InitializeComponent();
        }

        private void btnviewshopsrider_Click(object sender, EventArgs e)
        {
            this.Hide();
            View_Shops_Rider n = new View_Shops_Rider();
            n.Show();
        }

        private void btnmanageroute_Click(object sender, EventArgs e)
        {
            this.Hide();
            Manage_Route m = new Manage_Route();
            m.Show();
        }

        private void btndelivereydetails_Click(object sender, EventArgs e)
        {
            this.Hide();
            Delivery_Details_Rider b = new Delivery_Details_Rider();
            b.Show();

        }

        private void btnfilecomplain_Click(object sender, EventArgs e)
        {
            this.Hide();
            File_Complain k = new File_Complain();
            k.Show();
        }

        private void btnlogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            LogIn c = new LogIn();
            c.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Delivery_Details_Rider_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
