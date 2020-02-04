using System;
using System.Linq;

namespace Change_List
{
    class Program
    {
        static void Main()
        {
            var list = Console.ReadLine().Split().Select(int.Parse).ToList();
            var input = Console.ReadLine();
            while (input != "end")
            {
                var tokens = input.Split();
                if (tokens[0] == "Delete")
                {
                    var num = int.Parse(tokens[1]);
                    list.RemoveAll(x => x == num);
                }
                else if (tokens[0] == "Insert")
                {
                    var num = int.Parse(tokens[1]);
                    var index = int.Parse(tokens[2]);
                    list.Insert(index, num);
                }
                input = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ", list));
        }
    }
}