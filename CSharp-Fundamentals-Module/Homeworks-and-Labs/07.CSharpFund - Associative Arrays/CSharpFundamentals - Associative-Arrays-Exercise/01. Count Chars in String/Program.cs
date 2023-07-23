namespace _01._Count_Chars_in_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            char[] characters = input.ToCharArray();

            Dictionary<char, int> charOccurrences = new Dictionary<char, int>();

            foreach (char character in characters)
            {

                if (character == ' ')
                {
                    continue;
                }

                if (!charOccurrences.ContainsKey(character))
                {
                    charOccurrences.Add(character, 0);
                }

                charOccurrences[character]++;
            }

            PrintResult(charOccurrences);
        }

        static void PrintResult(Dictionary<char, int> characters)
        {
            foreach (KeyValuePair<char, int> kvp in characters)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }
        }
    }
}