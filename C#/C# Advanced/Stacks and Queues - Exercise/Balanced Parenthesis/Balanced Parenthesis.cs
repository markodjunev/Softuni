
namespace Balanced_Parenthesis
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            // "{, [, (, ), ], }
            var input = Console.ReadLine();
            var stack = new Stack<char>();
            var stack2 = new Stack<char>(input);
            var flag = true;
            if (!(stack2.Contains('}') || stack2.Contains(')') || stack2.Contains(']')) || (input.Length % 2 != 0))
            {
                Console.WriteLine("NO");
                return;
            }

            foreach (char symb in input)
            {
                switch (symb)
                {
                    case '[':
                    case '(':
                    case '{':
                        stack.Push(symb);
                        break;

                    case '}':
                        if (!stack.Any())
                            flag = false;

                        else if (stack.Pop() != '{')
                            flag = false;
                        break;

                    case ')':
                        if (!stack.Any())
                            flag = false;

                        else if (stack.Pop() != '(')
                            flag = false;
                        break;

                    case ']':
                        if (!stack.Any())
                            flag = false;

                        else if (stack.Pop() != '[')
                            flag = false;
                        break;                
                }

                if (!flag)
                    break;
            }
          
            // is balanced?
            Console.WriteLine(flag ? "YES" : "NO");
        }
    }
}