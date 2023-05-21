using System;
/*
 As a MOBA challenger player, Petar has the bad habit of trashing his PC when he loses a game and of rage quiting.
His gaming setup consists of a headset, mouse, keyboard, and display. You will receive Petar's lost games count.
Every second lost game, Petar trashes his headset.
Every third lost game, Petar trashes his mouse.

When Petar trashes both his mouse and headset in the same lost game, he also trashes his keyboard.
Every second time, when he trashes his keyboard, he also trashes his display.
You will receive the price of each item in his gaming setup. Calculate his rage expenses for renewing his gaming
equipment.

7
2
3
4
5

23
12.50
21.50
40
200
 */
namespace _10.RageExpense
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lostGamesCount = int.Parse(Console.ReadLine());
            double headsetPrice = double.Parse(Console.ReadLine());
            double mousePrice = double.Parse(Console.ReadLine());
            double keyboardPrice = double.Parse(Console.ReadLine());
            double displayPrice = double.Parse(Console.ReadLine());

            double rageExpenses = 0;
            int keyboardCount = 0;

            for (int i = 1; i <= lostGamesCount; i++)
            {
                if (i % 2 == 0 && i % 3 == 0)
                { 
                    keyboardCount++;
                    rageExpenses += mousePrice +  keyboardPrice + headsetPrice;
                    if (keyboardCount % 2 == 0)
                    {
                        rageExpenses += displayPrice;
                    }
                    continue;
                }

                if (i % 2 == 0)
                {
                    rageExpenses +=  headsetPrice;
                }
                else if (i % 3 == 0)
                {
                    rageExpenses +=  mousePrice;
                }
            }

            Console.WriteLine($"Rage expenses: {rageExpenses:F2} lv.");
        }
    }
}
