using System;
using System.Linq;

namespace Sum_Adjacent_Equal_Numbers
{
    class Program
    {
        static void Main()
        {
            var list = Console.ReadLine().Split(' ').Select(float.Parse).ToList();
            for (int i = 0; i < list.Count() - 1; i++)
            {
                if (list[i] == list[i+1])
                {
                    list[i] = list[i + 1] * 2;
                    list.RemoveAt(i+1);
                    i = -1;
                }
            }
            Console.WriteLine(string.Join(" ", list));
        }
    }
}