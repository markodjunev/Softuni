using System;

namespace Foreign_Languages
{
    class Program
    {
        static void Main()
        {
            var input = Console.ReadLine();
            if (input == "USA" || input == "England")
            {
                Console.WriteLine("English");

            }
            else if (input == "Spain" || input == "Argentina" || input == "Mexico")
            {
                Console.WriteLine("Spanish");

            }
            else
            {
                Console.WriteLine("unknown");

            }
        }
    }
}