using System;

namespace Basic_Syntax__Conditional_Statements_and_Loops
{
    class Passed
    {
        static void Main()
        {
            var grade = double.Parse(Console.ReadLine());
            if (grade >= 3)
            {
                Console.WriteLine("Passed!");
            }
            else Console.WriteLine("(no output)"); 
        }
    }
}