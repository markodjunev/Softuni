using System;

namespace Encrypt__Sort_and_Print_Array
{
    class Program
    {
        static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var arr = new int[n];
            var res = 0;

            for (int i = 0; i < n; i++)
            {
                var vowel = 0;
                var consonant = 0;
                var input = Console.ReadLine();
                for (int j = 0; j < input.Length; j++)
                {
                    if (input[j] == 'A' || input[j] == 'E' || input[j] == 'I' || input[j] == 'O' || input[j] == 'U'
                    || input[j] == 'a' || input[j] == 'e' || input[j] == 'i' || input[j] == 'o' || input[j] == 'u')
                    {
                        vowel += (int)input[j] * input.Length;
                    }
                    else
                        consonant += (int)input[j] / input.Length;
                }
                res = vowel + consonant;
                arr[i] = res;
            }
            Array.Sort(arr);
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
        }
    }
}