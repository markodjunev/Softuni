using System;
using System.Text;

namespace Caesar_Cipher
{
    class Program
    {
        static void Main()
        {
            var input = Console.ReadLine();
            var sb = new StringBuilder();

            foreach (var symbol in input)
            {
                var encryptedSymbol = (char)(symbol + 3);
                sb.Append(encryptedSymbol);
            }
            Console.WriteLine(sb.ToString());
        }
    }
}