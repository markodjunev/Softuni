using System;

namespace Vending_Machine
{
    class Program
    {
        static void Main()
        {
            var input = Console.ReadLine();
            double sum = 0.0;
            while (input != "Start")
            {
                var coins = double.Parse(input);
                if (coins == 0.1 || coins == 0.2 || coins== 0.5 || coins == 1 || coins == 2) sum += coins;
                else Console.WriteLine($"Cannot accept {coins}");
                input = Console.ReadLine();
            }
            input = Console.ReadLine();
            while (input != "End")
            {
                var price = 0.0;
                var isAvailable = true;
                    switch (input)
                    {
                        case "Nuts": price = 2.0; break;
                        case "Water": price = 0.7; break;
                        case "Crisps": price = 1.5; break;
                        case "Soda": price = 0.8; break;
                        case "Coke": price = 1.0; break;                       
                        default:
                        Console.WriteLine("Invalid product");
                        isAvailable = false;
                        break;
                    }
                if (sum >= price && isAvailable == true)
                {
                    sum = sum - price;
                    Console.WriteLine($"Purchased {input.ToLower()}");
                }
                else if(sum < price && isAvailable == true)
                {
                    Console.WriteLine("Sorry, not enough money");
                }

                input = Console.ReadLine();

            }
            Console.WriteLine($"Change: {sum:f2}");
        }
    }
}