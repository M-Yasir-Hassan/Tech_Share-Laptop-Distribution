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
using Tech_Share_Laptop_Distribution.BL;

namespace Tech_Share_Laptop_Distribution
{
    public partial class Stock_DEmployee : Form
    {
        public Stock_DEmployee()
        {
            InitializeComponent();
        }

        private void Stock_DEmployee_Load(object sender, EventArgs e)
        {
            this.dataGridView1.DataSource = StockDL.StockList;
        }

        private void btnaddrider_Click(object sender, EventArgs e)
        {
            this.Hide();
            Add_Rider_Employee l = new Add_Rider_Employee();
            l.Show();
        }

        private void btnviewrider_Click(object sender, EventArgs e)
        {
            this.Hide();
            View_Rider_Employee k = new View_Rider_Employee();
            k.Show();
        }

        private void btnstockdetails_Click(object sender, EventArgs e)
        {
            this.Hide();
            Stock_DEmployee p = new Stock_DEmployee();
            p.Show();
        }

        private void btnorders_Click(object sender, EventArgs e)
        {
            this.Hide();
            View_Order n = new View_Order();
            n.Show();
        }

        private void btnaddshop_Click(object sender, EventArgs e)
        {
            this.Hide();
            Add_Shop l = new Add_Shop();
            l.Show();
        }

        private void btnlogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            LogIn h = new LogIn();
            h.Show();
        }
    }
}
