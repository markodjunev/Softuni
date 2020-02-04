﻿namespace P01_StacksAndQueues
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            int greenLightLength = int.Parse(Console.ReadLine());
            int freeWindow = int.Parse(Console.ReadLine());

            Queue<string> lane = new Queue<string>();
            int totalCarsPassed = 0;

            string input;
            while ((input = Console.ReadLine()) != "END")
            {
                if (input != "green")
                {
                    lane.Enqueue(input);
                    continue;
                }

                int currentGreenLight = greenLightLength;

                string passingCar = null;
                while (currentGreenLight > 0 && lane.Any())
                {
                    passingCar = lane.Dequeue();
                    currentGreenLight -= passingCar.Length;
                    totalCarsPassed++;
                }

                int freeWindowLeft = freeWindow + currentGreenLight;
                if (freeWindowLeft < 0)
                {
                    int symbolsThatDidntPass = Math.Abs(freeWindowLeft);
                    int indexOfHitSymbol = passingCar.Length - symbolsThatDidntPass;
                    char symbolHit = passingCar[indexOfHitSymbol];
                    Console.WriteLine("A crash happened!");
                    Console.WriteLine($"{passingCar} was hit at {symbolHit}.");
                    return;
                }
            }

            Console.WriteLine("Everyone is safe.");
            Console.WriteLine($"{totalCarsPassed} total cars passed the crossroads.");
        }
    }
}