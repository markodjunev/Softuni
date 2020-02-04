using System;
using System.Linq;

namespace Common_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            var input1 = Console.ReadLine().Split(' ').ToArray();
            var input2 = Console.ReadLine().Split(' ').ToArray();
            for (int i = 0; i < input2.Length; i++)
            {
                for (int j = 0; j < input1.Length; j++)
                {
                    if (input2[i] == input1[j])
                    {
                        Console.Write(input2[i] + " ");
                    }
                }
            }
            Console.WriteLine();
        }
    }
}