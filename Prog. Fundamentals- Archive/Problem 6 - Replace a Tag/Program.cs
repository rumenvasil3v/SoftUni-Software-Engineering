/*
 <ul><li><ahref="http://softuni.bg">SoftUni</a></li></ul>
<ul><li><h1>SoftUni</a></h1></ul>

 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Problem_6___Replace_a_Tag
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Regex regex = new Regex(@"<(?<openTag>[a-z]+)(?<url>[^>]*)>(?<text>[A-Za-z]+)<(?<closeTag>/\1)>");

            string finalResult = string.Empty;
            string input;
            while ((input = Console.ReadLine()) != "end")
            {
                Match match = regex.Match(input);

                finalResult += $"{input}\n";

                if (match.Success)
                {
                    finalResult = finalResult.Replace(match.Value, $"[URL {match.Groups["url"].Value}]{match.Groups["text"].Value}[/URL]");
                    continue;
                }

            }
            
            Console.WriteLine(finalResult);
        }
    }
}
