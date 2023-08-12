/*

 */

using System.Text.RegularExpressions;

namespace _3._Post_Office
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string symbols = Console.ReadLine();
            string[] parts = symbols.Split('|');

            string firstPart = parts[0];

            string firstPartPattern = @"(\$|\#|\%|\*|\&)(?<capitalLetters>[A-Z]+)(\1)";

            Regex firstPartRegex = new Regex(firstPartPattern);

            Match firstPartMatchmatch = firstPartRegex.Match(firstPart);

            string startingLetterWords = string.Empty;
            if (firstPartMatchmatch.Success)
            {
                startingLetterWords = firstPartMatchmatch.Groups["capitalLetters"].Value;
            }

            string secondPartPattern = @"(?<asciiCode>\d+):(?<wordLength>\d{2})";

            Regex secondPartRegex = new Regex(secondPartPattern);

            string secondPart = parts[1];

            MatchCollection matches = secondPartRegex.Matches(secondPart);
            List<string> asciiCodes = new List<string>();

            for (int n = 0; n < startingLetterWords.Length; n++)
            {
                int asciiCode = startingLetterWords[n];

                foreach (Match match in matches)
                {
                    int currentAsciiCode = int.Parse(match.Groups["asciiCode"].Value);
                    int wordLength = int.Parse(match.Groups["wordLength"].Value);

                    if (asciiCode == currentAsciiCode && wordLength < 20 && wordLength > 0)
                    {
                        if (!asciiCodes.Contains($"{currentAsciiCode}:{wordLength}"))
                        {
                            asciiCodes.Add($"{currentAsciiCode}:{wordLength}");
                            break;
                        }
                    }
                }
            }

            string thirdPartPattern = @"\b(?<capitalLetter>[A-Z])(?<word>\S+)";

            Regex thirdPartRegex = new Regex(thirdPartPattern);

            string thirdPart = parts[2];

            MatchCollection thirdPartMatches = thirdPartRegex.Matches(thirdPart);
            List<string> words = new List<string>();

            for (int n = 0; n < asciiCodes.Count; n++)
            {
                int currentAsciiCode = int.Parse(asciiCodes[n].Split(':')[0]);

                char currentChar = (char)currentAsciiCode;
                int length = int.Parse(asciiCodes[n].Split(':')[1]);

                foreach (Match match in thirdPartMatches)
                {
                    char currentMatchChar = char.Parse(match.Groups["capitalLetter"].Value);
                    string currentMatchString = match.Groups["word"].Value;

                    if (currentMatchChar == currentChar)
                    {
                        if (length == currentMatchString.Length)
                        {
                            string word = currentMatchChar + currentMatchString;
                            words.Add(word);
                        }
                    }
                }
            }

            Console.WriteLine(string.Join(Environment.NewLine, words));
        }
    }
}