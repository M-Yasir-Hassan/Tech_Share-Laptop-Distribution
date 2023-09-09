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
    public partial class Manage_Route : Form
    {
        public Manage_Route()
        {
            InitializeComponent();
            webBrowser1.ScriptErrorsSuppressed = true;
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            string street = txtStreet.Text;
            string city = txtCity.Text;
            string state = txtState.Text;
            string zip = txtZip.Text;
            StringBuilder queryaddress = new StringBuilder();
            queryaddress.Append("http://google.com/maps?q=");
            if (street != string.Empty)
            {
                queryaddress.Append(street + "," + "+");
            }
            if (city != string.Empty)
            {
                queryaddress.Append(city + "," + "+");
            }
            if (state != string.Empty)
            {
                queryaddress.Append(state + "," + "+");
            }
            if (zip != string.Empty)
            {
                queryaddress.Append(zip + "," + "+");
            }
            webBrowser1.Navigate(queryaddress.ToString());
        }

        private void Btnaddrider_Click(object sender, EventArgs e)
        {
            View_Shops_Rider f1 = new View_Shops_Rider();
            this.Hide();
            f1.Show();
        }

        private void Btnstockdetails_Click(object sender, EventArgs e)
        {

        }

        private void Btnreports_Click(object sender, EventArgs e)
        {

        }

        private void Btnmanagesales_Click(object sender, EventArgs e)
        {
            File_Complain f1 = new File_Complain();
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

        private void BtnCompleteOrder_Click(object sender, EventArgs e)
        {
            OrderBL obj = new OrderBL();
            if (OrderDL.OrderList.Count > 0)
            {
                obj = OrderDL.OrderList[OrderDL.OrderList.Count - 1];
                DialogResult result = MessageBox.Show("Are you sure want to add this order as completed? ", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (DialogResult.Yes == result)
                {
                    ShopDL.SndMail_OrderCompleted("yasir.hsn890@gmail.com");
                    OrderDL.CompletedOrder.Add(obj);
                    OrderDL.addToFileCompletedOrder(obj);
                    OrderDL.OrderList.RemoveAt(OrderDL.OrderList.Count - 1);
                    OrderDL.AddToCSV();
                }
            }
            else
            {
                MessageBox.Show("No orders Left to mark as completed ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
    }
}
