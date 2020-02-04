using System;
using System.Linq;

namespace Action_Print
{
    class Program
    {
        static void Main()
        {
            Action<string> print = x => Console.WriteLine(x);

            Console.ReadLine().Split().ToList().ForEach(print);
        }
    }
}