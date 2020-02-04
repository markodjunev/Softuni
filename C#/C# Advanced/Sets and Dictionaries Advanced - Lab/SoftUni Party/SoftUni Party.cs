using System;
using System.Collections.Generic;

namespace SoftUni_Party
{
    class Program
    {
        static void Main()
        {
            var guest = Console.ReadLine();
            var vip = new HashSet<string>();
            var regular = new HashSet<string>();


            while (guest != "PARTY")
            {
                var firstChar = guest[0];

                if (char.IsDigit(firstChar))
                    vip.Add(guest);
                else
                    regular.Add(guest);

                guest = Console.ReadLine();
            }

            guest = Console.ReadLine();

            while (guest != "END")
            {
                var firstChar = guest[0];

                if (char.IsDigit(firstChar))
                {
                    if (vip.Contains(guest))
                        vip.Remove(guest);
                }
                else
                {
                    if (regular.Contains(guest))
                        regular.Remove(guest);
                }

                guest = Console.ReadLine();
            }

            Console.WriteLine(vip.Count + regular.Count);

            foreach (var person in vip)
            {
                Console.WriteLine(person);
            }
            foreach (var person in regular)
            {
                Console.WriteLine(person);
            }
        }
    }
}