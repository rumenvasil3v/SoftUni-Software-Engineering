namespace _02._Ascii_Sumator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char firstCharacter = char.Parse(Console.ReadLine());
            char secondCharacter = char.Parse(Console.ReadLine());

            int firstChAscii = firstCharacter;
            int secondChAscii = secondCharacter;
            int sumOfCharacters = 0;

            string text = Console.ReadLine();

            for (int t = 0; t < text.Length; t++)
            {
                int currentCh = text[t];

                if (currentCh > firstCharacter && currentCh < secondCharacter)
                {
                    sumOfCharacters += currentCh;
                }
            }

            Console.WriteLine(sumOfCharacters);
        }
    }
}