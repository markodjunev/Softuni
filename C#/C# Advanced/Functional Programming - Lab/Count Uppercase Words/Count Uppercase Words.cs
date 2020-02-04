using System;
using System.Linq;

namespace Count_Uppercase_Words
{
    class Program
    {
        static void Main()
        {
            Func<string, bool> filterUppercase = s => Char.IsUpper(s[0]);

            Console.ReadLine()
                .Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                .Where(filterUppercase)
                .ToList()
                .ForEach(w => Console.WriteLine(w));
        }
    }
}