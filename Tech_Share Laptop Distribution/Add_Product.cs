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
    public partial class addproduct : Form
    {
        public addproduct()
        {
            InitializeComponent();
        }

        private void addproduct_Load(object sender, EventArgs e)
        {

        }

        private void btnsubmitaddproduct_Click(object sender, EventArgs e)
        {
            if (txtlaptopname.Text == null)
            {
                lbllaptopname.Text = "* Name cannot be empty";
            }
            else { lbllaptopname.Text = ""; }
            if (txtlaptopmodel.Text == null) { lbllaptopmodel.Text = "* Laptop Model can't be Empty"; } else { lbllaptopmodel.Text = ""; }
            if (txtlaptopprocessor.Text == null) { lbllaptopprocessor.Text = "* Laptop Prcessor cant be Null"; } else { lbllaptopprocessor.Text = ""; }
            if (txtlaptopram.Text == null) { lbllaptopram.Text = "* Laptop Ram cannot be empty "; } else { lbllaptopram.Text = ""; }
            if (txtlaptopgrahiccard.Text == null) { lbllaptopgraphiccard.Text = "* Graphic card item cannot be empty"; } else { lbllaptopgraphiccard.Text = ""; }
            if(txthddsdd.Text == null) { lbllaptopssd.Text = "* Laptop SSD and HDD cannot be empty"; } else { lbllaptopssd.Text = ""; }
            if(txtlaptopquantity.Text==null || txtlaptopquantity.Text == "0") { lbllaptopquantity.Text = "* Quantity of Laptop never be null"; }
            if(txtlaptopname.Text != null && txtlaptopmodel.Text != null && txtlaptopprocessor.Text != null && txtlaptopram.Text != null && txtlaptopgrahiccard.Text!= null && txthddsdd.Text != null && txtlaptopquantity.Text != null) 
            {
                StockBL newrecord = new StockBL(txtlaptopname.Text,txtlaptopmodel.Text,txtlaptopprocessor.Text,txtlaptopram.Text,"Not Defined Now",txtlaptopgrahiccard.Text,txtlaptopquantity.Text,"At Delivery");
                StockDL.StockList.Add(newrecord);
                StockDL.AddProducttofile(newrecord);
                DialogResult d;
                d = MessageBox.Show("Stock Added Successfully, Do you want to Add More Stock ?", "Add Stock", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (d == DialogResult.Yes)
                {
                    this.Hide();
                    addproduct n = new addproduct();
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
    }
}
