using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tech_Share_Laptop_Distribution.BL;

namespace Tech_Share_Laptop_Distribution.DL
{
    internal class ComplaintsDL
    {

        public static List<ComplaintsBL> Complainlist = new List<ComplaintsBL>();
        public static void AddIntoComplainList(ComplaintsBL obj)
        {
            Complainlist.Add(obj);
        }

        public static void LoadFromComplainCSV()
        {
            ComplaintsBL obj;
            string path = "Complaints.csv";
            if (File.Exists(path))
            {
                using (var reader = new StreamReader(path))
                {
                    string Complain;
                    string type;
                    while (!reader.EndOfStream)
                    {
                        var line = reader.ReadLine();
                        var values = line.Split(',');
                        type = values[0];
                        Complain = values[1];
                        obj = new ComplaintsBL(type, Complain);
                        AddIntoComplainList(obj);
                    }
                }
            }
        }
        public static void AddToComplainCSV()
        {
            string path = "Complaints.csv";
            StreamWriter f = new StreamWriter(path);
            foreach (ComplaintsBL i in Complainlist)
            {
                f.WriteLine(i.Type + "," + i.Complaint1);
            }
            f.Flush();
            f.Close();
        }
    }
}
