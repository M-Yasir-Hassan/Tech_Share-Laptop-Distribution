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
    public partial class AddRider : Form
    {
        public AddRider()
        {
            InitializeComponent();
        }

        private void Btnaddemployee_Click(object sender, EventArgs e)
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

        private void Btnlogout_Click(object sender, EventArgs e)
        {
            LogIn f1 = new LogIn();
            this.Hide();
            f1.Show();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            txtCnic.Clear();
            txtPhoneNumber.Clear();
            txtAddress.Clear();
            txtEmail.Clear();
        }

        private void Btnstockdetails_Click(object sender, EventArgs e)
        {
            View_Rider f1 = new View_Rider();
            this.Hide();
            f1.Show();
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            bool checkError = false;
            string name = txtName.Text;
            string cnic = txtCnic.Text;
            string email = txtEmail.Text;
            string phoneNumber = txtPhoneNumber.Text;
            string address = txtAddress.Text;
            int salary = int.Parse(ComboBoxSalary.Text);
            string gender = "";
            if (MaleCheck.Checked)
            {
                gender = "Male";
                genderError.Text = " ";
            }
            else if (FemaleCheck.Checked)
            {
                gender = "Female";
                genderError.Text = " ";
            }
            else
            {
                checkError = true;
                genderError.Text = "Please select One of the Genders";
            }
            // Object containing All the data that has to be stored........

            RiderBL obj = new RiderBL(name, cnic, email, phoneNumber, address, salary, gender);
            //  Validation for textboxes.........
            if (name.Length < 1)
            {
                checkError = true;
                bool Check = false;
                Check = RiderDL.ContainsName(obj);
                if (!Check)
                {
                    nameError.Text = "Name Already Exist !";
                }
                else
                    nameError.Text = "Name can't be Empty !";
            }
            if (cnic.Length != 13 || cnic[0] != '3')
            {
                checkError = true;
                bool Check = false;
                Check = RiderDL.ContainsCNIC(obj);
                if (!Check)
                {
                    cnicError.Text = "CNIC Already Exist !";
                }
                else
                    cnicError.Text = "Invalid CNIC";
            }
            if (!IsValidEmail(email) || email.Length < 11)
            {
                checkError = true;
                bool Check = false;
                Check = RiderDL.ContainsEmail(obj);
                if (!Check)
                {
                    emailError.Text = "Email Already Exist !";
                }
                else
                    emailError.Text = "Invalid Email";
            }
            if (phoneNumber.Length != 11 || phoneNumber[0] != '0' || phoneNumber[1] != '3')
            {
                checkError = true;
                bool Check = false;
                Check = RiderDL.ContainsNumber(obj);
                if (!Check)
                {
                    numberError.Text = "Phone Number Already Exist !";
                }
                else
                    numberError.Text = "Invalid Number";
            }
            if (address.Length < 1)
            {
                adressError.Text = "Adress can't be Emplty !";
            }
            if (!checkError)
            {
                MessageBox.Show("Rider Successfully Entered !", "Congratulation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                RiderDL.InsertAtEnd(obj);
                RiderDL.storeincsv();
                RiderDL.LoadFromCSV();
                txtName.Clear();
                txtEmail.Clear();
                txtCnic.Clear();
                txtAddress.Clear();
                txtPhoneNumber.Clear();
                ComboBoxSalary.SelectAll();
            }

        }
        bool IsValidEmail(string eMail)
        {
            bool Result = true;

            try
            {
                var eMailValidator = new System.Net.Mail.MailAddress(eMail);

                Result = (eMail.LastIndexOf(".") > eMail.LastIndexOf("@"));
            }
            catch
            {
                Result = false;
            };

            return Result;
        }

        private void TxtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ' ' || e.KeyChar >= 'a' && e.KeyChar <= 'z' || e.KeyChar >= 'A' && e.KeyChar <= 'Z')
            {
                e.Handled = false; //Do not reject the input
            }
            else
            {
                e.Handled = true; //Reject the input
            }
        }

        private void TxtCnic_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' && e.KeyChar <= '9')
            {
                e.Handled = false; //Do not reject the input
            }
            else
            {
                e.Handled = true; //Reject the input
            }
        }

        private void TxtEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == '@' || e.KeyChar == '.' || e.KeyChar >= 'a' && e.KeyChar <= 'z' || e.KeyChar >= 'A' && e.KeyChar <= 'Z')
            {
                e.Handled = false; //Do not reject the input
            }
            else
            {
                e.Handled = true; //Reject the input
            }
        }

        private void TxtPhoneNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' && e.KeyChar <= '9')
            {
                e.Handled = false; //Do not reject the input
            }
            else
            {
                e.Handled = true; //Reject the input
            }
        }

        private void TxtAddress_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == ' ' || e.KeyChar >= 'a' && e.KeyChar <= 'z' || e.KeyChar >= 'A' && e.KeyChar <= 'Z')
            {
                e.Handled = false; //Do not reject the input
            }
            else
            {
                e.Handled = true; //Reject the input
            }
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

        private void Btnviewrider_Click(object sender, EventArgs e)
        {

        }

        private void Btnorders_Click(object sender, EventArgs e)
        {
            ViewOrdersManager f1 = new ViewOrdersManager();
            this.Hide();
            f1.Show();
        }

        private void Btnmanagesales_Click(object sender, EventArgs e)
        {
            ViewComplaints f1 = new ViewComplaints();
            this.Hide();
            f1.Show();
        }
    }
}
