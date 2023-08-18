namespace _01._Messaging
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console
                .ReadLine()
                .Split()
                .Select(x => int.Parse(x))
                .ToList();

            string randomText = Console.ReadLine();

            string message = string.Empty;

            for (int n = 0; n < numbers.Count; n++)
            {
                int sum = 0;
                int currentNumber = numbers[n];

                while (currentNumber > 0)
                {
                    sum += currentNumber % 10;

                    currentNumber /= 10;
                }

                char currentCharacter = randomText[sum % randomText.Length];

                randomText = randomText.Remove(sum % randomText.Length, 1);

                message += currentCharacter;
            }

            Console.WriteLine(message);
        }
    }
}