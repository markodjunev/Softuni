using System;
using System.Collections.Generic;

namespace Digits__Letters_and_Other
{
    class Program
    {
        static void Main()
        {
            var input = Console.ReadLine().ToCharArray();
            var listDigits = new List<char>();
            var listLetters = new List<char>();
            var rest = new List<char>();
            for (int i = 0; i < input.Length; i++)
            {
                var curSymbol = input[i];
                if(char.IsDigit(curSymbol))
                    listDigits.Add(curSymbol);
                else if(char.IsLetter(curSymbol))
                    listLetters.Add(curSymbol);
                else
                    rest.Add(curSymbol);              
            }
            Console.WriteLine(string.Join("", listDigits));
            Console.WriteLine(string.Join("", listLetters));
            Console.WriteLine(string.Join("", rest));

        }
    }
}