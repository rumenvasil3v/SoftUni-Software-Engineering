namespace _02._Odd_Occurrences
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string words = Console
                .ReadLine()
                .ToLower();

            string[] w = words
                .Split(' ');

            Dictionary<string, int> oddOccurrences = new Dictionary<string, int>();

            foreach (string word in w)
            {
                if (!oddOccurrences.ContainsKey(word))
                {
                    oddOccurrences[word] = 0;
                }

                oddOccurrences[word]++;
            }

            PrintOddOccurrences(oddOccurrences);
        }

        static void PrintOddOccurrences(Dictionary<string, int> oddOccurrences)
        {
            foreach (KeyValuePair<string, int> word in oddOccurrences)
            {
                if (word.Value % 2 == 1)
                {
                    Console.Write($"{word.Key} ");
                }
            }
        }
    }
}