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
    public partial class Employee_DashBoard : Form
    {
        public Employee_DashBoard()
        {
            InitializeComponent();
        }

        private void btnaddrider_Click(object sender, EventArgs e)
        {
            this.Hide();
            Add_Rider_Employee adrider = new Add_Rider_Employee();
            adrider.Show();
        }

        private void btnaddshop_Click(object sender, EventArgs e)
        {
            this.Hide();
            Add_Shop newshop = new Add_Shop();
            newshop.Show();
        }

        private void btnviewrider_Click(object sender, EventArgs e)
        {
            this.Hide();
            View_Rider_Employee vrider = new View_Rider_Employee();
            vrider.Show();
        }

        private void btnorders_Click(object sender, EventArgs e)
        {
            this.Hide();
            View_Order view = new View_Order();
            view.Show();
        }

        private void btnlogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            LogIn login = new LogIn();
            login.Show();
        }

        private void btnstockdetails_Click(object sender, EventArgs e)
        {
            this.Hide();
            Stock_DEmployee n = new Stock_DEmployee();
            n.Show();
        }

        private void btnriderdetails_Click(object sender, EventArgs e)
        {
            
        }

        private void Employee_DashBoard_Load(object sender, EventArgs e)
        {

        }
    }
}
