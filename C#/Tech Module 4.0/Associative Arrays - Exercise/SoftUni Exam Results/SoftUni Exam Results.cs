using System;
using System.Collections.Generic;
using System.Linq;

namespace SoftUni_Exam_Results
{
    class Program
    {
        static void Main()
        {
            var input = Console.ReadLine();
            var dictionary = new Dictionary<string, int>();
            var submissions = new Dictionary<string, int>();

            while (input != "exam finished")
            {
                var tokens = input.Split('-');
                var name = tokens[0];
                if (tokens[1] == "banned")
                {
                    if (dictionary.ContainsKey(name))
                        dictionary.Remove(name);
                }
                else
                {
                    var language = tokens[1];
                    var points = int.Parse(tokens[2]);
                    if (!submissions.ContainsKey(language))
                        submissions[language] = 0;

                    submissions[language]++;

                    if (!dictionary.ContainsKey(name))
                        dictionary[name] = 0;

                    if (dictionary[name] < points)
                       dictionary[name] = points;

                }

                input = Console.ReadLine();
            }
            Console.WriteLine("Results:");
            foreach (var item in dictionary.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{item.Key} | {item.Value}");
            }
            Console.WriteLine("Submissions:");
            foreach (var item in submissions.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{item.Key} - {item.Value}");
            }
        }
    }
}