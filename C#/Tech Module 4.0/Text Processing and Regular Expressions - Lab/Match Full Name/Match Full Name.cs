using System;
using System.Text.RegularExpressions;

namespace Match_Full_Name
{
    class Program
    {
        static void Main()
        {
            var names = Console.ReadLine();          
            var pattern = @"\b[A-Z][a-z]+ [A-Z]{1}[a-z]+";
            var matched = Regex.Matches(names, pattern);
            foreach (Match item in matched)
            {
                Console.Write(item + " ");
            }
        }
    }
}