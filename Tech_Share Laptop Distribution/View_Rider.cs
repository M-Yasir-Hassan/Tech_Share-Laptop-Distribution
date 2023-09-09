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
    public partial class View_Rider : Form
    {
        public View_Rider()
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

        private void View_Rider_Load(object sender, EventArgs e)
        {
            RiderDL.RidersList.Clear();
            RiderDL.ClearList();
            RiderDL.LoadFromCSV();
            this.RidersGrid.DataSource = RiderDL.RidersList;
            this.RidersGrid.Columns[4].Width = 200;
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you Want to delete The Rider?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DialogResult.Yes == result)
            {
                if (RidersGrid.RowCount > 0)
                {

                    RiderDL.LoadFromCSV();
                    RiderBL em = (RiderBL)RidersGrid.CurrentRow.DataBoundItem;
                    RiderDL.DeleteRider(em);
                    Binddata();
                    RiderDL.addintofileList();
                    RiderDL.ClearList();
                    RiderDL.LoadFromCSV();


                }
            }
        }
        public void Binddata()
        {
            this.RidersGrid.DataSource = null;
            this.RidersGrid.DataSource = RiderDL.RidersList;
            this.RidersGrid.Refresh();
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            RiderBL em = (RiderBL)RidersGrid.CurrentRow.DataBoundItem;
            UpdateRider f1 = new UpdateRider(em);
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

        private void Btnmanagesales_Click(object sender, EventArgs e)
        {
            ViewComplaints f1 = new ViewComplaints();
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
