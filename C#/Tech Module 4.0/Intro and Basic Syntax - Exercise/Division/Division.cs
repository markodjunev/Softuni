using System;

namespace Division
{
    class Division
    {
        static void Main(string[] args)
        {
            var n = Convert.ToInt32(Console.ReadLine());
            if (n % 2 != 0 && n % 3 != 0 && n % 6 != 0 && n % 7 != 0 && n % 10 != 0)
            {
                Console.WriteLine("Not divisible");
                return;
            }                   
            if ((n % 2 == 0 && n % 10 == 0) || (n % 3 == 0 && n % 10 == 0) || (n % 10 == 0) || (n % 6 == 0 && n % 10 == 0) || (n % 7 == 0 && n % 10 == 0))
            {
                Console.WriteLine("The number is divisible by 10");
                return;
            }
            if ((n % 2 == 0 && n % 7 == 0) || (n % 3 == 0 && n % 7 == 0) || (n % 7 == 0) || (n % 6 == 0 && n % 7 == 0))
            {
                Console.WriteLine("The number is divisible by 7");
                return;
            }
            if ((n % 2 == 0 && n % 3 == 0) || (n % 2 == 0 && n % 6 == 0) || (n % 6 == 0) || (n % 3 == 0 && n % 6 == 0))
            {
                Console.WriteLine("The number is divisible by 6");
                return;
            }
            if (n % 3 == 0)
            {
                Console.WriteLine("The number is divisible by 3");
                return;
            }
            if (n % 2 == 0)
            {
                Console.WriteLine("The number is divisible by 2");
                return;
            }
        }
    }
}