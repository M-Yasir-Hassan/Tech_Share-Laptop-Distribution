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
    public partial class AddEmployee : Form
    {
        public AddEmployee()
        {
            InitializeComponent();
        }

        private void AddEmployee_Load(object sender, EventArgs e)
        {

        }


        private void PictureBox1_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            txtEmail.Clear();
            txtCnic.Clear();
            txtAddress.Clear();
            txtPhoneNumber.Clear();
            ComboBoxSalary.SelectAll();
        }

        private void TxtCnic_TextChanged(object sender, EventArgs e)
        {
            cnicError.Text = " ";
        }



        private void Btndashboard_Click(object sender, EventArgs e)
        {
            Manager_DashBoard f1 = new Manager_DashBoard();
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

        private void Btnlogout_Click(object sender, EventArgs e)
        {
            LogIn f1 = new LogIn();
            this.Hide();
            f1.Show();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            bool chk = false;
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
                RadioBtnError.Text = " ";
                chk = true;
            }
            else if (FemaleCheck.Checked)
            {
                gender = "Female";
                RadioBtnError.Text = " ";
                chk = true;
            }
            else
            {
                RadioBtnError.Text = "Please select One of the Genders";
            }
            if (cnic.Length == 13 && cnic[0] == '3')
            {
                cnicError.Text = " ";
                mailError.Text = " ";
                if (phoneNumber.Length == 11 && phoneNumber[0] == '0' && phoneNumber[1] == '3')
                {
                    NumberError.Text = " ";
                    if (IsValidEmail(email))
                    {
                        if (chk)
                        {
                            nameError.Text = " ";
                            EmployeeBL obj = new EmployeeBL(name, cnic, email, phoneNumber, address, salary, gender);
                            EmployeeDL.LoadFromCSV();
                            bool Check = false;
                            Check = EmployeeDL.ContainsName(obj);
                            if (Check && name.Length > 1)
                            {
                                mailError.Text = " ";
                                Check = EmployeeDL.ContainsEmail(obj);
                                if (Check)
                                {
                                    cnicError.Text = " ";
                                    Check = EmployeeDL.ContainsCNIC(obj);
                                    if (Check)
                                    {
                                        NumberError.Text = " ";
                                        Check = EmployeeDL.ContainsNumber(obj);
                                        if (address.Length < 1)
                                        {
                                            adressError.Text = "Address can't be Emplty ! ";
                                        }
                                        else
                                        {
                                            if (Check)
                                            {
                                                MessageBox.Show("Employee Successfully Entered !", "Congratulation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                EmployeeDL.InsertAtEnd(obj);
                                                EmployeeDL.storeincsv();
                                                EmployeeDL.LoadFromCSV();
                                                txtName.Clear();
                                                txtEmail.Clear();
                                                txtCnic.Clear();
                                                txtAddress.Clear();
                                                txtPhoneNumber.Clear();
                                                ComboBoxSalary.SelectAll();
                                            }
                                            else
                                            {
                                                NumberError.Text = "Phone Number already Exist ! ";
                                            }
                                        }

                                    }
                                    else
                                    {
                                        cnicError.Text = "Cnic already Exist ";
                                    }
                                }
                                else
                                {
                                    mailError.Text = "Email already Exist !";
                                }
                            }
                            else
                            {
                                if (name.Length > 1)
                                    nameError.Text = "Name already Exist !";
                                else
                                    nameError.Text = "Name Can't be emplty !";
                            }
                        }
                    }
                    else
                    {
                        mailError.Text = "Invalid Email ! ";
                    }
                }
                else
                {
                    NumberError.Text = "Invalid Phone Number";
                }

            }
            else
            {
                cnicError.Text = "Invalid CNIC ";
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

        private void TxtEmail_TextChanged(object sender, EventArgs e)
        {

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
