using System;
using System.Globalization;

namespace _01._Pipes_In_Pool
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1. We read from the console V (volume) for pool in Litres.
            int V = int.Parse(Console.ReadLine());
            //2. We read from the console flow rate of the first pipe for one hour.
            int P1 = int.Parse(Console.ReadLine());
            //3. We read from the console flow rate of the second pipe for one hour.
            int P2  = int.Parse(Console.ReadLine());
            //4. We read from the console the hours that the worker absent.
            double H = double.Parse(Console.ReadLine());
            //5. We calculate the first pipe for how many hoursWorkerAbsent.
            double firstPipe = P1 * H;
            //6. We calculate the second pipe for how many hoursWorkerAbsent.
            double secondPipe = P2 * H;
            //7. We calculate the total sum for the two pipes.
            double totalLitresPipe = firstPipe + secondPipe;

            //8. if the volume of the pool is > from totalLitresPipe, then print "The pool is {pool fill}% full. Pipe 1: {pipe one fill}%. Pipe 2: {pipe two fill}%."
            if (totalLitresPipe <= V)
            {
                Console.WriteLine($"The pool is {(totalLitresPipe / V) * 100:f2}% full. Pipe 1: {(firstPipe / totalLitresPipe) * 100:f2}%. Pipe 2: {(secondPipe / totalLitresPipe) * 100:f2}%.");
            }
            //9. if the pool is overcrowded, print "For {hoursWorkerAbsent} hours the pool overflows with {liters water more} liters."
            else
            {
                Console.WriteLine($"For {H:f2} hours the pool overflows with {totalLitresPipe - V:f2} liters.");
            }
        }
    }
}
