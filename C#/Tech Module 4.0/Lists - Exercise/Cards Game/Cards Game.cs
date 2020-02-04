using System;
using System.Collections.Generic;
using System.Linq;

namespace Cards_Game
{
    class Program
    {
        static void Main()
        {
            var list1 = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            var list2 = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            while (list1.Count > 0 && list2.Count > 0)
            {
                for (int i = 0; i < 1; i++)
                {
                    if (list1[i] > list2[i])
                    {
                        list1.Add(list1[i]);
                        list1.Add(list2[i]);
                        list2.RemoveAt(i);
                        list1.RemoveAt(i);
                    }
                    else if (list2[i] > list1[i])
                    {
                        list2.Add(list2[i]);
                        list2.Add(list1[i]);
                        list1.RemoveAt(i);
                        list2.RemoveAt(i);
                    }
                    else
                    {
                        list1.RemoveAt(i);
                        list2.RemoveAt(i);
                    }
                }
            }
            if(list1.Count > list2.Count)
                Console.WriteLine($"First player wins! Sum: {list1.Sum()}");
            else
                Console.WriteLine($"Second player wins! Sum: {list2.Sum()}");
            
        }
    }
}