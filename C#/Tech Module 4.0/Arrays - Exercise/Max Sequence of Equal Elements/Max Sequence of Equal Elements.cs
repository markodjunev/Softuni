using System;
using System.Linq;

namespace Max_Sequence_of_Equal_Elements
{
    class Program
    {
        static void Main()
        {
            var arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var sequence = 0;
            var biggestSeq = 1;
            int num = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sequence = 1;
                for (int j = i+1; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        sequence++;
                    }
                    else
                        break;
                }
                if (sequence > biggestSeq)
                {
                    biggestSeq = sequence;
                    num = arr[i];
                }
            }
            var arr2 = new int[biggestSeq];
            for (int i = 0; i < arr2.Length; i++)
            {
                arr2[i] = num;
            }
            Console.WriteLine(string.Join(" ", arr2));
        }
    }
}