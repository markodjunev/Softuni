using System;

namespace English_Name_of_the_Last_Digit
{
    class Program
    {
        static void LastDigit(int a)
        {
            var lastDigit = a % 10;
            string num = string.Empty;
            switch (lastDigit)
            {
                case 0: num = "zero"; break;
                case 1: num = "one"; break;
                case 2: num = "two"; break;
                case 3: num = "three"; break;
                case 4: num = "four"; break;
                case 5: num = "five"; break;
                case 6: num = "six"; break;
                case 7: num = "seven"; break;
                case 8: num = "eight"; break;
                case 9: num = "nine"; break;

            }
            Console.WriteLine(num);
        }

        static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            LastDigit(n);

        }
    }
}