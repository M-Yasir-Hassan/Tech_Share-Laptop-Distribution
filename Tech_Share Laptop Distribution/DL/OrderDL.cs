using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tech_Share_Laptop_Distribution.BL;

namespace Tech_Share_Laptop_Distribution.DL
{
    internal class OrderDL
    {
        public static List<OrderBL> OrderList = new List<OrderBL>();
        public static List<OrderBL> CompletedOrder = new List<OrderBL>();


        private static OrderBL head = null;

        public static void addToList(OrderBL temp)
        {
            OrderList.Add(temp);
        }

        public static void Insert_At_Tail(OrderBL data)
        {
            if (head == null)
            {
                Insert_At_Head(data);
                return;
            }
            OrderBL order = head;
            while (order.Next != null)
            {
                order = order.Next;
            }
            order.Next = data;
            data.Previous = order;

        }

        public static void Insert_At_Head(OrderBL data)
        {
            data.Next = head;
            if (head != null)
            {
                head.Previous = data;
            }
            head = data;
        }

        public static bool addToFileOrder(OrderBL order)
        {
            String path = "Order.csv";
            using (StreamWriter file = new StreamWriter(path, true))
            {
                file.WriteLine(order.OrderName1 + "," + order.ShopName1 + "," + order.Quantity1);
                file.Flush();
                file.Close();
            }
            return true;
        }
        public static void AddToCSV()
        {
            using (var w = new StreamWriter("Order.csv"))
            {
                foreach (OrderBL i in OrderList)
                {
                    var line = string.Format("{0},{1},{2}", i.OrderName1, i.ShopName1, i.Quantity1);
                    w.WriteLine(line);
                    w.Flush();
                }
            }
        }
        public static bool addToFileCompletedOrder(OrderBL order)
        {
            String path = "CompletedOrder.csv";
            using (StreamWriter file = new StreamWriter(path, true))
            {
                file.WriteLine(order.OrderName1 + "," + order.ShopName1 + "," + order.Quantity1);
                file.Flush();
                file.Close();
            }
            return true;
        }

        public static int lengthList()
        {
            int count = 0;
            OrderBL order = head;
            while (order != null)
            {
                count++;
                order = order.Next;
            }

            return count;
        }

        public static bool DataToLists()
        {
            OrderBL temp = head;

            OrderList.Clear();
            while (temp != null)
            {
                addToList(temp);
                temp = temp.Next;
            }

            return true;
        }
        public static void getFromFileOrder()
        {
            String path = "Order.csv";
            if (File.Exists(path))
            {
                using (StreamReader file = new StreamReader(path))
                    while (!file.EndOfStream)
                    {
                        string record = file.ReadLine();
                        string[] splittedRecord = record.Split(',');
                        string ordername = splittedRecord[0];
                        string shopname = splittedRecord[1];
                        string quantity = splittedRecord[2];
                        OrderBL newr = new OrderBL(ordername, shopname, quantity);
                        OrderDL.Insert_At_Tail(newr);
                        OrderDL.OrderList.Add(newr);
                    }
            }
        }
        public static void getFromFileCompletedOrder()
        {
            String path = "CompletedOrder.csv";
            if (File.Exists(path))
            {
                using (StreamReader file = new StreamReader(path))
                    while (!file.EndOfStream)
                    {
                        string record = file.ReadLine();
                        string[] splittedRecord = record.Split(',');
                        string ordername = splittedRecord[0];
                        string shopname = splittedRecord[1];
                        string quantity = splittedRecord[2];
                        OrderBL newr = new OrderBL(ordername, shopname, quantity);
                        OrderDL.CompletedOrder.Add(newr);
                    }
            }
        }
        public static void DeleteOrder(OrderBL order)
        {
            for (int i = 0; i < OrderList.Count; i++)
            {
                if (order.OrderName1 == OrderList[i].OrderName1)
                {
                    OrderList.Remove(OrderList[i]);
                }
            }
        }

    }
}
