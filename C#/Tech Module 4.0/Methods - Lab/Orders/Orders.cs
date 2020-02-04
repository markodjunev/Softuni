using System;
using System.Collections.Generic;

namespace Orders
{
    class Orders
    {
        static void Order(string input, int quantity)
        {
            var dictionary = new Dictionary<string, double>();
            dictionary["coffee"] = 1.5;
            dictionary["water"] = 1;
            dictionary["coke"] = 1.4;
            dictionary["snacks"] = 2;
            Console.WriteLine($"{dictionary[input] * quantity:f2}");
        }
        static void Main()
        {            
            var input = Console.ReadLine();
            var quantity = int.Parse(Console.ReadLine());
            Order(input, quantity);
        }
    }
}