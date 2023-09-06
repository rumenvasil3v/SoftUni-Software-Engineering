using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Problem_4___Match_Dates
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string input = Console.ReadLine();
            Regex regex = new Regex(@"(?<day>\d{2})([./-])(?<month>[A-Z][a-z]{2})\1(?<year>\d{4})");

            MatchCollection matches = regex.Matches(input);

            string[] dates = matches
                .Cast<Match>()
                .Select(x => $"Day: {x.Groups["day"].Value}, Month: {x.Groups["month"].Value}, Year: {x.Groups["year"].Value}")
                .ToArray();

            Console.WriteLine(string.Join(Environment.NewLine, dates));
        }
    }
}
