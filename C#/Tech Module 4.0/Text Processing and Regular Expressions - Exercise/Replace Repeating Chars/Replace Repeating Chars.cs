using System;
using System.Linq;

namespace Replace_Repeating_Chars
{
    class Program
    {
        static void Main()
        {
            var input = Console.ReadLine().ToList();
            for (int i = 0; i < input.Count-1; i++)
            {
                var letter = input[i];
                var nextLetter = input[i+1];
                if (letter == nextLetter)
                {
                   input.RemoveAt(i+1);
                   i--;
                }
            }
            Console.WriteLine(string.Join("",input));
        }
    }
}