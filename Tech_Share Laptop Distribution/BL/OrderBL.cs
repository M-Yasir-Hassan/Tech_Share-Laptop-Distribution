using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tech_Share_Laptop_Distribution.BL
{
    internal class OrderBL
    {

        string OrderName;
        string ShopName;
        string Quantity;
        OrderBL next;
        OrderBL previous;

        public OrderBL(string ordername, string shopname, string quantity)
        {
            this.OrderName = ordername;
            this.ShopName = shopname;
            this.Quantity = quantity;
            this.next = null;
            this.previous = null;
        }
        public OrderBL()
        {
            this.OrderName = null;
            this.ShopName = null;
            this.Quantity = null;
            this.next = null;
            this.previous = null;
        }
        public string OrderName1 { get => OrderName; set => OrderName = value; }
        public string ShopName1 { get => ShopName; set => ShopName = value; }
        public string Quantity1 { get => Quantity; set => Quantity = value; }
        internal OrderBL Next { get => next; set => next = value; }
        internal OrderBL Previous { get => previous; set => previous = value; }
    }
}
