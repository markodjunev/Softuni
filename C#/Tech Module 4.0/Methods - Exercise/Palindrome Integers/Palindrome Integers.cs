using System;

namespace Palindrome_Integers
{
    class Program
    {
        static void Main()
        {
            var input = Console.ReadLine();
            while (input != "END")
            {
                var num1 = input.ToCharArray();
                var num2 = new char[num1.Length];
                Array.Copy(num1, num2, num1.Length);
               
                if (num1 == num2)
                    Console.WriteLine("true");
                else
                    Console.WriteLine("false");

                input = Console.ReadLine();
            }
        }
    }
}