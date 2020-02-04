using System;
using System.Linq;

namespace Remove_Negatives_and_Reverse
{
    class Program
    {
        static void Main()
        {
            var list = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            list.RemoveAll(x => x < 0);
            list.Reverse();

            if (list.Count == 0)
                Console.WriteLine("empty");
            else
                Console.WriteLine(string.Join(" ", list));
        }
    }
}