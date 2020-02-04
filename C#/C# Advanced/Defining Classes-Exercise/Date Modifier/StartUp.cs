using System;

namespace Date_Modifier
{
    public  class StartUp
    {
        public static void Main()
        {
            string date1 = Console.ReadLine();
            string date2 = Console.ReadLine();

            Console.WriteLine(DateModifier.DatesDifference(date1, date2));

        }
    }
}