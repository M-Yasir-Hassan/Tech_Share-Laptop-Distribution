using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tech_Share_Laptop_Distribution.BL
{
    public class RiderBL
    {
        private string name;
        private string cnic;
        private string email;
        private string phone_no;
        private string adress;
        private long salary;
        private string gender;

        public RiderBL(string name, string cnic, string email, string phone_no, string adress, long salary, string gender)
        {
            this.Name = name;
            this.Cnic = cnic;
            this.Email = email;
            this.Phone_no = phone_no;
            this.Adress = adress;
            this.Salary = salary;
            this.Gender = gender;
        }

        public string Name { get => name; set => name = value; }
        public string Cnic { get => cnic; set => cnic = value; }
        public string Email { get => email; set => email = value; }
        public string Phone_no { get => phone_no; set => phone_no = value; }
        public string Adress { get => adress; set => adress = value; }
        public long Salary { get => salary; set => salary = value; }
        public string Gender { get => gender; set => gender = value; }

        public RiderBL()
        {
            this.Name = null;
            this.Cnic = null;
            this.Email = null;
            this.Phone_no = null;
            this.Adress = null;
            this.Salary = 0;
            this.Gender = null;
        }
    }
}
