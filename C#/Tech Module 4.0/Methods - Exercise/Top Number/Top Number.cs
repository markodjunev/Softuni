using System;

namespace Top_Number
{
    class Program
    {
        static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            
            for (int i = 10; i < n; i++)
            {
                var curNum = i;
                var sum = 0;
                var isOdd = false;
                while (curNum > 0)
                {
                    var lastDigit = curNum % 10;
                    if (lastDigit % 2 != 0)
                        isOdd = true;

                    curNum /= 10;
                    sum += lastDigit;
                }
                if(sum % 8 == 0 && isOdd == true)
                    Console.WriteLine(i);
            }
        }
    }
}