﻿using System;
using System.Text.RegularExpressions;

namespace Match_Dates
{
    class Program
    {
        static void Main()
        {
            var regex = @"\b(?<day>\d{2})([-.\/])(?<month>[A-Z][a-z]{2})\1(?<year>\d{4})\b";
            var dates = Console.ReadLine();
            var matched = Regex.Matches(dates, regex);

            foreach (Match date in matched)
            {
                var day = date.Groups["day"].Value;
                var month = date.Groups["month"].Value;
                var year = date.Groups["year"].Value;
                Console.WriteLine($"Day: {day}, Month: {month}, Year: {year}");
            }
        }
    }
}