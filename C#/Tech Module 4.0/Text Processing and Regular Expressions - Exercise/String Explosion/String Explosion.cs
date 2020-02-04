using System;
using System.Linq;

namespace _03.Karate_Strings
{
    class Program
    {
        static void Main()
        {
            string inp = Console.ReadLine();

            var input = inp.Split(new [] { '>' }, StringSplitOptions.RemoveEmptyEntries).ToList();

            int currentLetght = 0;
            int start = 0;

            if (inp[0] == '>')
                start = 0;

            else
                start = 1;

            for (int i = start; i < input.Count; i++)
            {
                char first = input[i].First();
                int strength = int.Parse(first.ToString());

                int length = input[i].Length;

                input[i] = new String(input[i].Skip(strength + currentLetght).ToArray());

                if (strength + currentLetght > length)
                    currentLetght = strength + currentLetght - length;

            }

            if (start == 0)
                Console.WriteLine('>' + String.Join(">", input));
            else
                Console.WriteLine(String.Join(">", input));
        }
    }
}