using System;
using System.Collections.Generic;
using System.Linq;

namespace Merging_Lists
{
    class Program
    {
        static void Main()
        {
            var list1 = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var list2 = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var list3 = new List<int>();
            var index = 0;
            if (list1.Count() > list2.Count())
            {
                for (int i = 1; index < list2.Count(); i+=2)
                {
                    list1.Insert(i, list2[index]);
                    index++;
                }

                list3.AddRange(list1);
            }
            else if (list1.Count() < list2.Count())
            {
                for (int i = 0; index < list1.Count(); i+=2)
                {
                    list2.Insert(i, list1[index]);
                    index++;
                }
                list3.AddRange(list2);
            }
            else
            {
                var count = 0;
                for (int i = 0; index < list1.Count(); i++)
                {
                    if (i % 2 == 0)
                    {
                        list3.Add(list1[index]);
                        count++;
                    }
                    else
                    {
                        list3.Add(list2[index]);
                        count++;
                    }

                    if (count % 2 == 0)
                        index++;
                }
            }
            Console.WriteLine(string.Join(" ", list3));
        }
    }
}