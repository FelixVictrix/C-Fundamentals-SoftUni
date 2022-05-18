using System;

namespace _06._Calculate_Rectangle_Area
{
    class Program
    {
        static void Main(string[] args)
        {
          double width = double.Parse(Console.ReadLine());
          double height = double.Parse(Console.ReadLine());

          RectangleArea(width, height);
        }

        private static void RectangleArea(double b, double h)
        {
            var area = b * h;
            Console.WriteLine(area);
        }
    }
}
