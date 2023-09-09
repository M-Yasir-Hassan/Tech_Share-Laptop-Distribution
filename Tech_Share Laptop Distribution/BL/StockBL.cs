using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tech_Share_Laptop_Distribution.BL
{
    public class StockBL
    {
        private string name;
        private string model;
        private string processor;
        private string ram;
        private string storage;
        private string Video_card;
        private string quantity;
        private string price;

        public StockBL(string name, string model, string processor, string ram, string storage, string video_card, string quantity, string price)
        {
            this.Name = name;
            this.Model = model;
            this.Processor = processor;
            this.Ram = ram;
            this.Storage = storage;
            this.Video_card1 = video_card;
            this.Quantity = quantity;
            this.Price = price;
        }

        public string Name { get => name; set => name = value; }
        public string Model { get => model; set => model = value; }
        public string Processor { get => processor; set => processor = value; }
        public string Ram { get => ram; set => ram = value; }
        public string Storage { get => storage; set => storage = value; }
        public string Video_card1 { get => Video_card; set => Video_card = value; }
        public string Quantity { get => quantity; set => quantity = value; }
        public string Price { get => price; set => price = value; }
    }
}
