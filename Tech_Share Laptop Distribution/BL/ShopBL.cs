using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.Design.WebControls;

namespace Tech_Share_Laptop_Distribution.BL
{
    class ShopBL
    {
        string shopkeepername;
        string shopkeeperemail;
        string shopkeeperCNIC;
        string shopName;
        string shoplandline;
        string shopaddress;
        ShopBL next;
        ShopBL previous;
        public ShopBL(string shopkeepername, string shopkeeperemail, string shopkeepercnic, string shopname, string shoplandline,string shopaddress)
        {
            this.shopkeepername = shopkeepername;
            this.shopkeeperemail = shopkeeperemail;
            this.shopkeeperCNIC = shopkeepercnic;
            this.shopName = shopname;
            this.shoplandline = shoplandline;
            this.shopaddress = shopaddress;
            next = null;
            previous = null;
        
        }

        public string Shopkeepername { get => shopkeepername; set => shopkeepername = value; }
        public string Shopkeeperemail { get => shopkeeperemail; set => shopkeeperemail = value; }
        public string ShopkeeperCNIC { get => shopkeeperCNIC; set => shopkeeperCNIC = value; }
        public string ShopName { get => shopName; set => shopName = value; }
        public string Shoplandline { get => shoplandline; set => shoplandline = value; }
        public string Shopaddress { get => shopaddress; set => shopaddress = value; }
        internal ShopBL Next { get => next; set => next = value; }
        internal ShopBL Previous { get => previous; set => previous = value; }
    }
}