using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.Mixed_up_Lists
{
    class Program
    {
        static void Main()
        {
            var list1 = Console.ReadLine().Split().Select(int.Parse).ToList();
            var list2 = Console.ReadLine().Split().Select(int.Parse).ToList();
            var specialNum = new List<int>();
            var maxList = new List<int>();
            var mixedList = new List<int>();
            if (list1.Count > list2.Count)
                maxList = list1;
            else
            {
                maxList = list2;
                maxList.Reverse();
            }
            for (int i = maxList.Count - 2; i < maxList.Count; i++)
            {
                specialNum.Add(maxList[i]);
            }
            specialNum.Sort();
            if (list1.Count > list2.Count)
            {
                list1.RemoveRange(list1.Count - 2, 2);
                list2.Reverse();
            }
            else
            {
                list2.RemoveRange(list2.Count - 2, 2);
                list2.Reverse();
            }
            for (int i = 0; i < list1.Count; i++)
            {
                mixedList.Add(list1[i]);
                mixedList.Add(list2[i]);
            }
            List<int> output = mixedList.FindAll(x => x > specialNum[0] && x < specialNum[1]);
            output.Sort();
            Console.WriteLine(string.Join(" ", output));
        }
    }
}