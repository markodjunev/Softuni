using System;
using System.Collections.Generic;
using System.Linq;

namespace Average_Student_Grades
{
    class Program
    {
        static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var students = new Dictionary<string, List<double>>();

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split();
                var name = input[0];
                var grade = double.Parse(input[1]);

                if(!students.ContainsKey(name))
                    students[name] = new List<double>();

                students[name].Add(grade);
            }

            foreach (var item in students)
            {
                Console.Write(item.Key + " -> ");
                foreach (var values in item.Value)
                {
                    Console.Write($"{values:f2} ");
                }
                Console.Write($"(avg: {item.Value.Average():f2})");
                Console.WriteLine();
            }

        }
    }
}