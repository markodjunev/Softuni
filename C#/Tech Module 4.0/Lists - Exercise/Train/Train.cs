using System;
using System.Linq;

namespace Train
{
    class Train
    {
        static void Main()
        {
            var list = Console.ReadLine().Split().Select(int.Parse).ToList();
            var maxCapacity = int.Parse(Console.ReadLine());
            var input = Console.ReadLine();
            while (input != "end")
            {
                var tokens = input.Split();
                if (tokens[0] == "Add")
                {
                    var num = int.Parse(tokens[1]);
                    if (num <= maxCapacity)
                        list.Add(num);                   
                }
                else
                {
                    var num = int.Parse(tokens[0]);
                    for (int i = 0; i < list.Count; i++)
                    {
                        if (list[i] + num <= maxCapacity)
                        {
                            list[i] += num;
                            break;
                        }
                    }
                }

                input = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ", list));
        }
    }
}