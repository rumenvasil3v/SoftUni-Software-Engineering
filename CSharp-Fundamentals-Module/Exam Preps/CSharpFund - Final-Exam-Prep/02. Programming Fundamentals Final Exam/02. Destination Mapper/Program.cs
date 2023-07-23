using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _02._Destination_Mapper
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string places = Console.ReadLine();

            string pattern = @"(\=|\/)(?<destination>[A-Z][a-zA-Z]{2,})(\1)";

            Regex regex = new Regex(pattern);
            MatchCollection matches = regex.Matches(places);

            List<string> destinations = new List<string>();
            int travelPoints = 0;

            foreach (Match match in matches)
            {
                destinations.Add(match.Groups["destination"].Value);
                travelPoints += match.Groups["destination"].Value.Length;
            }

            Console.Write("Destinations: ");
            Console.WriteLine(string.Join(", ", destinations));

            Console.WriteLine($"Travel Points: {travelPoints}");
        }
    }
}
