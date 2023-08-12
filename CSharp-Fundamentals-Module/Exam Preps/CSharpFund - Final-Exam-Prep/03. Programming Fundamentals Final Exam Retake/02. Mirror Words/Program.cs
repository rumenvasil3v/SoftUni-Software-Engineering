/*
@mix#tix3dj#poOl##loOp#wl@@bong&song%4very$long@thong#Part##traP##@@leveL@@Level@##car#rac##tu@pack@@ckap@#rr#sAw##wAs#r#@w1r
#po0l##l0op# @bAc##cAB@ @LM@ML@ #xxxXxx##xxxXxx# @aba@@ababa@

 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Problem_2___Mirror_Words
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            string pattern = @"(\@|\#)(?<firstWord>[a-zA-Z]{3,})\1\1(?<secondWord>[A-Za-z]{3,})\1";

            List<string> mirrorWords = new List<string>();
            Regex regex = new Regex(pattern);
            MatchCollection matches = regex.Matches(text);

            if (matches.Count > 0)
            {
                Console.WriteLine($"{matches.Count} word pairs found!");

                foreach (Match match in matches)
                {
                    string firstWord = match.Groups["firstWord"].Value;
                    string secondWord = match.Groups["secondWord"].Value;

                    char[] ch = secondWord.ToCharArray();
                    Array.Reverse(ch);

                    string reversedSecondWord = new string(ch);

                    if (firstWord.Equals(reversedSecondWord))
                    {
                        mirrorWords.Add($"{firstWord}:{secondWord}");
                    }
                }

                if (mirrorWords.Count > 0)
                {
                    Console.WriteLine("The mirror words are:");
                    Console.WriteLine(string.Join(", ", mirrorWords.Select(x => $"{x.Split(":")[0]} <=> {x.Split(":")[1]}")));
                }
                else
                {
                    Console.WriteLine("No mirror words!");
                }
            }
            else
            {
                Console.WriteLine("No word pairs found!");
                Console.WriteLine("No mirror words!");
            }
        }
    }
}
