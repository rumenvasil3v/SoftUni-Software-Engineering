using System;

namespace _06._RepaintingExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int nylon = int.Parse(Console.ReadLine());
            double paintLitres = double.Parse(Console.ReadLine());
            int diluent = int.Parse(Console.ReadLine());
            int workingTime = int.Parse(Console.ReadLine());

            double nylonPrice = (nylon + 2) * 1.50 ;
            double paintLitresPrice = (paintLitres + paintLitres * 0.1) * 14.50;
            double diluentPrice = diluent * 5.00;
            double bladder = 0.40;
            double materialsSum = nylonPrice + paintLitresPrice + diluentPrice + bladder;
            double workingPrice = (materialsSum * 0.3) * workingTime;
            double totalSum = materialsSum + workingPrice;
            Console.WriteLine(totalSum);
        }
    }
}
