using System;

namespace Day_of_Week
{
    class Program
    {
        static void Main()
        {
            var day = int.Parse(Console.ReadLine());
            string[] arr = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
            if(day > 0 && day <= 7) Console.WriteLine(arr[day - 1]);

            else Console.WriteLine("Invalid day!");

            //switch (day)
            //{
            //    case 1: Console.WriteLine("Monday"); break;
            //    case 2: Console.WriteLine("Tuesday"); break;
            //    case 3: Console.WriteLine("Wednesday"); break;
            //    case 4: Console.WriteLine("Thursday"); break;
            //    case 5: Console.WriteLine("Friday"); break;
            //    case 6: Console.WriteLine("Saturday"); break;
            //    case 7: Console.WriteLine("Sunday"); break;
            //    default: Console.WriteLine("Invalid day!"); break;
            //}
        }
    }
}