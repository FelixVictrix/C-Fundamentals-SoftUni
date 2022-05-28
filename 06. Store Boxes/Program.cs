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
                box.SerilaNumber = serialNumber;
                box.Item = new Item();
                box.Item.Name = itemName;
                box.ItemQuantity = itemQuantity;
                box.Item.Price = itemPrice;
                box.PricePerBox = pricePerBox;

                boxes.Add(box);

                input = Console.ReadLine();
            }

            foreach (var bx in boxes.OrderByDescending(x=> x))
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendLine(bx.SerilaNumber);
                sb.AppendLine($"{bx.Item.Name} - ${bx.Item.Price}: {bx.ItemQuantity}");
                sb.AppendLine();
                Console.WriteLine(sb);
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

        public string SerilaNumber { get; set; }
        public Item Item { get; set; }
        public int ItemQuantity { get; set; }
        public decimal PricePerBox { get; set; }
    }
}
