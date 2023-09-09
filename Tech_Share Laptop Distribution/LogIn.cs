using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using System.Resources;
using Tech_Share_Laptop_Distribution.DL;
using Tech_Share_Laptop_Distribution.BL;

namespace Tech_Share_Laptop_Distribution
{
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }

        private void I01_Load(object sender, EventArgs e)
        {
            CredientialsDL.LoadFromCSV();
        }

        private void TxtPassword_TextChanged_1(object sender, EventArgs e)
        {

        }
        bool passOn = true;
        private void txtPassword_TrailingIconClick(object sender, EventArgs e)
        {
            if (passOn)
            {
                txtPassword.TrailingIcon = Resources.Resource1.eye_20px;
                txtPassword.Password = false;
                passOn = false;
            }
            else
            {
                txtPassword.TrailingIcon = Resources.Resource1.hide_20px;
                txtPassword.Password = true;
                passOn = true;
            }

        }

        private void TxtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            txtEmail.Clear();
            txtPassword.Clear();
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void Forgetlabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ForgetPWD f1 = new ForgetPWD();
            this.Hide();
            f1.Show();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            string Email = txtEmail.Text;
            string Password = txtPassword.Text;
            // greater than 10 bcz ( @gmail.com ) these are 10 characters
            if (Email.Length>10)
            {
                if (Password.Length < 8)
                {
                    MessageBox.Show("Invalid Password 😕 \n Must be of at least 8 characters", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    string data = CredientialsDL.CheckRole(Email, Password);
                    if (data != "NA")
                    {
                        string info = "Welcome " + data + " ! " + "\n Succesfully Login 🤗";
                        MessageBox.Show(info, "Welcome", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Hide();
                        if (data == "Admin")
                        {
                            Manager_DashBoard f1 = new Manager_DashBoard();
                            f1.Show();
                        }
                        else if (data == "Employee")
                        {
                            Employee_DashBoard Employee = new Employee_DashBoard();
                            Employee.Show();
                        }
                        else
                        {
                            Rider_Dashoboad rider = new Rider_Dashoboad();
                            rider.Show();
                        }
                    }
                    else
                    {
                        string info = "The Email or password Combination is Incorrect 😰\n Try again or Reset Password";
                        MessageBox.Show(info, "Wrong Data!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            else
            {
                MessageBox.Show("Invalid Email 😕 \n Plz Check it again", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
