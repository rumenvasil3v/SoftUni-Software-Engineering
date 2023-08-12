/*
13/Jul/1928, 10-Nov-1934, , 01/Jan-1951,f 25.Dec.1937 23/09/1973, 1/Feb/2016
03-Mar-1878, 25/Apr/1915, 31-May-1916, 22/Jun-1941, 25.Dec.1937, 23/09/1973

 */

using System.Text.RegularExpressions;

namespace _03._Match_Dates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"\b(?<day>\d{2})(\.|-|\/)(?<month>[A-Z][a-z]{2})\1(?<year>\d{4})\b";

            string dates = Console.ReadLine();

            Regex regex = new Regex(pattern);
            MatchCollection matches = regex.Matches(dates);

            var matched = matches
                .Cast<Match>()
                .Select(x => $"Day: {x.Groups["day"].Value}, Month: {x.Groups["month"].Value}, Year: {x.Groups["year"].Value}")
                .ToArray();

            Console.WriteLine(string.Join(Environment.NewLine, matched));
        }
    }
}