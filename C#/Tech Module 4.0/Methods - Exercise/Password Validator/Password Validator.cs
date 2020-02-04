using System;

namespace Password_Validator
{
    class Program
    {
        static void Main()
        {
            var input = Console.ReadLine();
           Length(input);
        }
        private static void Length(string input)
        {
            if (input.Length < 6 || input.Length > 10)
            {
                var digit = 0;
                var digitLetter = true;
                for (int i = 0; i < input.Length; i++)
                {
                    if ((input[i] >= 65 && input[i] <= 90) || (input[i] >= 97 && input[i] <= 122))
                    {
                        continue;
                    }
                    else if ((input[i] >= 48 && input[i] <= 57))
                    {
                        digit++;
                    }
                    else
                    {
                        digitLetter = false;
                    }
                }
                Console.WriteLine("Password must be between 6 and 10 characters");
                if(digitLetter == false)
                    Console.WriteLine("Password must consist only of letters and digits");
                if (digit < 2)
                    Console.WriteLine("Password must have at least 2 digits");


            }
            else
            {
                var digitLetter = true;
                var digit = 0;
                for (int i = 0; i < input.Length; i++)
                {
                    if ((input[i] >= 65 && input[i] <= 90) || (input[i] >= 97 && input[i] <= 122))
                    {
                        continue;
                    }
                    else if ((input[i] >= 48 && input[i] <= 57))
                    {
                        digit++;
                    }
                    else
                    {
                        digitLetter = false;
                        break;
                    }
                }

                if (digitLetter == true && digit > 1)
                    Console.WriteLine("Password is valid");
                if(digitLetter == false)
                    Console.WriteLine("Password must consist only of letters and digits");

                if (digit < 2)
                    Console.WriteLine("Password must have at least 2 digits");

            }
        } 
    }
}