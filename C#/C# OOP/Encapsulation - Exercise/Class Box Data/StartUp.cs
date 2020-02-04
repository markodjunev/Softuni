using System;
using Class_Box_Data.Models;

namespace Class_Box_Data
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var length = double.Parse(Console.ReadLine());
            var width = double.Parse(Console.ReadLine());
            var height = double.Parse(Console.ReadLine());

            var box = new Box(length, width, height);

            try
            {
                Console.WriteLine(box);
            }
            catch (ArgumentException exception)
            {
                Console.WriteLine(exception.Message);
            }
        }
    }
}