/*
8 2 2 8 2
1 5 1 3 
-2 0 0 2 
 */

namespace _01._Count_Real_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<double> numbers = Console
                .ReadLine()
                .Split(' ')
                .Select(double.Parse)
                .ToList();

            SortedDictionary<double, int> numberOccurrences = new SortedDictionary<double, int>();

            for (int n = 0; n < numbers.Count; n++)
            {
                if (!numberOccurrences.ContainsKey(numbers[n]))
                {
                    numberOccurrences[numbers[n]] = 0;
                }

                numberOccurrences[numbers[n]]++;
            }

            PrintOccurrences(numberOccurrences);
        }

        static void PrintOccurrences(SortedDictionary<double, int> numberOccurrences)
        {
            foreach (KeyValuePair<double, int> keyValuePair in numberOccurrences)
            {
                Console.WriteLine($"{keyValuePair.Key} -> {keyValuePair.Value}");
            }
        }
    }
}