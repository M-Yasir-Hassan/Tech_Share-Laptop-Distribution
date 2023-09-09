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
    public partial class View_Rider_Employee : Form
    {
        public View_Rider_Employee()
        {
            InitializeComponent();
        }

        private void btnaddrider_Click(object sender, EventArgs e)
        {
            this.Hide();
            Add_Rider_Employee ad = new Add_Rider_Employee();
            ad.Show();
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
        private void View_Rider_Employee_Load(object sender, EventArgs e)
        {
            this.gridviewridersemployee.DataSource = RiderDL.RidersList;
        }

        private void btnviewrider_Click_1(object sender, EventArgs e)
        {

        }

        private void btnstockdetails_Click(object sender, EventArgs e)
        {
            this.Hide();
            Stock_DEmployee k = new Stock_DEmployee();
            k.Show();
        }

        private void btnorders_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            View_Order n = new View_Order();
            n.Show();
        }

        private void btnaddshop_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Add_Shop a = new Add_Shop();
            a.Show();
        }

        private void btnriderdetails_Click(object sender, EventArgs e)
        {

        }

        private void btnlogout_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            LogIn l = new LogIn();
            l.Show();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you Want to delete The Shop?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DialogResult.Yes == result)
            {
                if (gridviewridersemployee.RowCount > 0)
                {


                    RiderBL em = (RiderBL)gridviewridersemployee.CurrentRow.DataBoundItem;
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
            this.gridviewridersemployee.DataSource = null;
            this.gridviewridersemployee.DataSource = RiderDL.RidersList;
            this.gridviewridersemployee.Refresh();
        }
    }
}
