﻿using System;

namespace Login
{
    class DebugLogin
    {
        private static string ReverseString(string s)
        {
            char[] arr = s.ToCharArray();
            Array.Reverse(arr);
            return new string(arr);
        }
        static void Main()
        {
            string user = Console.ReadLine();
            string pass = Console.ReadLine();
            for (int i = 0; i <= 3; i++)
            {
                if (i == 3)
                {
                    if (user == ReverseString(pass))
                    {
                        Console.WriteLine("User {0} logged in.", user);
                        break;
                    }
                    else
                    {
                        Console.WriteLine("User {0} blocked!", user);
                    }
                }
                else if (pass == ReverseString(user))
                {
                    Console.WriteLine("User {0} logged in.", user);
                    break;
                }
                else
                {
                    Console.WriteLine("Incorrect password. Try again.");
                    pass = Console.ReadLine();
                }
            }
        }
    }
}