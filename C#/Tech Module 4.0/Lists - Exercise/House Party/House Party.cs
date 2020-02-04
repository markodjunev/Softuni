using System;
using System.Collections.Generic;

namespace House_Party
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            var list = new List<string>();
            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split(new char[]{' ', '!'}, StringSplitOptions.RemoveEmptyEntries);
                var name = input[0];
                if (input.Length == 3 && input[1] == "is" && input[2] == "going")
                {
                    if(!list.Contains(name))
                        list.Add(name);
                    else
                        Console.WriteLine($"{name} is already in the list!");                  
                }
                else
                {
                    if (list.Contains(name))
                        list.Remove(name);
                    else
                        Console.WriteLine($"{name} is not in the list!");
                }
            }

            foreach (var item in list)
            {
               Console.WriteLine(item); 
            }
        }
    }
}