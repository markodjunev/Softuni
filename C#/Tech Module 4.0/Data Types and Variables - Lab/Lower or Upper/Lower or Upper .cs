using System;

namespace Lower_or_Upper
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = Console.ReadLine();
            var symbol = a[0];
            if (symbol >= 65 && symbol <= 90) Console.WriteLine("upper-case");
            else if (symbol >= 97 && symbol <= 122) Console.WriteLine("lower-case");
        }
    }
}