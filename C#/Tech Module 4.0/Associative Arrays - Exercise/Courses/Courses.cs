using System;
using System.Collections.Generic;
using System.Linq;

namespace Courses
{
    class Courses
    {
        static void Main()
        {
            var input = Console.ReadLine();
            var dictionary = new Dictionary<string , List<string>>();
            while (input != "end")
            {
                var tokens = input.Split(new string[] {" : "}, StringSplitOptions.RemoveEmptyEntries);
                var course = tokens[0];
                var student = tokens[1];
                if(!dictionary.ContainsKey(course))
                    dictionary[course] = new List<string>();

                dictionary[course].Add(student);

                input = Console.ReadLine();
            }
            
            foreach (var item in dictionary.OrderByDescending(x => x.Value.Count))
            {
                Console.WriteLine($"{item.Key}: {item.Value.Count}");
                foreach (var value in item.Value.OrderBy(x => x))
                {
                    Console.WriteLine($"-- {value}");
                }
            }
        }
    }
}