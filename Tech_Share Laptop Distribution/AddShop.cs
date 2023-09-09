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
    public partial class Add_Shop : Form
    {
        public Add_Shop()
        {
            InitializeComponent();
        }

        private void Btnaddrider_Click(object sender, EventArgs e)
        {
            Add_Rider_Employee f1 = new Add_Rider_Employee();
            this.Hide();
            f1.Show();
        }

        private void Btnviewrider_Click(object sender, EventArgs e)
        {
            View_Rider_Employee f1 = new View_Rider_Employee();
            this.Hide();
            f1.Show();
        }

        private void Btnstockdetails_Click(object sender, EventArgs e)
        {
            Stock_DEmployee f1 = new Stock_DEmployee();
            this.Hide();
            f1.Show();
        }

        private void Btnorders_Click(object sender, EventArgs e)
        {
            View_Order f1 = new View_Order();
            this.Hide();
            f1.Show();
        }

        private void Btnaddshop_Click(object sender, EventArgs e)
        {
            Add_Shop f1 = new Add_Shop();
            this.Hide();
            f1.Show();
        }

        private void Btnlogout_Click(object sender, EventArgs e)
        {
            LogIn f1 = new LogIn();
            this.Hide();
            f1.Show();
        }
    }
}
