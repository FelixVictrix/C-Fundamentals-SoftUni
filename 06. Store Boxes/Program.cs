using System;

namespace _06._Store_Boxes
{
    class Program
    {
        static void Main(string[] args)
        {

            string input = Console.ReadLine();

            while (input != "end")
            {
                string[] info = input.Split();
                string serialNumber = info[0];
                string itemName = info[1];
                int itemQuantity = int.Parse(info[2]);
                decimal itemPrice = decimal.Parse(info[3]);

                decimal pricePerBox = 

                input = Console.ReadLine();
            }

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
