using System;

namespace Rage_Expenses
{
    class Program
    {
        static void Main()
        {
            var lostGames = double.Parse(Console.ReadLine());
            var headsetPrice = double.Parse(Console.ReadLine());
            var mousePrice = double.Parse(Console.ReadLine());
            var keyboardPrice = double.Parse(Console.ReadLine());
            var displayPrice = double.Parse(Console.ReadLine());
            int headsetTrash = 0;
            int mouseTrash = 0;
            int keyboardTrash = 0;
            int displayTrash = 0;

            double expenses = 0;
            for (int i = 1; i <= lostGames; i++)
            {
                if ((i % 2 == 0 && i % 3 == 0))
                {
                    headsetTrash++;
                    mouseTrash++;
                    keyboardTrash++;
                    if (keyboardTrash % 2 == 0) displayTrash++;
                }
                else if (i % 2 == 0) headsetTrash++;
                else if (i % 3 == 0) mouseTrash++;
            }

            expenses = (headsetPrice * headsetTrash) + (mouseTrash * mousePrice)
                       + (keyboardPrice * keyboardTrash) + (displayPrice * displayTrash);

            Console.WriteLine($"Rage expenses: {expenses:f2} lv.");

        }
    }
}