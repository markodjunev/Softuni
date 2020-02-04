using System;
using System.Collections.Generic;

namespace Decrypting_Message
{
    class Program
    {
        static void Main()
        {
            var key = byte.Parse(Console.ReadLine());
            var n = byte.Parse(Console.ReadLine());
            var list = new List<char>();
            for (int i = 0; i < n; i++)
            {
                var symbol = char.Parse(Console.ReadLine());
                char letter = (char)(symbol + key);
                list.Add(letter);
            }
            foreach (var item in list)
            {
                Console.Write(item);
            }
            Console.WriteLine();
        }
    }
}