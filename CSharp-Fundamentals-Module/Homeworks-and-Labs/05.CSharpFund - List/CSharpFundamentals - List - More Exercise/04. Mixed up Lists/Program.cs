namespace _04._Mixed_up_Lists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> firstSequenceOfNumbers = Console
                .ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            List<int> secondSequenceOfNumbers = Console
                .ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            List<int> constraints = new List<int>();

            List<int> mixedList = new List<int>();

            if (firstSequenceOfNumbers.Count > secondSequenceOfNumbers.Count)
            {
                for (int f = 0; f < firstSequenceOfNumbers.Count - (firstSequenceOfNumbers.Count - secondSequenceOfNumbers.Count); f++)
                {
                    mixedList.Add(firstSequenceOfNumbers[f]);

                    for (int s = secondSequenceOfNumbers.Count - 1 - f; s >= 0; s--)
                    {
                        mixedList.Add(secondSequenceOfNumbers[s]);
                        break;

                    }
                }

                for (int c = firstSequenceOfNumbers.Count - (firstSequenceOfNumbers.Count - secondSequenceOfNumbers.Count); c < firstSequenceOfNumbers.Count; c++)
                {
                    constraints.Add(firstSequenceOfNumbers[c]);
                }
            }
            else if (secondSequenceOfNumbers.Count > firstSequenceOfNumbers.Count)
            {
                int count = 0;

                for (int f = secondSequenceOfNumbers.Count - 1; f >= secondSequenceOfNumbers.Count - firstSequenceOfNumbers.Count; f--)
                {
                    mixedList.Add(secondSequenceOfNumbers[f]);

                    for (int s = 0 + count; s < firstSequenceOfNumbers.Count; s++)
                    {
                        mixedList.Add(firstSequenceOfNumbers[s]);
                        break;
                    }

                    count++;
                }

                for (int c = 0; c < secondSequenceOfNumbers.Count - firstSequenceOfNumbers.Count; c++)
                {
                    constraints.Add(secondSequenceOfNumbers[c]);
                }
            }

            var sorted = constraints.OrderBy(x => x).ToList();
            List<int> finalResult = new List<int>();

            for (int r = 0; r < mixedList.Count; r++)
            {
                if (mixedList[r] > sorted[0] && mixedList[r] < sorted[1])
                {
                    finalResult.Add(mixedList[r]);
                }
            }

            Console.WriteLine(string.Join(" ", finalResult.OrderBy(x => x)));
        }
    }
}