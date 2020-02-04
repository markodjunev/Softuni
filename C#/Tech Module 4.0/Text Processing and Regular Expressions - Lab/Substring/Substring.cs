using System;

namespace Substring
{
    class Substring
    {
        static void Main()
        {
            var wordToRemove = Console.ReadLine().ToLower();
            var input = Console.ReadLine();
            var ind = input.IndexOf(wordToRemove);
            while (ind != -1)
            {
                input = input.Replace(wordToRemove, "");
                ind = input.IndexOf(wordToRemove);
            }
            Console.WriteLine(input);
        }
    }
}