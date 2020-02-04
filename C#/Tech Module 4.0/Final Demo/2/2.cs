using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2
{
    class Program
    {
        static void Main()
        {
            var input = Console.ReadLine();
            var letters = Console.ReadLine().Split(' ');
            var sb = new StringBuilder();
            for (int i = 0; i < input.Length; i++)
            {
                var symbol = (char)(input[i] - 3);
                sb.Append(symbol);
            }
            var encrypted = sb.ToString();
            var oldChar = letters[0];
            var newChar = letters[1];

            for (int i = 0; i < encrypted.Length-oldChar.Length; i++)
            {
                var curSym = encrypted.Substring(i, oldChar.Length);
                if (curSym.Equals(oldChar))
                {
                    encrypted = encrypted.Replace(curSym, newChar);
                }
            }
            Console.WriteLine(encrypted);
         
        }
    }
}