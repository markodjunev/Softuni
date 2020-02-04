using System;

namespace Extract_File
{
    class Program
    {
        static void Main()
        {
            var path = Console.ReadLine();
            var startIndex = path.LastIndexOf('\\')+1;
            var res = path.Substring(startIndex);
            var names = res.Split('.');
            Console.WriteLine($"File name: {names[0]}");
            Console.WriteLine($"File extension: {names[1]}");
        }
    }
}