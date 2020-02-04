using System;
using System.Collections.Generic;
using System.Linq;

namespace Car_Race
{
    class Program
    {
        static void Main()
        {
            var cars = Console.ReadLine().Split().Select(int.Parse).ToList();
            var leftSum = 0d;
            var rightSum = 0d;
            var midNum = cars.Count / 2;
            for (int i = 0; i < midNum; i++)
            {
                if (cars[i] != 0)
                    leftSum += cars[i];
                else
                    leftSum *= 0.8;
            }

            for (int i = cars.Count - 1; i > midNum; i--)
            {
                if (cars[i] != 0)
                    rightSum += cars[i];
                else
                    rightSum *= 0.8;
            }
            if(leftSum < rightSum)
                Console.WriteLine($"The winner is left with total time: {leftSum}");
            else
                Console.WriteLine($"The winner is right with total time: {rightSum}");

        }
    }
}