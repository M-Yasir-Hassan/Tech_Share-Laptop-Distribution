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
    public partial class UpdateEmployee : Form
    {
        EmployeeBL obj = new EmployeeBL();
        public UpdateEmployee(EmployeeBL temp)
        {
            obj = temp;
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

        private void Btnviewrider_Click(object sender, EventArgs e)
        {
            AddRider f1 = new AddRider();
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

        private void BtnSave_Click(object sender, EventArgs e)
        {
            bool chk = true;
            string cnic = txtCnic.Text;
            string email = txtEmail.Text;
            string phoneNumber = txtPhoneNumber.Text;
            string address = txtAddress.Text;
            int salary = int.Parse(ComboBoxSalary.Text);
            if (cnic.Length != 13 && cnic[0] != '3')
            {
                cnicError.Text = "Invalid Cnic";
                chk = false;
            }
            bool valid = IsValidEmail(email);
            if (!valid)
            {
                emailError.Text = "Inavlid Email";
                chk = false;
            }
            if (phoneNumber.Length != 11 && phoneNumber[0] != '0' && phoneNumber[1] != '3')
            {
                NumberError.Text = "Invalid Number";
                chk = false;
            }
            if (address.Length < 1)
            {
                AdressError.Text = "Address can't be Empty !";
                chk = false;
            }
            if (chk)
            {
                EmployeeBL update = new EmployeeBL(obj.Name, cnic, email, phoneNumber, address, salary, obj.Gender);
                DialogResult result = MessageBox.Show("Are You Sure want to update Data?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (DialogResult.Yes == result)
                {
                    bool checkUpdate = EmployeeDL.updateInfo(update);
                    EmployeeDL.addintofileList();
                    if (checkUpdate)
                    {
                        MessageBox.Show("Successfully Updated Employee Data", "Congratulation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }





        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            txtCnic.Clear();
            txtEmail.Clear();
            txtPhoneNumber.Clear();
            txtAddress.Clear();
            ComboBoxSalary.Text = "None";
        }

        private void UpdateEmployee_Load(object sender, EventArgs e)
        {
            txtName.Text = obj.Name;
        }

        private void Label5_Click(object sender, EventArgs e)
        {

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

        private void TxtCnic_TextChanged(object sender, EventArgs e)
        {
            cnicError.Text = " ";
        }

        private void TxtEmail_TextChanged(object sender, EventArgs e)
        {
            emailError.Text = " ";
        }

        private void TxtPhoneNumber_TextChanged(object sender, EventArgs e)
        {
            NumberError.Text = " ";
        }

        private void TxtAddress_TextChanged(object sender, EventArgs e)
        {

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

        private void TxtAddress_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == ',' || e.KeyChar == ' ' || e.KeyChar >= 'a' && e.KeyChar <= 'z' || e.KeyChar >= 'A' && e.KeyChar <= 'Z')
            {
                e.Handled = false; //Do not reject the input
            }
            else
            {
                e.Handled = true; //Reject the input
            }
        }

        private void Btnstockdetails_Click(object sender, EventArgs e)
        {
            View_Rider f1 = new View_Rider();
            this.Hide();
            f1.Show();
        }
    }
}
