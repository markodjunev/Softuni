<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;

namespace Reverse_Strings
{
    class Program
    {
        static void Main()
        {
            var input = Console.ReadLine();
            var reversedString = new Stack<char>();
            foreach (var ch in input)
            {
                reversedString.Push(ch);
            }

            while (reversedString.Count != 0)
            {
                var sym = reversedString.Pop();
                Console.Write(sym);
            }
            Console.WriteLine();
        }
    }
=======
﻿using System;
using System.Collections.Generic;

namespace Reverse_Strings
{
    class Program
    {
        static void Main()
        {
            var input = Console.ReadLine();
            var reversedString = new Stack<char>();
            foreach (var ch in input)
            {
                reversedString.Push(ch);
            }

            while (reversedString.Count != 0)
            {
                var sym = reversedString.Pop();
                Console.Write(sym);
            }
            Console.WriteLine();
        }
    }
>>>>>>> 6f4f235c52a7e08aaadcb7b47dd53dd6dfd4e3cb
}