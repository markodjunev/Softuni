using System;
using System.Collections.Generic;
namespace Valid_Usernames
{
    class Program
    {
        static void Main()
        {
            var input = Console.ReadLine().Split(new[] {", "}, StringSplitOptions.RemoveEmptyEntries);
            var res = new List<string>();
            for (int i = 0; i < input.Length; i++)
            {
                var word = input[i];
                var isValid = true;
                if (word.Length >= 3 && word.Length <= 12)
                {
                    for (int j = 0; j < word.Length; j++)
                    {
                        var symbol = word[j];
                        if (char.IsLetterOrDigit(symbol) || symbol == '-' || symbol == '_')
                            isValid = true;

                        else
                        {
                            isValid = false;
                            break;
                        }
                    }
                    if (isValid == true)
                        res.Add(word);
                }           
            }

            foreach (var item in res)
            {
               Console.WriteLine(item); 
            }
        }
    }
}