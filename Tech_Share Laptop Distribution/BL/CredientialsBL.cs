using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tech_Share_Laptop_Distribution.BL
{
    public class CredientialsBL
    {
        private string Email;
        private string Password;
        private string Role;
        // Constructors with 2 or 3 parameters
        public CredientialsBL(string email, string pwd, string role)
        {
            this.Email1 = email;
            this.Password1 = pwd;
            this.Role1 = role;
        }

        public CredientialsBL(string email, string password)
        {
            this.Email1 = email;
            this.Password1 = password;
            this.Role1 = "NA";
        }

        public CredientialsBL()
        {
            this.Email1 = "NA";
            this.Password1 = "NA";
            this.Role1 = "NA";
        }

        // Getter & Setters for storing Credientials Using Encapsulation
        public string Email1 { get => Email; set => Email = value; }
        public string Password1 { get => Password; set => Password = value; }
        public string Role1 { get => Role; set => Role = value; }
    }
}
