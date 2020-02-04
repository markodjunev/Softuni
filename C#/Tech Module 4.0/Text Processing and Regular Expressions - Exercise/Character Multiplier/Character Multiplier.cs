using System;

namespace Character_Multiplier
{
    class Program
    {
        static void Main()
        {
            var tokens = Console.ReadLine().Split();
            var firstWord = tokens[0];
            var secondWord = tokens[1];
            int sum = 0;
            var longerWord = string.Empty;
            var shorterWord = string.Empty;

            if (firstWord.Length >= secondWord.Length)
            {
                longerWord = firstWord;
                shorterWord = secondWord;
            }
            else
            {
                longerWord = secondWord;
                shorterWord = firstWord;
            }

            for (int i = 0; i < shorterWord.Length; i++)
            {
                sum += longerWord[i] * shorterWord[i];
            }

            for (int i = shorterWord.Length; i < longerWord.Length; i++)
            {
                sum += longerWord[i];
            }
            Console.WriteLine(sum);
        }
    }
}