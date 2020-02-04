using System;
using System.Linq;

namespace Pokemon_Don_t_Go
{
    class Program
    {
        static void Main()
        {
            var list = Console.ReadLine().Split().Select(int.Parse).ToList();
            var sum = 0;
            while (list.Count > 0)
            {
                var index = int.Parse(Console.ReadLine());
                if (index < 0)
                {
                    var elem = list[0];
                    sum += elem;
                    list.RemoveAt(0);
                    list.Insert(0, list[list.Count - 1]);
                    for (int i = 0; i < list.Count; i++)
                    {
                        if (list[i] <= elem)
                            list[i] += elem;
                        else
                            list[i] -= elem;
                    }
                }
                else if (index >= list.Count)
                {
                    var elem = list[list.Count - 1];
                    sum += elem;
                    list.RemoveAt(list.Count - 1);
                    list.Add(list[0]);
                    for (int i = 0; i < list.Count; i++)
                    {
                        if (list[i] <= elem)
                            list[i] += elem;
                        else
                            list[i] -= elem;
                    }
                }
                else
                {
                    var elem = list[index];
                    sum += elem;
                    list.RemoveAt(index);
                    for (int i = 0; i < list.Count; i++)
                    {
                        if (list[i] <= elem)
                            list[i] += elem;
                        else
                            list[i] -= elem;
                    }
                }
            }
            Console.WriteLine(sum);
        }
    }
}