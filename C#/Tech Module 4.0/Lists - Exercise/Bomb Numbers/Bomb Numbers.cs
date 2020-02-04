using System;
using System.Linq;

namespace Bomb_Numbers
{
    class Program
    {
        static void Main()
        {
            var list = Console.ReadLine().Split().Select(int.Parse).ToList();            
            var input = Console.ReadLine().Split().Select(int.Parse).ToList();
            var detonationNum = input[0];
            var power = input[1];
            for (int i = 0; i < list.Count; i++)
            {
                var curI = i;
                if (list[i] == detonationNum)
                {
                    for (int j = 1; j <= power; j++)
                    {
                        var leftNum = i - 1;
                        if (leftNum >= 0)
                        {
                            list.RemoveAt(leftNum);
                            i--;
                        }

                        var rightNum = i + 1;

                        if (rightNum < list.Count)
                            list.RemoveAt(rightNum);                        
                    }
                }

                i = curI;
            }

            list.RemoveAll(x => x == detonationNum);
            Console.WriteLine(list.Sum());
        }
    }
}