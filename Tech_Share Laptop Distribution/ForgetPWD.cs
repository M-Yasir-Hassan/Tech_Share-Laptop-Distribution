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
    public partial class ForgetPWD : Form
    {
        public ForgetPWD()
        {
            InitializeComponent();
        }


        bool passOn = true;
        private void txtPassword_TrailingIconClick(object sender, EventArgs e)
        {
            if (passOn)
            {
                txtNewPass.TrailingIcon = Resources.Resource1.eye_20px;
                txtNewPass.Password = false;
                passOn = false;
            }
            else
            {
                txtNewPass.TrailingIcon = Resources.Resource1.hide_20px;
                txtNewPass.Password = true;
                passOn = true;
            }

        }
        private void ForgetPWD_Load(object sender, EventArgs e)
        {
            Role.Items.Add("Admin");
            Role.Items.Add("Employee");
            Role.Items.Add("Rider");
            Role.Items.Add("None");
            Role.SelectedItem = "None";
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            txtEmail.Clear();
            txtNewPass.Clear();
            txtComNewPass.Clear();
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            string role = Role.SelectedItem.ToString();
            string Newpassword = txtNewPass.Text;
            string ConfirmPassword = txtComNewPass.Text;
            if (Newpassword.Length < 8 && ConfirmPassword.Length < 8)
            {
                MessageBox.Show("Invalid Password 😕 \n Must be of at least 8 characters", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (Newpassword == ConfirmPassword)
                {
                    if (CredientialsDL.ResetPassword(email, Newpassword, role))
                    {
                        MessageBox.Show("Succesfully changed The Password 🤫", "Congratulation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LogIn f1 = new LogIn();
                        f1.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Invalid Email ! 😰 " + ConfirmPassword, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Password doesn't Match ! 😶", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void Role_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void MaterialButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            LogIn m = new LogIn();
            m.Show();
        }
    }
}
