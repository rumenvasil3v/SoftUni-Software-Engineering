using System.Text;

namespace _05._Digits__Letters_and_Other
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string digits = string.Empty;
            string letters = string.Empty;
            string asciiSymbols = string.Empty;

            string text = Console.ReadLine();

            foreach (char character in text)
            {
                if (char.IsDigit(character))
                {
                    digits += character;
                }
                else if (char.IsLetter(character))
                {
                    letters += character;
                }
                else
                {
                    asciiSymbols += character;
                }
            }

            Console.WriteLine(digits);
            Console.WriteLine(letters);
            Console.WriteLine(asciiSymbols);
        }
    }
}