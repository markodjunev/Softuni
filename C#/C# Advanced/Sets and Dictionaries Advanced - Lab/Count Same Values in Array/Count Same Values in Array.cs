using System;
using System.Collections.Generic;
using System.Linq;

namespace Count_Same_Values_in_Array
{
    class Program
    {
        static void Main()
        {
            var values = new Dictionary<double, int>();
            var numbers = Console.ReadLine().Split().Select(double.Parse).ToArray();

            for (int i = 0; i < numbers.Length; i++)
            {
                var curNum = numbers[i];
                if (!values.ContainsKey(curNum))
                    values[curNum] = 0;

                values[curNum]++;
            }

            foreach (var item in values)
            {
                Console.WriteLine($"{item.Key} - {item.Value} times");
            }
        }
    }
}