using System;
using System.Linq;

namespace List_Operations
{
    class Program
    {
        static void Main()
        {
            var list = Console.ReadLine().Split().Select(int.Parse).ToList();
            var input = Console.ReadLine();
            while (input != "End")
            {
                var tokens = input.Split(' ');
                var command = tokens[0];
                if (command == "Add")            
                    list.Add(int.Parse(tokens[1]));                
                else if (command == "Remove")
                {
                    var num = int.Parse(tokens[1]);
                    if (num < 0 || num > list.Count)
                        Console.WriteLine("Invalid index");
                    else
                        list.RemoveAt(num);

                }
                else if (command == "Insert")
                {
                    var num = int.Parse(tokens[1]);
                    var ind = int.Parse(tokens[2]);
                    if (ind < 0 || ind > list.Count())
                        Console.WriteLine("Invalid index");
                    else
                        list.Insert(ind, num);
                }
                else if(command == "Shift")
                {
                    var direction = tokens[1];
                    var num = int.Parse(tokens[2]);
                    if (direction == "left")
                    {
                        for (int i = 0; i < num; i++)
                        {
                            var first = list[0];
                            list.Add(first);
                            list.RemoveAt(0);
                        }
                    }
                    else if (direction == "right")
                    {
                        for (int i = 0; i < num; i++)
                        {
                            var last = list[list.Count - 1];
                            list.Insert(0, last);
                            list.RemoveAt(list.Count - 1);
                        }
                    }
                }
                input = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ", list));
        }
    }
}