using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace _06._Store_Boxes
{
    class Program
    {
        static void Main(string[] args)
        {

            string input = Console.ReadLine();

            List<Box> boxes = new List<Box>();

            while (input != "end")
            {
                string[] info = input.Split();
                string serialNumber = info[0];
                string itemName = info[1];
                int itemQuantity = int.Parse(info[2]);
                decimal itemPrice = decimal.Parse(info[3]);
                decimal pricePerBox = itemPrice * itemQuantity;

                Box box = new Box();
                box.SerialNumber = serialNumber;
                //box.Item = new Item();
                box.Item.Name = itemName;
                box.ItemQuantity = itemQuantity;
                box.Item.Price = itemPrice;
                box.PricePerBox = pricePerBox;

                boxes.Add(box);

                input = Console.ReadLine();
            }

            boxes = boxes.OrderByDescending(x=> x.PricePerBox).ToList();


            foreach (var bx in boxes)
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendLine(bx.SerialNumber);
                sb.AppendLine($"-- {bx.Item.Name} - ${bx.Item.Price:f2}: {bx.ItemQuantity}");
                sb.AppendLine($"-- ${bx.PricePerBox:f2}");
                Console.Write(sb);
            }
            //{boxSerialNumber}

            //-- { boxItemName} – ${ boxItemPrice}: { boxItemQuantity}

           // -- ${ boxPrice}

            //The price should be formatted to the 2nd digit after the decimal separator.
           
            
        }
    }
    class Item
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
    }
    class Box
    {
        public Box()
        {
            Item = new Item();
        }

        public string SerialNumber { get; set; }
        public Item Item { get; set; }
        public int ItemQuantity { get; set; }
        public decimal PricePerBox { get; set; }
    }
}
