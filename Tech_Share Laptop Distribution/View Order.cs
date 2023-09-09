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
    public partial class View_Order : Form
    {
        public View_Order()
        {
            InitializeComponent();
        }


        private void View_Order_Load(object sender, EventArgs e)
        {
            gproductdeletegrid.DataSource = OrderDL.OrderList;
        }

        private void btnaddrider_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Add_Rider_Employee ad = new Add_Rider_Employee();
            ad.Show();
        }

        private void btnviewrider_Click(object sender, EventArgs e)
        {
            this.Hide();
            View_Rider_Employee v = new View_Rider_Employee();
            v.Show();
        }

        private void btnorders_Click(object sender, EventArgs e)
        {
            this.Hide();
            View_Order v = new View_Order();
            v.Show();
        }

        private void btnaddshop_Click(object sender, EventArgs e)
        {
            this.Hide();
            Add_Shop ad = new Add_Shop();
            ad.Show();
        }

        private void btnriderdetails_Click(object sender, EventArgs e)
        {

        }

        private void btnlogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            LogIn i = new LogIn();
            i.Show();
        }

        private void btnstockdetails_Click(object sender, EventArgs e)
        {
            this.Hide();
            Stock_DEmployee j = new Stock_DEmployee();
            j.Show();
        }

        private void btnplaceorder_Click(object sender, EventArgs e)
        {
            this.Hide();
            Place_order n = new Place_order();
            n.Show();
        }

        private void btnaddproduct_Click(object sender, EventArgs e)
        {
            this.Hide();
            addproduct m = new addproduct();
            m.Show();
        }
    }
}
