using System;

namespace Middle_Characters
{
    class Program
    {
        static void Main()
        {
            var input = Console.ReadLine();
            var op = "";
            if (input.Length % 2 == 0)
                op = input.Substring((input.Length - 1) / 2, 2);
            else
                op = input.Substring((input.Length - 1) / 2, 1);

            Console.WriteLine(op);
        }
    }
}