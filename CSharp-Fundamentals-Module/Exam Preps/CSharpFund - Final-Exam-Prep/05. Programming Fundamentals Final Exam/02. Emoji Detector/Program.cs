using System;
using System.Numerics;
using System.Text.RegularExpressions;

namespace _02._Emoji_Detector
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            Regex emojiRegex = new Regex(@"(\:\:|\*\*)(?<emoji>[A-Z][a-z]{2,})(\1)");
            MatchCollection emojiMatches = emojiRegex.Matches(text);

            Regex coolThresholdRegex = new Regex(@"[0-9]");
            MatchCollection coolThresholdMatches = coolThresholdRegex.Matches(text);

            BigInteger coolThreshold = 1;
            foreach (Match match in coolThresholdMatches)
            {
                coolThreshold *= int.Parse(match.Value);
            }

            Console.WriteLine($"Cool threshold: {coolThreshold}");
            Console.WriteLine($"{emojiMatches.Count} emojis found in the text. The cool ones are:");

            foreach (Match match in emojiMatches)
            {
                int emojiCoolThreshold = 0;
                foreach (char emoji in match.Groups["emoji"].Value)
                {
                    emojiCoolThreshold += emoji;
                }

                if (emojiCoolThreshold > coolThreshold)
                {
                    Console.WriteLine(match.Value);
                }
            }
        }
    }
}
