using System;

namespace Poke_Mon
{
    class Program
    {
        static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var originalN = n;
            var m = int.Parse(Console.ReadLine());
            var y = int.Parse(Console.ReadLine());
            var pokes = 0;
            while (n >= m)
            {
                if (originalN * 0.5 == n && y != 0)
                {
                    n /= y;
                    if (n < m)
                        break;                   
                }
                n -= m;
                pokes++;
            }
            Console.WriteLine(n);
            Console.WriteLine(pokes);
        }
    }
}