using System;

namespace Ferrari
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            string driver = Console.ReadLine();
            IDrivable ferrari = new Ferrari(driver);
            Console.WriteLine(ferrari);
        }
    }
}