using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Tech_Share_Laptop_Distribution.BL;
using Tech_Share_Laptop_Distribution.DL;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Tech_Share_Laptop_Distribution
{
    public partial class Add_Rider_Employee : Form
    {
        public Add_Rider_Employee()
        {
            InitializeComponent();
        }

        private void btnaddshop_Click(object sender, EventArgs e)
        {
            this.Hide();
            Add_Shop newshop = new Add_Shop();
            newshop.Show();
        }

        private void btnlogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            LogIn login = new LogIn();
            login.Show();
        }
        private void btnriderdetails_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void Add_Rider_Employee_Load(object sender, EventArgs e)
        {

        }

        private void btnaddrider_Click(object sender, EventArgs e)
        {

        }

        private void btnviewrider_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            View_Rider_Employee vrider = new View_Rider_Employee();
            vrider.Show();
        }

        private void btnstockdetails_Click(object sender, EventArgs e)
        {

        }

        private void btnorders_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            View_Order view = new View_Order();
            view.Show();
        }

        private void btnaddshop_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Add_Shop ad = new Add_Shop();
            ad.Show();
        }

        private void btnlogout_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            LogIn a = new LogIn();
            a.Show();
        }

        private void txtriderphonenumber_TextChanged(object sender, EventArgs e)
        {

        }
        public bool ridersalarycheck(string salary)
        {

            int sal = int.Parse(salary);
            if (sal > 40000 && sal < 70000) { return true; }
            return false;

        }
        private void btneaddrider_Click(object sender, EventArgs e)
        {
            int count = 0;
            if (checknumber(txtriderphonenumber.Text) == false)
            {
                lblphonenumber.Text = "* Invalid Phone Name";
            }
            else
            {
                lblphonenumber.Text = "";
                count++;
            }
            if (checkemail(txtemailrider.Text) == false)
            {
                lblrideremail.Text = "* Invalid Email";
            }
            else
            {
                lblrideremail.Text = "";
                count++;
            }
            if (checkCnic(txtridercnic.Text) == false)
            {
                lblridercnic.Text = "* Invalid CNIC";
            }
            else
            {
                lblridercnic.Text = "";
                count++;
            }
            if (checkaddress(rtxtaddress.Text) == false) { lbladdress.Text = "* Invalid Address"; }
            else { lbladdress.Text = ""; }
            if (txtridersalary.Text.Length > 1)
            {
                if (ridersalarycheck(txtridersalary.Text) == false)
                {
                    lblsalaryrider.Text = "* Invalid Salary";
                }
                else
                {
                    lblsalaryrider.Text = "";
                }
            }
            if (checkgender(txtridergender.Text) == true)
            {
                lblridergender.Text = " ";
            }
            else { lblridergender.Text = "* Invalid Gender"; }


            if (checknumber(txtriderphonenumber.Text) && checkemail(txtemailrider.Text) && checkCnic(txtridercnic.Text) && checkaddress(rtxtaddress.Text) && ridersalarycheck(txtridersalary.Text) && checkgender(txtridergender.Text))
            {
                RiderBL newrider = new RiderBL(txtridername.Text, txtridercnic.Text, txtemailrider.Text, txtriderphonenumber.Text, rtxtaddress.Text, int.Parse(txtridersalary.Text), txtridergender.Text);
                RiderDL.InsertAtEnd(newrider);
                RiderDL.storeincsv();
                DialogResult d;
                d = MessageBox.Show("Rider Added Successfully, Do you want to Add More Riders ?", "Add Rider", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (d == DialogResult.Yes)
                {
                    this.Hide();
                    Add_Rider_Employee n = new Add_Rider_Employee();
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
        public bool checkgender(string gender)
        {
            if (gender == "male" || gender == "Male" || gender == "MALE" || gender == "female" || gender == "Female" || gender == "FEMALE")
            {
                return true;
            }
            return false;

        }
        public bool checkaddress(string address)
        {
            int countt = 0;
            for (int i = 0; i < address.Length; i++)
            {
                if (address[i] == ' ')
                {
                    countt++;
                }
            }
            if (countt > 0)
            {
                return false;
            }
            return true;
        }
        public bool checknumber(string number)
        {
            if (number.Length == 11 && number[0] == '0' && number[1] == '3')
            {
                return true;
            }
            return false;
        }
        public bool checkemail(string email)
        {
            if (email != null && email.Length > 15)
            {
                if (email[email.Length - 1] == 'm' && email[email.Length - 2] == 'o' && email[email.Length - 3] == 'c' && email[email.Length - 4] == '.' && email[email.Length - 5] == 'l' && email[email.Length - 6] == 'i' && email[email.Length - 7] == 'a' && email[email.Length - 8] == 'm' && email[email.Length - 9] == 'g' && email[email.Length - 10] == '@')
                {
                    return true;
                }
            }
            return false;
        }
        public bool checkCnic(string cnic)
        {
            int countt = 0;
            for (int i = 0; i < cnic.Length; i++)
            {
                if (cnic[i] == '0' || cnic[i] == '1' || cnic[i] == '2' || cnic[i] == '3' || cnic[i] == '4' || cnic[i] == '5' || cnic[i] == '6' || cnic[i] == '7' || cnic[i] == '8' || cnic[i] == '9')
                {
                    countt++;
                }
            }
            if (countt == 13 && cnic.Length == 13 && cnic[0] == '3')
            {
                return true;
            }
            return false;
        }
    }
}
