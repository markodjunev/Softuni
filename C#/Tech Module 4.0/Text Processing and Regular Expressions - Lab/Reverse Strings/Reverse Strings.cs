using System;

namespace Reverse_Strings
{
    class Program
    {
        static void Main()
        {
            var input = Console.ReadLine();
            while (input != "end")
            {
                var tokens = input.ToCharArray();
                Array.Reverse(tokens);
                Console.WriteLine($"{input} = {string.Join("",tokens)}");

                input = Console.ReadLine();
            }
        }
    }
}