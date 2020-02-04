using System;
using System.Linq;

namespace Gauss__Trick
{
    class Program
    {
        static void Main()
        {
            var list = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var count = list.Count() / 2;
            for (int i = 0; i < count; i++)
            {
                list[i] += list[list.Count - 1];
                list.RemoveAt(list.Count - 1);
            }
            Console.WriteLine(string.Join(" ", list));
        }
    }
}