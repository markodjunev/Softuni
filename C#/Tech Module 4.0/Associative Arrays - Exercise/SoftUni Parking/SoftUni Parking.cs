using System;
using System.Collections.Generic;
using System.Linq;

namespace SoftUni_Parking
{
    class Program
    {
        static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var dictionary = new Dictionary<string, string>();
            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split();
                var command = input[0];
                var name = input[1];
                if (command == "register")
                {
                    var licenseNum = input[2];
                    if (!dictionary.ContainsKey(name))
                    {
                        dictionary[name] = licenseNum;
                        Console.WriteLine($"{name} registered {licenseNum} successfully");
                    }

                    else
                        Console.WriteLine($"ERROR: already registered with plate number {licenseNum}");                   
                }

                else if (command == "unregister")
                {
                    if (dictionary.ContainsKey(name))
                    {
                        dictionary.Remove(name);
                        Console.WriteLine($"{name} unregistered successfully");
                    }
                    else
                        Console.WriteLine($"ERROR: user {name} not found");                 
                }
            }

            foreach (var item in dictionary)
            {
                Console.WriteLine($"{item.Key} => {item.Value}");
            }
        }
    }
}