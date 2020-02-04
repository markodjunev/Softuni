using System;
using System.Collections.Generic;
using System.Linq;

namespace _1
{
    class Program
    {
        static void Main()
        {
            var days = double.Parse(Console.ReadLine());
            var players = double.Parse(Console.ReadLine());
            var initialEnergy = double.Parse(Console.ReadLine());
            var waterPerPerson = double.Parse(Console.ReadLine());
            var foodPerPerson = double.Parse(Console.ReadLine());
            var totalWater = days * players * waterPerPerson;
            var totalFood = days * players * foodPerPerson;
            var curEnergy = initialEnergy;

            for (int i = 1; i <= days; i++)
            {
                var energyLoss = double.Parse(Console.ReadLine());
                curEnergy -= energyLoss;
                if (curEnergy <= 0)
                {
                    Console.WriteLine($"You will run out of energy. You will be left with {totalFood:f2} food and {totalWater:f2} water.");
                    return;
                }

                if (i % 2 == 0)
                {
                    curEnergy = curEnergy * 1.05;
                    totalWater = totalWater * 0.7;
                }

                if (i % 3 == 0)
                {
                    curEnergy = curEnergy * 1.1;
                    var usedFood = totalFood / players;
                    totalFood = totalFood - usedFood;
                }

            }
            Console.WriteLine($"You are ready for the quest. You will be left with - {curEnergy:f2} energy!");

        }
    }
}