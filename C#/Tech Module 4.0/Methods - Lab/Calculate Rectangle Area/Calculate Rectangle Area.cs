using System;

namespace Calculate_Rectangle_Area
{
    class Program
    {
        private static double Calculations(double width, double height)
        {
            return width * height;
        }
        static void Main()
        {
            var width = double.Parse(Console.ReadLine());
            var height = double.Parse(Console.ReadLine());
            var res = Calculations(width, height);
            Console.WriteLine(res);
        }
    }
}