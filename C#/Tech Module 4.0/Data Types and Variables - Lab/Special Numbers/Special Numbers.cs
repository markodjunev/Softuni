using System;

namespace Special_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var sum = 0;
            for (int i = 1; i <= n; i++)
            {
                 sum = 0;
                var numCount = i.ToString().Length;
                var real = i;
                for (int j = 0; j < numCount; j++)
                {
                    var lastDigit = real % 10;
                    real /= 10;
                    sum += lastDigit;
                }
                switch (sum)
                {
                    case 5: Console.WriteLine($"{i} -> True"); break;
                    case 7: Console.WriteLine($"{i} -> True"); break;
                    case 11: Console.WriteLine($"{i} -> True"); break;
                    default: Console.WriteLine($"{i} -> False"); break;
                }
            }
        }
    }
}