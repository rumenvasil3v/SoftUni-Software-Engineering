namespace _04._Fold_and_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console
                .ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int firstRow = numbers.Length / 4;
            int[] upperNumbers = new int[firstRow + firstRow];
            int[] lowerNumbers = new int[firstRow + firstRow];
            int[] result = new int[firstRow + firstRow];
            int upperIndex = 0;
            int lowerIndex = 0;

            for (int n = firstRow - 1; n >= 0; n--)
            {
                upperNumbers[upperIndex] = numbers[n];
                upperIndex++;
            }

            for (int i = numbers.Length - 1; i >= numbers.Length - firstRow; i--)
            {
                upperNumbers[upperIndex] = numbers[i];
                upperIndex++;
            }

            for (int m = firstRow; m <= numbers.Length - firstRow - 1; m++)
            {
                lowerNumbers[lowerIndex] = numbers[m];
                lowerIndex++;
            }
            
            for (int r = 0; r < upperNumbers.Length; r++)
            {
                result[r] = upperNumbers[r] + lowerNumbers[r];
            }

            Console.WriteLine(string.Join(" ", result));
        }
    }
}