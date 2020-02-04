using System;

namespace Beer_Kegs
{
    class Program
    {
        static void Main()
        {
            var n = byte.Parse(Console.ReadLine());
            var maxValue = double.MinValue;
            var biggestKeg = "";
            while (n > 0)
            {
                var name = Console.ReadLine();
                var radius = double.Parse(Console.ReadLine());
                var height = double.Parse(Console.ReadLine());
                double volume = Math.PI * (Math.Pow(radius, 2)) * height;
                if (volume > maxValue)
                {
                    maxValue = volume;
                    biggestKeg = name;
                }
                n--;
            }          
            Console.WriteLine(biggestKeg);          
        }
    }
}