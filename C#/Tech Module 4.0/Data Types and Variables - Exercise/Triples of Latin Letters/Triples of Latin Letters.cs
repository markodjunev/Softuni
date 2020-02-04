using System;

namespace Triples_of_Latin_Letters
{
    class Program
    {
        static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    for (int k = 0; k < n; k++)
                    {
                        var firstChar = (char)('a' + i);
                        var secondChar = (char)('a' + j);
                        var thirdChar = (char)('a' + k);

                        Console.WriteLine($"{firstChar}{secondChar}{thirdChar}");
                    }
                }
            }         

        }
    }
}