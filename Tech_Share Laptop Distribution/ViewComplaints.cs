using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tech_Share_Laptop_Distribution.BL;
using Tech_Share_Laptop_Distribution.DL;

namespace Tech_Share_Laptop_Distribution
{
    public partial class ViewComplaints : Form
    {
        public int value = 0;
        public int length = ComplaintsDL.Complainlist.Count;
        public ViewComplaints()
        {
            InitializeComponent();
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

        private void Btnreports_Click(object sender, EventArgs e)
        {
            ViewStock f1 = new ViewStock();
            this.Hide();
            f1.Show();
        }

        private void Btncompaints_Click(object sender, EventArgs e)
        {
            About f1 = new About();
            this.Hide();
            f1.Show();
        }

        private void Btnlogout_Click(object sender, EventArgs e)
        {
            LogIn f1 = new LogIn();
            this.Hide();
            f1.Show();
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void MaterialButton1_Click(object sender, EventArgs e)
        {
            if (ComplaintsDL.Complainlist.Count == 0)
            {
                MessageBox.Show("No Complaints for today", "congratulation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                materialMaskedTextBox1.Text = (length).ToString();
                txtType.Text = ComplaintsDL.Complainlist[value].Type;
                txtComplaint.Text = ComplaintsDL.Complainlist[value].Complaint1;
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if ((value + 1) < length)
            {
                value += 1;
                txtType.Text = ComplaintsDL.Complainlist[value].Type;
                txtComplaint.Text = ComplaintsDL.Complainlist[value].Complaint1;
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            if ((value - 1) >= 0)
            {
                value -= 1;
                txtType.Text = ComplaintsDL.Complainlist[value].Type;
                txtComplaint.Text = ComplaintsDL.Complainlist[value].Complaint1;
            }
        }

        private void MaterialMaskedTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void Btnmanagesales_Click(object sender, EventArgs e)
        {

        }

        private void Btnorders_Click(object sender, EventArgs e)
        {
            ViewOrdersManager f1 = new ViewOrdersManager();
            this.Hide();
            f1.Show();
        }
    }
}
