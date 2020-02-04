using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace p06.Courses
{
    class Program
    {
        static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var count = 0;
            var decryptedMessage = string.Empty;
            var attackedPlanets = new Dictionary<int, string>();
            var destroyedPlanets = new Dictionary<int, string>();
            var attackedCount = 0;
            var destroyedCount = 0;

            // STCDoghudd4=63333$D$0A53333

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                count = 0;
                for (int j = 0; j < input.Length; j++)
                {
                    if ((input[j] == 'S' || input[j] == 's') ||
                        (input[j] == 'T' || input[j] == 't') ||
                        (input[j] == 'A' || input[j] == 'a') ||
                        (input[j] == 'R' || input[j] == 'r'))
                    {
                        count++;
                    }
                }
                // PQ@Alderaa1:30000!A!->20000 - Decrypted message
                for (int k = 0; k < input.Length; k++)
                {
                    decryptedMessage = decryptedMessage + (char)(input[k] - count);
                }

                Regex order = new Regex(@"@(?<planet>[A-Za-z]+)([^@:!\->]*):(?<population>[0-9]+)([^@:!\->]*)!(?<attackType>(A|D))!([^@:!\->]*)->(?<soldierCount>[0-9]+)");

                if (order.IsMatch(decryptedMessage))
                {
                    string planet = order.Match(decryptedMessage).Groups["planet"].Value;
                    int population = int.Parse(order.Match(decryptedMessage).Groups["population"].Value);
                    char attackType = char.Parse(order.Match(decryptedMessage).Groups["attackType"].Value);
                    int soldierCount = int.Parse(order.Match(decryptedMessage).Groups["soldierCount"].Value);

                    if (attackType == 'A')
                    {
                        attackedCount++;
                        attackedPlanets.Add(attackedCount, planet);
                    }
                    else if (attackType == 'D')
                    {
                        destroyedCount++;
                        destroyedPlanets.Add(destroyedCount, planet);
                    }
                    decryptedMessage = string.Empty;
                }
            }

            var orderedAttacked = attackedPlanets.OrderBy(x => x.Value);
            var orderedDestroyed = destroyedPlanets.OrderBy(x => x.Value);

            Console.WriteLine($"Attacked planets: {orderedAttacked.Count()}");
            foreach (var item in orderedAttacked)
            {
                Console.WriteLine($"-> {item.Value}");
            }

            Console.WriteLine($"Destroyed planets: {orderedDestroyed.Count()}");
            foreach (var item in orderedDestroyed)
            {
                Console.WriteLine($"-> {item.Value}");
            }
        }
    }
}