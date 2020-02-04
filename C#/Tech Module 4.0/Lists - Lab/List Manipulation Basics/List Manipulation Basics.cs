using System;
using System.Linq;

namespace List_Manipulation_Basics
{
    class Program
    {
        static void Main()
        {
            var list = Console.ReadLine().Split().Select(int.Parse).ToList();
            var input = Console.ReadLine().Split(' ');
            while (input[0] != "end")
            {
                var command = input[0];
                switch (command)
                {
                    case "Add":
                        list.Add(int.Parse(input[1])); break;
                    case "Remove":
                        list.Remove(int.Parse(input[1])); break;
                    case "RemoveAt":
                        list.RemoveAt(int.Parse(input[1])); break;
                    case "Insert":
                        var index = int.Parse(input[2]);
                        var num = int.Parse(input[1]);
                        list.Insert(index, num);break;
                }
                input = Console.ReadLine().Split(' ');
            }
            Console.WriteLine(string.Join(" ", list));
        }
    }
}