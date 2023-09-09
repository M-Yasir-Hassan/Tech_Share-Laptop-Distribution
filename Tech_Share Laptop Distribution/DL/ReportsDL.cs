using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Tech_Share_Laptop_Distribution.DL;
using Tech_Share_Laptop_Distribution.BL;

namespace Tech_Share_Laptop_Distribution.DL
{
    class ReportsDL
    {
        public static void addToFileCompletedOrder()
        {
            using (var w = new StreamWriter("C:\\CompletedOrder.csv"))
            {
                foreach (OrderBL i in OrderDL.CompletedOrder)
                {
                    var line = string.Format("{0},{1},{2}", i.OrderName1, i.ShopName1, i.Quantity1);
                    w.WriteLine(line);
                    w.Flush();
                }
            }
        }

        public static void addToFileShop()
        {
            using (var w = new StreamWriter("C:\\ShopsData.csv"))
            {
                foreach (ShopBL i in ShopDL.ShopList)
                {
                    var line = string.Format("{0},{1},{2},{3},{4},{5}", i.Shopkeepername, i.Shopkeeperemail, i.ShopkeeperCNIC, i.ShopName, i.Shoplandline, i.Shopaddress);
                    w.WriteLine(line);
                    w.Flush();
                }
            }
        }
    }
}
