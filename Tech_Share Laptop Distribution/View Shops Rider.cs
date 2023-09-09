using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tech_Share_Laptop_Distribution.DL;

namespace Tech_Share_Laptop_Distribution
{
    public partial class View_Shops_Rider : Form
    {
        public View_Shops_Rider()
        {
            InitializeComponent();
        }

        private void btnviewrider_Click(object sender, EventArgs e)
        {
            this.Hide();
            Manage_Route m = new Manage_Route();
            m.Show();

        }

        private void btnaddrider_Click(object sender, EventArgs e)
        {


        }

        private void btnstockdetails_Click(object sender, EventArgs e)
        {
            this.Hide();
            Delivery_Details_Rider d = new Delivery_Details_Rider();
            d.Show();
        }

        private void btnreports_Click(object sender, EventArgs e)
        {
            this.Hide();
            ViewStock a = new ViewStock();
            a.Show();
        }

        private void btnmanagesales_Click(object sender, EventArgs e)
        {
            this.Hide();
            File_Complain aa = new File_Complain();
            aa.Show();
        }

        private void btnlogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            LogIn n = new LogIn();
            n.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void View_Shops_Rider_Load(object sender, EventArgs e)
        {
            this.gridviewshops.DataSource = ShopDL.ShopList;
        }
    }
}
