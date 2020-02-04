using System;
using System.Linq;

namespace LadyBugs1
{
    class LadyBugs1
    {
        static void Main()
        {
            var size = long.Parse(Console.ReadLine());
            var arr = new long[size];
            var initialIndexes = Console.ReadLine().Split().Select(long.Parse).ToArray();
            for (long i = 0; i < arr.Length; i++)
            {
                if (initialIndexes.Contains(i))
                    arr[i] = 1;
                else
                    arr[i] = 0;

            }
            var input = Console.ReadLine();
            while (input != "end")
            {
                var input2 = input.Split(' ').ToArray();
                var ladyBugIndex = long.Parse(input2[0]);
                var isAvailable = false;
                for (long i = 0; i < arr.Length; i++)
                {
                    if (arr[i] == 1 && ladyBugIndex == i)
                    {
                        isAvailable = true;
                        break;
                    }
                }
                var command = input2[1];
                var offset = long.Parse(input2[2]);
                long curIndex = 0;
                if (command == "right")
                {
                    if (offset < 0)
                        command = "left";
                }
                if (command == "left")
                {
                    if (offset < 0)
                        command = "right";
                }
                if (command == "right")
                {
                    if (isAvailable == true && offset != 0)
                    {
                        curIndex = ladyBugIndex + Math.Abs(offset);
                        if (curIndex < arr.Length)
                        {
                            for (long i = curIndex; i < arr.Length; i++)
                            {
                                if (arr[i] == 0)
                                {
                                    arr[i] = 1;
                                    break;
                                }
                            }
                            arr[ladyBugIndex] = 0;

                        }
                        else
                            arr[ladyBugIndex] = 0;
                    }
                }

                else if (command == "left")
                {
                    if (isAvailable == true && offset != 0)
                    {
                        curIndex = ladyBugIndex - Math.Abs(offset);
                        if (curIndex < arr.Length && curIndex > 0)
                        {
                            for (long i = curIndex; i >= 0; i--)
                            {
                                if (arr[i] == 0)
                                {
                                    arr[i] = 1;
                                    break;
                                }
                            }
                            arr[ladyBugIndex] = 0;
                        }
                        else
                            arr[ladyBugIndex] = 0;
                    }
                }
                input = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ", arr));
        }
    }
}