using System;

namespace Telephony
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            string[] numbers = Console.ReadLine().Split(new []{' '} , StringSplitOptions.RemoveEmptyEntries);
            string[] urls = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            Smartphone smartphone = new Smartphone();

            foreach (var number in numbers)
            {
                Console.WriteLine(smartphone.Call(number));
            }

            foreach (var url in urls)
            {
                Console.WriteLine(smartphone.Browse(url));
            }
        }
    }
}