using System;

namespace Generic_Box_of_Integer
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var number = new Box<int>(int.Parse(Console.ReadLine()));
                Console.WriteLine(number);
            }
        }
    }
}