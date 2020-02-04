using System;

namespace Generic_Count_Method_Strings
{
    public class StartUp
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            var elements = new Box<string>();

            for (int i = 0; i < n; i++)
            {
                var word = Console.ReadLine();
                elements.Add(word);
            }

            var wordComparison = Console.ReadLine();

            Console.WriteLine(elements.Compare(elements.Data, wordComparison));
        }
    }
}