using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Problem_1___1.Match_Full_Name
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            
            string pattern = @"\b(?<firstName>[A-Z][a-z]{1,}) (?<lastName>[A-Z][a-z]{1,})\b";

            Regex regex = new Regex(pattern);

            MatchCollection matches = regex.Matches(input);

            foreach (Match match in matches)
            {
                Console.Write($"{match.Groups["firstName"].Value} {match.Groups["lastName"].Value} ");
            }

            
        }
    }
}
