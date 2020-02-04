using System;
using System.Collections.Generic;
using System.Linq;

namespace _2
{
    class Program
    {
        static void Main()
        {
            var input = Console.ReadLine().Split('#').ToList();
            var water = double.Parse(Console.ReadLine());
            double effort = 0;
            var list = new List<double>();

            for (int i = 0; i < input.Count; i++)
            {
                var tokens = input[i].Split(new string[] {" = "}, StringSplitOptions.RemoveEmptyEntries);
                var type = tokens[0];
                var value = double.Parse(tokens[1]);
                if (water - value >= 0)
                {
                    if (type == "High")
                    {
                        if (value >= 81 && value <= 125)
                        {
                            list.Add(value);
                            water -= value;
                            double curEffort = value * 0.25;
                            effort += curEffort;
                        }
                    }
                    else if (type == "Medium")
                    {
                        if (value >= 51 && value <= 80)
                        {
                            list.Add(value);
                            water -= value;
                            double curEffort = value * 0.25;
                            effort += curEffort;
                        }
                    }
                    else if (type == "Low")
                    {
                        if (value >= 1 && value <= 50)
                        {
                            list.Add(value);
                            water -= value;
                            double curEffort = value * 0.25;
                            effort += curEffort;
                        }
                    }
                }               
            }

            Console.WriteLine("Cells:");
            foreach (var item in list)
            {
                Console.WriteLine($" - {item}");
            }
            Console.WriteLine($"Effort: {effort:f2}");
            Console.WriteLine($"Total Fire: {list.Sum()}");
        }
    }
}