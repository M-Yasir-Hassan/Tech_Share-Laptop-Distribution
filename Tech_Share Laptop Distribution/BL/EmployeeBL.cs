using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tech_Share_Laptop_Distribution.BL
{
    public class EmployeeBL
    {
        private string name;
        private string cnic;
        private string email;
        private string phone_no;
        private string adress;
        private long salary;
        private string gender;

        public string Name { get => name; set => name = value; }
        public string Cnic { get => cnic; set => cnic = value; }
        public string Email { get => email; set => email = value; }
        public string Phone_no { get => phone_no; set => phone_no = value; }
        public string Adress { get => adress; set => adress = value; }
        public long Salary { get => salary; set => salary = value; }
        public string Gender { get => gender; set => gender = value; }

        public EmployeeBL(string name, string cnic, string email, string phone_no, string adress, long salary, string gender)
        {
            this.name = name;
            this.cnic = cnic;
            this.email = email;
            this.phone_no = phone_no;
            this.adress = adress;
            this.salary = salary;
            this.gender = gender;
        }

        public EmployeeBL()
        {
            this.name = null;
            this.cnic = null;
            this.email = null;
            this.phone_no = null;
            this.adress = null;
            this.salary = 0;
            this.gender = null;
        }
    }
}

