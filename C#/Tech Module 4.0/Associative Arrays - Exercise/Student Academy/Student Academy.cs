using System;
using System.Collections.Generic;
using System.Linq;

namespace Student_Academy
{
    class Program
    {
        static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var dictionary = new Dictionary<string, List<double>>();
            for (int i = 0; i < n; i++)
            {
                var student = Console.ReadLine();
                var grade = double.Parse(Console.ReadLine());
                if(!dictionary.ContainsKey(student))
                    dictionary[student] = new List<double>();

                dictionary[student].Add(grade);
            }

            foreach (var item in dictionary.OrderByDescending(x=> x.Value.Average()))
            {
                if(item.Value.Average() >= 4.5)
                    Console.WriteLine($"{item.Key} -> {item.Value.Average():f2}");
            }
        }
    }
}