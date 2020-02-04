using System;

namespace Reverse_String
{
    class Program
    {
        private static string ReversedString(string input)
        {
            var arr = input.ToCharArray();
            Array.Reverse(arr);
            var reversed = new string(arr);
            return reversed;
        }
        static void Main()
        {
            var input = Console.ReadLine();
            Console.WriteLine(ReversedString(input));          
        }       

    }
}