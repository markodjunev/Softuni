using System;
using System.Linq;

namespace Date_Modifier
{
    public class DateModifier
    {
        public static int DatesDifference(string date1, string date2)
        {
            int[] d1 = date1.Split().Select(int.Parse).ToArray();
            int[] d2 = date2.Split().Select(int.Parse).ToArray();

            DateTime dateOne = new DateTime(d1[0], d1[1], d1[2]);
            DateTime dateTwo = new DateTime(d2[0], d2[1], d2[2]);

            TimeSpan difference = dateOne.Subtract(dateTwo);
            return Math.Abs(difference.Days);
        }

    }
}