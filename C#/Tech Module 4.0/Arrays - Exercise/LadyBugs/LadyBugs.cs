using System;
using System.Linq;

namespace LadyBugs
{
    class Program
    {
        static void Main()
        {
            var size = ushort.Parse(Console.ReadLine());
            var arr = new int[size];
            var initialIndexes = Console.ReadLine().Split().Select(int.Parse).ToArray();
            for (int i = 0; i < initialIndexes.Length; i++)
            {
                arr[initialIndexes[i]] = 1;
            }
            var input = Console.ReadLine();
            while (input != "end")
            {
                var input2 = input.Split(' ').ToArray();
                var ladyBugIndex = int.Parse(input2[0]);
                var command = input2[1];
                var offset = int.Parse(input2[2]);
                




                input = Console.ReadLine();
            }
        }
    }
}