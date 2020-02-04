using System;

namespace Intro_and_Basic_Syntax___Exercise
{
    class Program
    {
        static void Main()
        {
            var n = Convert.ToInt32(Console.ReadLine());
            if (n >= 0 && n <= 2) Console.WriteLine("baby");
            if (n >= 3 && n <= 13) Console.WriteLine("child");
            if (n > 13 && n <= 19) Console.WriteLine("teenager");
            if (n > 19 && n <= 65) Console.WriteLine("adult");
            if (n > 65) Console.WriteLine("elder");
        }
    }
}