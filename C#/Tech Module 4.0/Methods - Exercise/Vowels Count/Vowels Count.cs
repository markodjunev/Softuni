using System;

namespace Vowels_Count
{
    class Program
    {
        private static int Vowels(string input)
        {
            int vowels = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == 'A' || input[i] == 'I' || input[i] == 'E' || input[i] == 'O' || input[i] == 'U'
                  || input[i] == 'a' || input[i] == 'i' || input[i] == 'e' || input[i] == 'o' || input[i] == 'u')
                    vowels++;               
            }

            return vowels;
        }
        static void Main()
        {
            var input = Console.ReadLine();
            int vowels = Vowels(input);
            Console.WriteLine(vowels);
        }
    }
}