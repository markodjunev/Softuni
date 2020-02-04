using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _1
{
    class Program
    {
        static void Main()
        {
            var line = Console.ReadLine();
            var pattern = @"^(?<name>[A-z0-9@#!\$\?]+)=(?<length>\d+)<<(?<code>.+)$";

            while (line != "Last note")
            {
                if (Regex.IsMatch(line, pattern))
                {
                    Match match = Regex.Match(line, pattern);
                    var sb = new StringBuilder();
                    var name = match.Groups["name"].Value;
                    int length = int.Parse(match.Groups["length"].Value);
                    var code = match.Groups["code"].Value;

                    var arr = name.ToList();
                    for (int i = 0; i < arr.Count; i++)
                    {
                        var symb = arr[i];
                        if (char.IsLetterOrDigit(symb))
                        {
                            sb.Append(symb);
                        }
                    }

                    name = sb.ToString();

                    if (code.Length == length && sb.Length > 0)
                    {
                        Console.WriteLine($"Coordinates found! {name} -> {code}");
                    }
                    else
                    {
                        Console.WriteLine("Nothing found!");
                    }
                }
                else
                {
                    Console.WriteLine("Nothing found!");
                }

                line = Console.ReadLine();
            }
        }
    }
}