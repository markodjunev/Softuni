using System;
using System.Linq;

namespace Word_Filter
{
    class Program
    {
        static void Main()
        {
            var input = Console.ReadLine().Split().Where(x => x.Length % 2 == 0).ToArray();
            foreach (var item in input)
            {
                Console.WriteLine(item);
            }
        }
    }
}