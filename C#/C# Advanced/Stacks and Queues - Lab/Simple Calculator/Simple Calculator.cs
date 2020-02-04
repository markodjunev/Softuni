<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace Simple_Calculator
{
    class Program
    {
        static void Main()
        {
            var numbers = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            var stack = new Stack<string>(numbers.Reverse());
            var sum = int.Parse(stack.Pop());

            while (stack.Count != 0)
            {
                var opr = stack.Pop();
                switch (opr)
                {
                    case "+": sum += int.Parse(stack.Pop());
                        break;
                    case "-":
                        sum -= int.Parse(stack.Pop());
                        break;
                }
            }
            Console.WriteLine(sum);
        }
    }
=======
﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace Simple_Calculator
{
    class Program
    {
        static void Main()
        {
            var numbers = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            var stack = new Stack<string>(numbers.Reverse());
            var sum = int.Parse(stack.Pop());

            while (stack.Count != 0)
            {
                var opr = stack.Pop();
                switch (opr)
                {
                    case "+": sum += int.Parse(stack.Pop());
                        break;
                    case "-":
                        sum -= int.Parse(stack.Pop());
                        break;
                }
            }
            Console.WriteLine(sum);
        }
    }
>>>>>>> 6f4f235c52a7e08aaadcb7b47dd53dd6dfd4e3cb
}