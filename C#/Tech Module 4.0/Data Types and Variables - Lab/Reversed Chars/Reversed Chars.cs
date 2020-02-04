using System;

namespace Reversed_Chars
{
    class Program
    {
        static void Main()
        {
            var arr = new string[3];
            for (int i = 0; i < 3; i++)
            {
                var input = Console.ReadLine();
                arr[i] = input;
            }
            Array.Reverse(arr);
            foreach (var item in arr)
            {
                Console.Write(item + " ");
            }
        }
    }
}