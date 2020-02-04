using System;
using System.Linq;

namespace Kamino_Factory
{
    class Program
    {
        static void Main()
        {
            int n = byte.Parse(Console.ReadLine());
            var sample = 0;
            var biggestSample = -1;
            var biggestArr = new int[n];
            var sequence = 1;
            var curSequence = -1;
            var biggestSequence = 0;
            var index = 0;
            var leftIndex = int.MaxValue;
            var biggestSum = 0;
            var input = Console.ReadLine();
            while (input != "Clone them!")
            {
                var arr = input.Split(new char[] { '!' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                curSequence = 0;
                sample++;
                for (int i = 0; i < arr.Length; i++)
                {
                    sequence = 1;
                    if (arr[i] == 1)
                    {
                        for (int j = i + 1; j < arr.Length; j++)
                        {
                            if (arr[i] == arr[j])
                            {
                                sequence++;
                            }
                            else
                                break;
                        }
                        if (sequence > curSequence)
                        {
                            curSequence = sequence;
                            index = i;
                        }
                    }                   
                }

                if (curSequence > biggestSequence)
                {
                    biggestSequence = curSequence;
                    biggestArr = arr;
                    biggestSum = arr.Sum();
                    leftIndex = index;
                    biggestSample = sample;
                }
                else if (curSequence == biggestSequence)
                {
                    if (leftIndex > index)
                    {
                        biggestArr = arr;
                        biggestSum = arr.Sum();
                        leftIndex = index;
                        biggestSample = sample;
                    }
                    else if (leftIndex == index)
                    {
                        if (biggestSum < arr.Sum())
                        {
                            biggestSum = arr.Sum();
                            biggestArr = arr;
                            biggestSample = sample;                          
                        }
                    }                   
                }               
                input = Console.ReadLine();
            }
            Console.WriteLine($"Best DNA sample {biggestSample} with sum: {biggestSum}.");
            Console.WriteLine(string.Join(" ", biggestArr));
        }
    }
}