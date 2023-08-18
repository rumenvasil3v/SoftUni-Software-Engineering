namespace _03._Recursive_Fibonacci
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfFibonacci = int.Parse(Console.ReadLine());

            long[] fibonacciSequence = new long[numberOfFibonacci];
            fibonacciSequence[0] = 1;

            if (fibonacciSequence.Length > 1)
            {
                fibonacciSequence[1] = 1;
            }

            for (int n = 2; n < numberOfFibonacci; n++)
            {
                fibonacciSequence[n] = fibonacciSequence[n - 1] + fibonacciSequence[n - 2];
            }

            Console.WriteLine(fibonacciSequence[fibonacciSequence.Length - 1]);
        }
    }
}