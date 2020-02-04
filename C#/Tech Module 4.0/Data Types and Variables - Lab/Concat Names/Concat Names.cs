using System;

namespace Concat_Names
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = Console.ReadLine();
            var b = Console.ReadLine();
            var c = Console.ReadLine();
            Console.WriteLine($"{a}{c}{b}");
        }
    }
}