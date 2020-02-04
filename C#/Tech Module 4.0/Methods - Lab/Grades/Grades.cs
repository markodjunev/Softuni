using System;

namespace Grades
{
    class Grades
    {
        static void PrintGrade(double number)
        {
            if(number >= 2.00 && number < 3)
                Console.WriteLine("Fail");
            else if (number >= 3 && number < 3.51)
                Console.WriteLine("Poor");
            else if(number >= 3.5 && number < 4.5)
                Console.WriteLine("Good");
            else if(number >= 4.50 && number < 5.5)
                Console.WriteLine("Very good");
            else if(number >= 5.5 && number <= 6)
                Console.WriteLine("Excellent");
        }
        static void Main()
        {
            double n = double.Parse(Console.ReadLine());
            PrintGrade(n);
        }
    }
}