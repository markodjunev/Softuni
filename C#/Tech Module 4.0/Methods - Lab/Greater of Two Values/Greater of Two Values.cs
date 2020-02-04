using System;
using System.Linq;

namespace Greater_of_Two_Values
{
    class Program
    {
        static void Main()
        {
            var command = Console.ReadLine();
            var a = Console.ReadLine();
            var b = Console.ReadLine();
            switch (command)
            {
                case "int": Console.WriteLine(Int(int.Parse(a), int.Parse(b))); break;
                case "char": Console.WriteLine(Char(char.Parse(a), char.Parse(b))); break;
                case "string": Console.WriteLine(Str(a, b)); break;
            }
        }

        private static int Int(int a, int b)
        {
            var arr = new int[] { a, b };
            return arr.Max();
        }
        private static char Char(char a, char b)
        {
            var arr = new char[] { a, b };
            return (char)arr.Max();
        }
        private static string Str(string a, string b)
        {
            if (a.CompareTo(b) >= 0)
                return a;
            else
                return b;
        }
    }
}