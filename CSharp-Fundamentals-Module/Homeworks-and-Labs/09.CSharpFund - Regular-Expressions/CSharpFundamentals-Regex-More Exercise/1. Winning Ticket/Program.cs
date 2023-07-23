/*
$$$$$$$$$$$$$$$####$, $$$$$$$$$$$$########, aabb , th$$$$$$$$o$$$$$aaae, $$$$$$$$$$a$$$$$$$$$
validticketnomatch:( 
Cash$$$$$$Ca$$$$$$sh 
$$$$$$$$$$$$$$$$$$$$, aabb , th@@@@@@eemo@@@@@@ey
aaaa$$$$$aaaa^$$$$$$
^$$$$$$$$$$$$$$$$$$^
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Channels;

namespace _1._Winning_Ticket
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[] separators = new char[] { ',', ' ' };
            string[] text = Console
                .ReadLine()
                .Split(separators, StringSplitOptions.RemoveEmptyEntries);

            var regex = new Regex(@"\@{6,}|\${6,}|\#{6,}|\^{6,}");

            foreach (var str in text)
            {

                if (str.Length != 20)
                {
                    Console.WriteLine("invalid ticket");
                    continue;
                }

                string firstWord = string.Empty;
                string secondWord = string.Empty;

                MatchCollection matches = regex.Matches(str);

                if (matches.Count == 2)
                {
                    firstWord = matches[0].Value;
                    secondWord = matches[1].Value;
                }
                else if (matches.Count == 1)
                {
                    if (matches[0].Value.Length == 20)
                    {
                        firstWord = matches[0].Value.Substring(0, 10);
                        secondWord = matches[0].Value.Substring(10, 10);
                    }
                    else
                    {
                        firstWord = matches[0].Value;
                        secondWord = matches[0].Value;
                    }
                }
                else
                {
                    Console.WriteLine($"ticket \"{str}\" - no match");
                    continue;
                }

                if (firstWord[0] == secondWord[0])
                {
                    var winningCount = Math.Min(firstWord.Length, secondWord.Length);
                    char matchSymbol = firstWord[0];
                    if (winningCount == 10)
                    {
                        Console.WriteLine($"ticket \"{str}\" - {winningCount}{matchSymbol} Jackpot!");
                    }
                    else if (winningCount >= 6 && winningCount <= 9)
                    {
                        Console.WriteLine($"ticket \"{str}\" - {winningCount}{matchSymbol}");
                    }
                    else
                    {
                        Console.WriteLine($"ticket \"{str}\" - no match");
                    }
                }
                else
                {
                    Console.WriteLine($"ticket \"{str}\" - no match");
                }
            }
        }
    }
}