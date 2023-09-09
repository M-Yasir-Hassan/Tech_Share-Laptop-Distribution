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
    public partial class ViewEmployee : Form
    {

        public ViewEmployee()
        {
            InitializeComponent();
        }


        private void PictureBox1_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void FlowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ViewEmployee_Load(object sender, EventArgs e)
        {
            this.dataGridView1.DataSource = EmployeeDL.EmployeesList;
            this.dataGridView1.Columns[4].Width = 200;
        }

        private void Button10_Click(object sender, EventArgs e)
        {
            AddEmployee f1 = new AddEmployee();
            this.Hide();
            f1.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Hide();
            LogIn f1 = new LogIn();
            f1.Show();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            EmployeeBL em = (EmployeeBL)dataGridView1.CurrentRow.DataBoundItem;
            UpdateEmployee f1 = new UpdateEmployee(em);
            this.Hide();
            f1.Show();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you Want to delete The Employee?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DialogResult.Yes == result)
            {
                if (dataGridView1.RowCount > 0)
                {

                    EmployeeDL.LoadFromCSV();
                    EmployeeBL em = (EmployeeBL)dataGridView1.CurrentRow.DataBoundItem;
                    EmployeeDL.DeleteEmployee(em);
                    Binddata();
                    EmployeeDL.addintofileList();
                    EmployeeDL.ClearList();
                    EmployeeDL.LoadFromCSV();


                }
            }
        }
        public void Binddata()
        {
            this.dataGridView1.DataSource = null;
            this.dataGridView1.DataSource = EmployeeDL.EmployeesList;
            this.dataGridView1.Refresh();
        }

        private void Btndashboard_Click(object sender, EventArgs e)
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

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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

        private void Btnaddrider_Click(object sender, EventArgs e)
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
