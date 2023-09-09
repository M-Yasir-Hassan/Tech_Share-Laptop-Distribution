using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Mail;
using System.IO;
using Tech_Share_Laptop_Distribution.BL;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Tech_Share_Laptop_Distribution.DL
{
    class ShopDL
    {
        public static List<ShopBL> ShopList = new List<ShopBL>();
        private class Node
        {

            internal ShopBL Value;
            internal Node next;
            internal Node prev;

            public Node(ShopBL value, Node prev, Node next)
            {
                this.Value = value;
                this.prev = prev;
                this.next = next;
            }
        }

        private static ShopBL head = null;

        public static void addintofileList()
        {
            string path = "Shops Data.csv";
            StreamWriter f = new StreamWriter(path);

            foreach (ShopBL i in ShopList)
            {
                f.WriteLine(i.Shopkeepername + "," + i.Shopkeeperemail + "," + i.ShopkeeperCNIC + "," + i.ShopName + "," + i.Shoplandline + "," + i.Shopaddress);
            }
            f.Flush();
            f.Close();
        }
        public static void addToList(ShopBL temp)
        {
            ShopList.Add(temp);
        }

        public static void Insert_At_Tail(ShopBL data)
        {
            if (head == null)
            {
                Insert_At_Head(data);
                return;
            }
            ShopBL shop = head;
            while (shop.Next != null)
            {
                shop = shop.Next;
            }
            shop.Next = data;
            data.Previous = shop;

        }

        public static void Insert_At_Head(ShopBL data)
        {
            data.Next = head;
            if (head != null)
            {
                head.Previous = data;
            }
            head = data;
        }

        public static bool DeleteProduct(ShopBL data)
        {
            if (head == null || data == null)
            {
                return false;
            }

            if (data.Next != null)
            {
                data.Next.Previous = data.Previous;
            }
            if (data.Previous != null)
            {
                data.Previous.Next = data.Next;
            }
            if (head == data)
            {
                head = data.Next;
            }
            return true;
        }


        public static bool addToFile(ShopBL shop_save)
        {
            String path = "Shops Data.csv";
            using (StreamWriter file = new StreamWriter(path, true))
            {
                file.WriteLine(shop_save.Shopkeepername + "," + shop_save.Shopkeeperemail + "," + shop_save.ShopkeeperCNIC + "," + shop_save.ShopName + "," + shop_save.Shoplandline + "," + shop_save.Shopaddress);
                file.Flush();
                file.Close();
            }
            return true;
        }

        public static int lengthList()
        {
            int count = 0;
            ShopBL shop = head;
            while (shop != null)
            {
                count++;
                shop = shop.Next;
            }

            return count;
        }

        public static bool DataToLists()
        {
            ShopBL temp = head;

            ShopList.Clear();
            while (temp != null)
            {

                addToList(temp);
                temp = temp.Next;
            }

            return true;
        }

        public static bool UpdateShops(ShopBL data)
        {
            ShopBL shop = head;
            while (shop != null)
            {
                if (shop.ShopName == data.ShopName)
                {

                    shop.Shopkeepername = data.Shopkeepername;
                    shop.Shopkeeperemail = data.Shopkeeperemail;
                    shop.ShopkeeperCNIC = data.ShopkeeperCNIC;
                    shop.ShopName = data.ShopName;
                    shop.Shoplandline = data.Shoplandline;
                    shop.Shopaddress = data.Shopaddress;
                }
                shop = shop.Next;
            }
            return true;
        }

        public static void getFromFile()
        {
            int countt = 0;
            ShopBL shopnew;
            String path = "Shops Data.csv";
            if (File.Exists(path))
            {
                using (StreamReader file = new StreamReader(path))
                    while (!file.EndOfStream)
                    {
                        string record = file.ReadLine();
                        string[] splittedRecord = record.Split(',');
                        string shopkeepername = splittedRecord[0];
                        string shopkeeperemail = splittedRecord[1];
                        string shopkeepercnic = splittedRecord[2];
                        string shopname = splittedRecord[3];
                        string shoplandline = splittedRecord[4];
                        string shopaddress = splittedRecord[5];
                        shopnew = new ShopBL(shopkeepername, shopkeeperemail, shopkeepercnic, shopname, shoplandline, shopaddress);
                        ShopDL.Insert_At_Tail(shopnew);
                        ShopDL.addToList(shopnew);
                        countt++;
                    }
            }
            //MessageBox.Show(countt.ToString());
        }



        public static bool SndMail_OrderCompleted(string msgTO)
        {
            string fromMail = "hyasir368@gmail.com";
            string fromPwd = "jzbqlpftskaebcoj";

            MailMessage message = new MailMessage();
            message.From = new MailAddress(fromMail);
            message.Subject = "Order Completed";
            message.To.Add(new MailAddress(msgTO));
            message.Body = "<html><body> Your Order Have Been Successfully Completed \n Thanks For Trusting  Us</body></html>";
            message.IsBodyHtml = true;

            var smtpClient = new SmtpClient("smtp.gmail.com")
            {
                Port = 587,
                Credentials = new NetworkCredential(fromMail, fromPwd),
                EnableSsl = true,
            };

            smtpClient.Send(message);
            return true;
        }
        public static void DeleteShop(ShopBL shop)
        {
            for (int i = 0; i < ShopList.Count; i++)
            {
                if (shop.ShopName == ShopList[i].ShopName)
                {
                    ShopList.Remove(ShopList[i]);
                }
            }
        }
        public static bool updateInfo(ShopBL temp)
        {
            ShopBL Temp = head;

            // Iterate through the list
            while (Temp != null)
            {
                if (Temp.Shopkeepername == temp.Shopkeepername)
                {
                    Temp.ShopkeeperCNIC = temp.ShopkeeperCNIC;
                    Temp.Shopkeeperemail = temp.Shopkeeperemail;
                    Temp.Shoplandline = temp.Shoplandline;
                    Temp.Shopaddress = temp.Shopaddress;
                    Temp.ShopName = temp.ShopName;
                    Temp.Shopkeepername = temp.Shopkeepername;
                }
                Temp = Temp.Next;
            }
            foreach (ShopBL i in ShopList)
            {
                if (i.Shopkeepername == temp.Shopkeepername)
                {
                    i.ShopkeeperCNIC = temp.ShopkeeperCNIC;
                    i.Shopkeeperemail = temp.Shopkeeperemail;
                    i.Shoplandline = temp.Shoplandline;
                    i.Shopaddress = temp.Shopaddress;
                    i.Shopkeepername = temp.Shopkeepername;
                    i.ShopName = temp.ShopName;
                    return true;
                }
            }
            return false;
        }
    }
}
