using System;
using System.Linq;

namespace Generic_Swap_Method_Integers
{
    public class StartUp
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            var numbers = new Box<int>();

            for (int i = 0; i < n; i++)
            {
                var num = int.Parse(Console.ReadLine());
                numbers.Add(num);
            }

            var indexes = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var firstIndex = indexes[0];
            var secondIndex = indexes[1];

            numbers.Swap(firstIndex, secondIndex);

            Console.WriteLine(numbers);

        }
    }
}