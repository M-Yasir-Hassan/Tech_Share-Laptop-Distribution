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
    public partial class File_Complain : Form
    {
        public File_Complain()
        {
            InitializeComponent();
        }

        private void Btnaddrider_Click(object sender, EventArgs e)
        {
            View_Shops_Rider f1 = new View_Shops_Rider();
            this.Hide();
            f1.Show();
        }

        private void Btnviewrider_Click(object sender, EventArgs e)
        {
            Manage_Route f1 = new Manage_Route();
            this.Hide();
            f1.Show();
        }

        private void Btnstockdetails_Click(object sender, EventArgs e)
        {

        }

        private void Btnmanagesales_Click(object sender, EventArgs e)
        {

        }

        private void Btnlogout_Click(object sender, EventArgs e)
        {
            LogIn f1 = new LogIn();
            this.Hide();
            f1.Show();
        }

        private void MaterialMultiLineTextBox21_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ',' || e.KeyChar == 13)
            {
                e.Handled = true; //Reject the input
            }
            else
            {
                e.Handled = false;//Do not reject the input
            }
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            string type = typeCombo.Text;
            string complaint = txtComplaint.Text;
            if (complaint.Length > 1)
            {
                DialogResult result = MessageBox.Show("Do You really want to file a complaint ?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (DialogResult.Yes == result)
                {
                    ComplaintsBL obj = new ComplaintsBL(type, complaint);
                    ComplaintsDL.Complainlist.Add(obj);
                    ComplaintsDL.AddToComplainCSV();
                    txtComplaint.Clear();
                }
            }
            else
            {
                txtComplaint.Text = "type Something Here Before Sumbiting the Complaint";
            }
        }
    }
}
