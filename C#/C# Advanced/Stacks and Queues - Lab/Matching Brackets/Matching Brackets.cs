<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;

namespace Problem4_Matching_Brackets
{
    class BracketsDemo
    {
        static void Main()
        {
            var input = Console.ReadLine();
            var indexes = new Stack<int>();
            var expressions = new List<string>();

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '(')
                    indexes.Push(i);

                else if (input[i] == ')')
                {
                    var startIndex = indexes.Pop();

                    var expr = input.Substring(startIndex, i - startIndex + 1);
                    expressions.Add(expr);
                }
            }
            Console.WriteLine(string.Join("\n", expressions));
        }
    }
=======
﻿using System;
using System.Collections.Generic;

namespace Problem4_Matching_Brackets
{
    class BracketsDemo
    {
        static void Main()
        {
            var input = Console.ReadLine();
            var indexes = new Stack<int>();
            var expressions = new List<string>();

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '(')
                    indexes.Push(i);

                else if (input[i] == ')')
                {
                    var startIndex = indexes.Pop();

                    var expr = input.Substring(startIndex, i - startIndex + 1);
                    expressions.Add(expr);
                }
            }
            Console.WriteLine(string.Join("\n", expressions));
        }
    }
>>>>>>> 6f4f235c52a7e08aaadcb7b47dd53dd6dfd4e3cb
}