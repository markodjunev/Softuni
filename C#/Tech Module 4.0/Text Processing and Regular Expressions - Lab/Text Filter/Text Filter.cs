using System;

namespace homework
{
    class Program
    {
        static void Main()
        {
            var bannedWords = Console.ReadLine().Split(new []{ ", " },StringSplitOptions.RemoveEmptyEntries);
            var text = Console.ReadLine();

            foreach (string ban in bannedWords)
            {
                for (int i = 0; i < text.Length - ban.Length; i++)
                {
                    if (text.Substring(i, ban.Length).Equals(ban))
                        text = text.Replace(text.Substring(i, ban.Length), new string('*', ban.Length));

                }
            }
            Console.WriteLine(text);
        }
    }
}