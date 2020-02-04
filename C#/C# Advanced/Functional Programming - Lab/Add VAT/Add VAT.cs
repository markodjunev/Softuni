using System;
using System.Linq;

namespace Add_VAT
{
    class Program
    {
        static void Main()
        {
            Func<double, double> addVat = p => p * 1.2;

            Console.ReadLine()
                .Split(new[] { ", " }, StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .Select(addVat)
                .ToList()
                .ForEach(p => Console.WriteLine($"{p:F2}"));
        }
    }
}