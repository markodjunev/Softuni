using System;

namespace Padawan_Equipment
{
    class Program
    {
        static void Main(string[] args)
        {
            var money = double.Parse(Console.ReadLine());
            var students = double.Parse(Console.ReadLine());
            var priceSabers = double.Parse(Console.ReadLine());
            var priceRobe = double.Parse(Console.ReadLine());
            var priceBelt = double.Parse(Console.ReadLine());

            var sabers = (priceSabers * (Math.Ceiling(1.1 * students)));
            var robe = priceRobe * students;
            var freeBelts = 0;
            for (int i = 1; i <= students; i++)
            {
                if (i % 6 == 0)
                {
                    freeBelts--;
                }
            }
            var belt = priceBelt * (students + freeBelts);

            var res = sabers + robe + belt;
            if (res > money) Console.WriteLine($"Ivan Cho will need {(Math.Abs(money-res)):f2}lv more.");
            else Console.WriteLine($"The money is enough - it would cost {res:f2}lv.");
        }
    }
}