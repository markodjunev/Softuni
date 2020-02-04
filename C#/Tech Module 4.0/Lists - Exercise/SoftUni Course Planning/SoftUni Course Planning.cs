using System;
using System.Linq;

namespace SoftUni_Course_Planning
{
    class Program
    {
        static void Main()
        {
            var list = Console.ReadLine().Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries).ToList();
            var input = Console.ReadLine();
            while (input != "course start")
            {
                var tokens = input.Split(':');
                var command = tokens[0];
                if (command == "Add")
                {
                    var lesson = tokens[1];
                    if(!list.Contains(lesson))
                        list.Add(lesson);
                }
                else if (command == "Insert")
                {
                    var lesson = tokens[1];
                    var index = int.Parse(tokens[2]);
                    if (!list.Contains(lesson))
                        list.Insert(index, lesson);
                }
                else if (command == "Exercise")
                {
                    var lesson = tokens[1];
                    if (!list.Contains(lesson))
                    {
                        list.Add(lesson);
                        list.Add($"{lesson}-Exercise");
                    }
                    else
                    {
                        if(list[list.Count-1] == lesson)
                            list.Add($"{lesson}-Exercise");

                        else
                        {
                            for (int i = 0; i < list.Count; i++)
                            {
                                if (list[i] == lesson)
                                {
                                    list.Insert(i + 1, $"{lesson}-Exercise");
                                    break;
                                }
                            }
                        }                       
                    }   
                }
                else if (command == "Remove")
                {
                    var lesson = tokens[1];
                    if (list.Contains(lesson))
                        list.Remove(lesson);

                    if(list.Contains($"{lesson}-Exercise"))
                        list.Remove($"{lesson}-Exercise");
                }
                else if (command == "Swap")
                {
                    var firstLesson = tokens[1];
                    var secondLesson = tokens[2];

                    if (list.Contains(firstLesson) && list.Contains(secondLesson))
                    {
                        var index1 = list.IndexOf(firstLesson);
                        var index2 = list.IndexOf(secondLesson);
                        list.Add(" ");
                        if (list[index1 + 1] == $"{firstLesson}-Exercise" && list[index2 + 1] == $"{secondLesson}-Exercise")
                        {
                            list[index1] = secondLesson;
                            list[index1 + 1] = $"{secondLesson}-Exercise";
                            list[index2] = firstLesson;
                            list[index2 + 1] = $"{firstLesson}-Exercise";
                        }
                        else if (list[index1 + 1] == $"{firstLesson}-Exercise")
                        {
                            list[index2] = firstLesson;
                            list.Insert(index2 + 1, $"{firstLesson}-Exercise");
                            list.RemoveAt(index1 + 1);
                            list[index1] = secondLesson;
                        }
                        else if (list[index2 + 1] == $"{secondLesson}-Exercise")
                        {
                            list.Remove(secondLesson);
                            list[index1] = secondLesson;
                            list.Remove($"{secondLesson}-Exercise");
                            list.Insert(index1 + 1, $"{secondLesson}-Exercise");
                            list[index2 + 1] = firstLesson;
                        }
                        else
                        {
                            list[index1] = secondLesson;
                            list[index2] = firstLesson;
                        }

                        list.Remove(" ");
                    }
                }

                input = Console.ReadLine();
            }

            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine($"{i + 1}.{list[i]}");
            }
        }
    }
}