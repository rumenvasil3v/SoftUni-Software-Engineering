using System;

namespace _06._Repainting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1.We read from the console:
            //- количество найлон(в кв.м.) -int (добавяме 2 кв. метра)
            int nylonQuantity = int.Parse(Console.ReadLine()) + 2;
            //- количество боя(в литри) -double (добавяме 10% за всеки случай)
            double paintLiters  = double.Parse(Console.ReadLine()); // =20
            paintLiters = paintLiters + paintLiters * 0.1;
            //paintLiters = 20 + 20*0.1 = 20+2 = 22

            //- разредител(в литри) - int
            int thinnerLiters = int.Parse(Console.ReadLine());  
            //Часовете за работата -int
            int workingTime = int.Parse(Console.ReadLine());

            //2. Изчисляваме цена за всеки от материалите
            //  - найлон - 1.50 
            double nylonPrice = nylonQuantity * 1.5;
            //  - Боя - 14.50
            double paintPrice = paintLiters* 14.50;

            // - Разредител - 5.00
            double thinnerPrice = thinnerLiters * 5.00;

            //3. Намираме общата сума за материали
            // (найлон + боя + разредител + 0.4 торбичка)
            double materials = nylonPrice + paintPrice + thinnerPrice + 0.4;

            //4. Намираме цена за час работа
            // (30 % от сбора на всички разходи за материали)
            double workingPrice = materials * 0.3;

            //5. Намираме колко ще излезе
            // (общата сума за материали + часове работа * цена за час работа)
            double totalSum = materials + workingTime * workingPrice;

            //6. Извеждаме резултата на конзолата 
            Console.WriteLine(totalSum);
        }    
    }
}
