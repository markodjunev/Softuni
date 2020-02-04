using System;
using System.Text;

namespace Repeat_Strings
{
    class Program
    {
        static void Main()
        {
            var words = Console.ReadLine().Split();
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < words.Length; i++)
            {
                var curWord = words[i];
                for (int j = 0; j < curWord.Length; j++)
                {
                    sb.Append(curWord);
                }
            }
            Console.WriteLine(sb.ToString());
        }
    }
}