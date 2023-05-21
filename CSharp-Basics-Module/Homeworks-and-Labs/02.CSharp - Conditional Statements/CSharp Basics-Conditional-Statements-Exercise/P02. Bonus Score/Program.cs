using System;

namespace P02._Bonus_Score
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1.Четем числото от конзолата.
            int points = int.Parse(Console.ReadLine());
            //2.Създаваме променлива за бонус точките.
            double bonus = 0.0;
            //3.проверяваме в кой диапазон се намира числото
            // num <= 100 / т.
            // num е между 100 и 1000 => 20 % от числото
            // num > 1000 => 10 % от числото
            if (points <= 100)
            {
                bonus = 5;
            }
            else if (points > 1000)
            {
                bonus = points * 0.1;
            }
            else
            {
                bonus = points * 0.2;
            }
            //4. Проверяваме дали числото ще получи допълнителен бонус
            // => num е четно => 1 точка
            // => num завършва на 5 => 2 точка.
            if (points % 2 == 0 )
            {
                bonus = bonus + 1;
            }
            else if (points % 10 == 5)
            {
                bonus = bonus + 2;
            }

            Console.WriteLine(bonus);
            Console.WriteLine(points + bonus);
        }
    }
}
