using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Tech_Share_Laptop_Distribution.BL;

namespace Tech_Share_Laptop_Distribution.DL
{
    public static class StockDL
    {
        public static List<StockBL> StockList = new List<StockBL>();

        public static bool AddProducttofile(StockBL stock)
        {
            String path = "Stock.csv";
            using (StreamWriter file = new StreamWriter(path, true))
            {
                file.WriteLine(stock.Name + "," + stock.Model + "," + stock.Processor + "," + stock.Ram + "," + stock.Storage + "," + stock.Video_card1 + "," + stock.Quantity + "," + stock.Price);
                file.Flush();
                file.Close();
            }
            return true;
        }
        public static void LoadDataFromFile()
        {
            string path = "Stock.csv";
            if (File.Exists(path))
            {
                using (var reader = new StreamReader(path))
                {
                    string Name;
                    string model;
                    string processor;
                    string ram;
                    string storage;
                    string videocard;
                    string quantity;
                    string price;
                    while (!reader.EndOfStream)
                    {
                        var line = reader.ReadLine();
                        var values = line.Split(',');
                        Name = values[0];
                        model = values[1];
                        processor = values[2];
                        ram = values[3];
                        storage = values[4];
                        videocard = values[5];
                        quantity = values[6];
                        price = values[7];
                        StockBL temp = new StockBL(Name, model, processor, ram, storage, videocard, quantity, price);
                        StockList.Add(temp);
                    }
                }
            }
        }
    }
}
