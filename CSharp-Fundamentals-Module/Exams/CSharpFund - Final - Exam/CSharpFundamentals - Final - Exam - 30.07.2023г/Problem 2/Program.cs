using System.Text.RegularExpressions;

namespace Problem_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            Regex regex = new Regex(@"(\@{1,}|\#{1,}|\@{1,}\#{1,})\b(?<color>[a-z]{3,})(\@{1,}|\#{1,}|\@{1,}\#{1,})([^a-zA-Z0-9]*)(\/{1,})(?<amount>[0-9]+)(\/{1,})");

            string colorOfTheEgg = string.Empty;
            int amountOffEggs = 0;

            MatchCollection matches = regex.Matches(text);

            foreach (Match match in matches)
            {
                colorOfTheEgg = match.Groups["color"].Value;
                amountOffEggs = int.Parse(match.Groups["amount"].Value);

                Console.WriteLine($"You found {amountOffEggs} {colorOfTheEgg} eggs!");
            }
        }
    }
}