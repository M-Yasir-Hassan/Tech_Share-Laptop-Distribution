using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tech_Share_Laptop_Distribution.BL
{
    internal class ComplaintsBL
    {
        private string type;
        private string Complaint;

        public ComplaintsBL(string type, string complaint)
        {
            this.type = type;
            Complaint = complaint;
        }

        public string Type { get => type; set => type = value; }
        public string Complaint1 { get => Complaint; set => Complaint = value; }
    }
}
