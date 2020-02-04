using System;

namespace Generic_Box_of_String
{
    public class StartUp
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var item = new Box<string>(Console.ReadLine());
                Console.WriteLine(item);
            }
        }
    }
}