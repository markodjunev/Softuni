using System;

namespace Sum_of_Odd_Numbers
{
    class Program
    {
        static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var sum = 0;
            var curNum = 1;
            while (n > 0)
            {
                Console.WriteLine(curNum);
                sum += curNum;
                curNum += 2;
                n--;
            }            
            Console.WriteLine($"Sum: {sum}");
        }
    }
}