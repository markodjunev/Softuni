using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _08MatchNumbers
{
    class Program
    {
        static void Main()
        {
            var input = Console.ReadLine();
            var numbers = new List<string>();
            var pattern = @"(^|(?<=\s))-?\d+(\.\d+)?($|(?=\s))";
            var validNumbers = Regex.Matches(input, pattern);

            foreach (Match match in validNumbers)
            {
                numbers.Add(match.ToString());
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}