using System;
using System.Numerics;

namespace Snowballs
{
    class Snowballs
    {
        private static BigInteger Value(int snow, int time, int quality)
        {
            var value = BigInteger.Pow((snow / time), quality);
            return value;
        }
        static void Main()
        {
            var n = byte.Parse(Console.ReadLine());
            BigInteger best = 0;
            int bestSnow = 0;
            int bestTime = 0;
            int bestQuality = 0;

            for (int i = 0; i < n; i++)
            {
                int snow = int.Parse(Console.ReadLine());
                int time = int.Parse(Console.ReadLine());
                int quality = int.Parse(Console.ReadLine());
                if (Value(snow, time, quality) > best)
                {
                    bestSnow = snow;
                    bestTime = time;
                    bestQuality = quality;
                    best = Value(snow, time, quality);
                }
            }
            Console.WriteLine($"{bestSnow} : {bestTime} = {best} ({bestQuality})");

        }
    }
}