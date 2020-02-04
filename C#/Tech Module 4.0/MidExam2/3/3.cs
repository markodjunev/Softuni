using System;
using System.Collections.Generic;
using System.Linq;

namespace _3
{
    class Program
    {
        static void Main()
        {
            var list = Console.ReadLine().Split(' ').ToList();
            var input = Console.ReadLine();
            while (input != "Stop")
            {
                var tokens = input.Split(' ');
                var command = tokens[0];
                if (command == "Delete")
                {
                    var index = int.Parse(tokens[1]);
                    index += 1;
                    if (index >= 0 && index < list.Count)
                    {
                        list.RemoveAt(index);
                    }
                }
                else if (command == "Sort")
                {
                    list.Sort();
                    list.Reverse();
                }
                else if(command == "Put")
                {
                    var word = tokens[1];
                    var index = int.Parse(tokens[2]);
                    index -= 1;
                    if (index == list.Count)
                    {
                        list.Add(word);
                    }
        
                    else if(index >= 0 && index < list.Count)
                    {
                        list.Insert(index, word);
                    }
                }
                else if(command == "Replace")
                {
                    var word1 = tokens[1];
                    var word2 = tokens[2];
                    if (list.Contains(word2))
                    {
                        list[list.FindIndex(ind => ind.Equals(word2))] = word1;
                    }
                }
                else if(command == "Swap")
                {
                    var word1 = tokens[1];
                    var word2 = tokens[2];
                    if (list.Contains(word1) && list.Contains(word2))
                    {
                        var index1 = list.IndexOf(word1);
                        var index2 = list.IndexOf(word2);
                        list.Insert(index1, word2);
                        list.RemoveAt(index1 + 1);
                        list.Insert(index2, word1);
                        list.RemoveAt(index2 + 1);
                    }
                }
                input = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ", list));

        }
    }
}