using System;
using System.Collections.Generic;
using System.Linq;

namespace Top_Integers
{
    class Program
    {
        static void Main()
        {
            var arr1 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var list = new List<int>();
            for (int i = 0; i < arr1.Length; i++)
            {
                var isBigger = true;
                for (int j = i + 1; j < arr1.Length; j++)
                {
                    if (arr1[i] > arr1[j])
                    {
                        continue;
                    }
                    else
                    {
                        isBigger = false;
                        break;
                    } 
                }
                if(isBigger == true)
                {
                    list.Add(arr1[i]);
                }                   
            }
            Console.WriteLine(string.Join(" ", list));
        }
    }
}