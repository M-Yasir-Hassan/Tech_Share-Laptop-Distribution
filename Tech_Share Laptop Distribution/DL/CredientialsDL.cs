using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tech_Share_Laptop_Distribution.BL;
using System.IO;

namespace Tech_Share_Laptop_Distribution.DL
{
    public class CredientialsDL
    {
        private static List<CredientialsBL> CredientialsList = new List<CredientialsBL>();

        // Getter & Setter For List
        public static List<CredientialsBL> CredientialsList1 { get => CredientialsList; set => CredientialsList = value; }

        public static void AddIntoList(CredientialsBL obj)
        {
            CredientialsList.Add(obj);
        }

        public static void LoadFromCSV()
        {
            CredientialsBL obj;
            string path = "Accounts.csv";
            if (File.Exists(path))
            {
                using (var reader = new StreamReader(path))
                {
                    string Email;
                    string Pwd;
                    string Role;
                    while (!reader.EndOfStream)
                    {
                        var line = reader.ReadLine();
                        var values = line.Split(',');

                        Email = values[0];
                        Pwd = values[1];
                        Role = values[2];
                        obj = new CredientialsBL(Email, Pwd, Role);
                        AddIntoList(obj);
                    }
                }
            }
        }

        public static void AddToCSV()
        {
            using (var w = new StreamWriter("Accounts.csv"))
            {
                foreach (CredientialsBL i in CredientialsList)
                {
                    var line = string.Format("{0},{1},{2}", i.Email1, i.Password1, i.Role1);
                    w.WriteLine(line);
                    w.Flush();
                }
            }
        }

        public static string CheckRole(string Email, string Password)
        {
            foreach (CredientialsBL i in CredientialsList)
            {
                if (Email == i.Email1 && Password == i.Password1)
                {
                    return i.Role1;
                }
            }
            return "NA";
        }
        public static bool ResetPassword(string Email, string Password, string role)
        {
            foreach (CredientialsBL i in CredientialsList)
            {
                if (Email == i.Email1 && role == i.Role1)
                {
                    i.Password1 = Password;
                    AddToCSV();
                    return true;
                }
            }
            return false;
        }

    }
}
