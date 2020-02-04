using System;
using System.Linq;

namespace List_Manipulation_Advanced
{
    class Program
    {
        static void Main()
        {
            var list = Console.ReadLine().Split().Select(int.Parse).ToList();
            var input = Console.ReadLine().Split(' ');
            var change = false;
            while (input[0] != "end")
            {
                var command = input[0];
                switch (command)
                {
                    case "Add":
                        list.Add(int.Parse(input[1]));
                        change = true; break;
                    case "Remove":
                        list.Remove(int.Parse(input[1]));
                        change = true; break;
                    case "RemoveAt":
                        list.RemoveAt(int.Parse(input[1]));
                        change = true; break;
                    case "Insert":
                        change = true;
                        var index = int.Parse(input[2]);
                        var num = int.Parse(input[1]);
                        list.Insert(index, num); break;
                }
                if (command == "Contains")
                {
                    var num = int.Parse(input[1]);
                    if(list.Contains(num))
                        Console.WriteLine("Yes");
                    else
                        Console.WriteLine("No such number");                    
                }
                else if (command == "PrintEven")
                    Console.WriteLine(string.Join(" ", list.Where(x=> x % 2 == 0)));
                else if (command == "PrintOdd")
                    Console.WriteLine(string.Join(" ", list.Where(x => x % 2 != 0)));
                else if (command == "GetSum")
                    Console.WriteLine(list.Sum());

                else if(command == "Filter")
                {
                    var sign = input[1];
                    var num = int.Parse(input[2]);
                    switch (sign)
                    {
                        case ">":
                            Console.WriteLine(string.Join(" ", list.Where(x => x > num))); break;
                        case ">=":
                            Console.WriteLine(string.Join(" ", list.Where(x => x >= num))); break;
                        case "<":
                            Console.WriteLine(string.Join(" ", list.Where(x => x < num))); break;
                        case "<=":
                            Console.WriteLine(string.Join(" ", list.Where(x => x <= num))); break;

                    }
                }
                input = Console.ReadLine().Split(' ');
            }
            if(change == true)
                Console.WriteLine(string.Join(" ", list));
        }
    }
}