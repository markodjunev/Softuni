using System;

namespace Water_Overflow
{
    class Program
    {
        static void Main()
        {
            var n = byte.Parse(Console.ReadLine());
            byte tankCapacity = 255;
            var currentCapacity = 0;
            for (int i = 0; i < n; i++)
            {
                var water = ushort.Parse(Console.ReadLine());
                if ((currentCapacity + water) <= tankCapacity)
                {
                    currentCapacity += water;
                }
                else Console.WriteLine("Insufficient capacity!");
            }
            Console.WriteLine(currentCapacity);
        }
    }
}