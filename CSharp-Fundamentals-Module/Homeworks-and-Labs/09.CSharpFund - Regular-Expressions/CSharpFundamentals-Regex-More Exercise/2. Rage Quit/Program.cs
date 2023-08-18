using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;

namespace _2._Rage_Quit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            string pattern = @"(?<characters>[^0-9]+)(?<number>[0-9]+)?";

            Regex regex = new Regex(pattern);

            MatchCollection matches = regex.Matches(text);

            string uniqueCharacters = string.Empty;
            StringBuilder resultSb = new StringBuilder();
            string character = string.Empty;

            foreach (Match match in matches)
            {
                string str = match.Groups["characters"].Value;
                int number = int.Parse(match.Groups["number"].Value);

                if (number == 0)
                {
                    continue;
                }

                for (int s = 0; s < str.Length; s++)
                {
                    character = str[s].ToString().ToUpper();

                    if (!uniqueCharacters.Contains(character))
                    {
                        uniqueCharacters += character;
                    }
                }

                for (int n = 0; n < number; n++)
                {
                     resultSb.Append(str.ToUpper());          
                }
            }

            Console.WriteLine($"Unique symbols used: {uniqueCharacters.Length}");
            Console.WriteLine(resultSb);
        }
    }
}