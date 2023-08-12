namespace _03._Take_OR_Skip_Rope
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string randomText = Console.ReadLine();

            string digit = string.Empty;

            List<int> numbers = new List<int>();
            List<char> nonNumbers = new List<char>();

            for (int n = 0; n < randomText.Length; n++)
            {
                if (char.IsDigit(randomText[n]))
                {
                    digit += randomText[n];
                    int currentDigit = int.Parse(digit);
                    digit = string.Empty;

                    numbers.Add(currentDigit);
                }
                else
                {
                    nonNumbers.Add(randomText[n]);
                }
            }

            List<int> takeList = new List<int>();
            List<int> skipList = new List<int>();

            for (int l = 0; l < numbers.Count; l++)
            {
                if (l % 2 == 0)
                {
                    takeList.Add(numbers[l]);
                }
                else
                {
                    skipList.Add(numbers[l]);
                }
            }

            string result = string.Empty;

            for (int t = 0; t < takeList.Count; t++)
            {
                List<char> takedCharacters = nonNumbers.Take(takeList[t]).ToList();
                foreach (var item in takedCharacters)
                {
                    result += item;
                }

                nonNumbers = nonNumbers.Skip(takeList[t]).ToList();

                nonNumbers = nonNumbers.Skip(skipList[t]).ToList();
            }

            Console.WriteLine(result);
        }
    }
}