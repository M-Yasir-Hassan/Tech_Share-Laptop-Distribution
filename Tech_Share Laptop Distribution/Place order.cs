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
    public partial class Place_order : Form
    {
        public Place_order()
        {
            InitializeComponent();
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Btnsubmitplaceorder_Click(object sender, EventArgs e)
        {
            if (txtquantity.Text == null || txtquantity.Text == "0")
            { lblproductquantity.Text = "Invalid Quantity"; }
            else { lblproductquantity.Text = ""; }
            if (txtshopname.Text == null)
            {
                lblshopname.Text = "Invalid ShopName";
            }
            else { lblshopname.Text = ""; }
            if (txtshopname.Text != null && int.Parse(txtquantity.Text) > 0)
            {
                OrderBL neworder = new OrderBL(ordernamecombo.SelectedIndex.ToString(),txtshopname.Text,txtquantity.Text);
                OrderDL.addToList(neworder);
                OrderDL.addToFileOrder(neworder);
                DialogResult d;
                d = MessageBox.Show("Stock Added Successfully, Do you want to Add More Stock ?", "Add Stock", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (d == DialogResult.Yes)
                {
                    this.Hide();
                    Stock_DEmployee n = new Stock_DEmployee();
                    n.Show();
                }
                else
                {
                    this.Hide();
                    Employee_DashBoard m = new Employee_DashBoard();
                    m.Show();
                }
            }
        }
        private void btnaddrider_Click(object sender, EventArgs e)
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

        private void btnstockdetails_Click(object sender, EventArgs e)
        {
            this.Hide();
            Stock_DEmployee j = new Stock_DEmployee();
            j.Show();
        }

        private void btnorders_Click(object sender, EventArgs e)
        {
            this.Hide();
            View_Order v1 = new View_Order();
            v1.Show();
        }

        private void btnaddshop_Click(object sender, EventArgs e)
        {
            this.Hide();
            Add_Shop a = new Add_Shop();
            a.Show();
        }

        private void btnridercomplaints_Click(object sender, EventArgs e)
        {

        }

        private void btnlogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            LogIn a = new LogIn();
            a.Show();
        }

        private void ordernamecombo_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Place_order_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < StockDL.StockList.Count; i++)
            {
                ordernamecombo.Items.Add(StockDL.StockList[i].Name + " " + StockDL.StockList[i].Model);
            }
        }
    }
}