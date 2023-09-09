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
    public partial class ViewStock : Form
    {
        public ViewStock()
        {
            InitializeComponent();
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void ViewStock_Load(object sender, EventArgs e)
        {
            this.dataGridView1.DataSource = StockDL.StockList;
        }

        private void Btndashboard_Click(object sender, EventArgs e)
        {
            Manager_DashBoard f1 = new Manager_DashBoard();
            this.Hide();
            f1.Show();
        }

        private void Btnviewemployee_Click(object sender, EventArgs e)
        {
            AddEmployee f1 = new AddEmployee();
            this.Hide();
            f1.Show();
        }

        private void Btnaddrider_Click(object sender, EventArgs e)
        {
            ViewEmployee f1 = new ViewEmployee();
            this.Hide();
            f1.Show();
        }

        private void Btnviewrider_Click(object sender, EventArgs e)
        {
            AddRider f1 = new AddRider();
            this.Hide();
            f1.Show();
        }

        private void Btnstockdetails_Click(object sender, EventArgs e)
        {
            View_Rider f1 = new View_Rider();
            this.Hide();
            f1.Show();
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Btncompaints_Click(object sender, EventArgs e)
        {
            About f1 = new About();
            this.Hide();
            f1.Show();
        }

        private void Btnmanagesales_Click(object sender, EventArgs e)
        {
            ViewComplaints f1 = new ViewComplaints();
            this.Hide();
            f1.Show();
        }

        private void Btnlogout_Click(object sender, EventArgs e)
        {
            LogIn f1 = new LogIn();
            this.Hide();
            f1.Show();
        }

        private void Btnorders_Click(object sender, EventArgs e)
        {
            ViewOrdersManager f1 = new ViewOrdersManager();
            this.Hide();
            f1.Show();
        }
    }
}
