using System;

namespace _10.DataTypeFinder
{
    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();
            while (input != "END")
            {
                bool isBolean = bool.TryParse(input, out bool boolean);
                bool isInteger = int.TryParse(input, out int integer);
                bool isChar = char.TryParse(input, out char character);
                bool isDouble = double.TryParse(input, out double floating);

                if (isBolean) Console.WriteLine($"{input} is boolean type");
                
                else if (isInteger) Console.WriteLine($"{integer} is integer type");
               
                else if (isChar) Console.WriteLine($"{character} is character type");
                
                else if (isDouble) Console.WriteLine($"{input} is floating point type");
               
                else Console.WriteLine($"{input} is string type");
                
                input = Console.ReadLine();
            }
        }
    }
}