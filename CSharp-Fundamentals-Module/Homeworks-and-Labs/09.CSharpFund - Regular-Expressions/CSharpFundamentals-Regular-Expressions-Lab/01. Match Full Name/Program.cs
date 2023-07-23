/*
Bethany Taylor, Oliver miller, sophia Johnson, SARah Wilson,John Smith, Sam        Smith
Elvis Presley a a C C-Muhammad Ali EE PeterpeterJR-a a xi ban D D bb b b-B B-c c EE-Michael Jackson DD peter smith B B PETER BROWN IVAN DAVIES
Ea Ku a a C C-Muhammad Ali EE PeterpeterJR-a a xi ban D D bb b b-B B-c c EE-Michael Jackson DD peter smith B B Pe Jo
Ea Ku a a C C-Muhammad Ali EE PeterpeterJR-a a xi ban D D bb b b-B B-c c EE-Michael Jackson DD peter smith B B Pe Jo Ja Ma
 */

using System.Text.RegularExpressions;

namespace _01._Match_Full_Name
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string names = Console.ReadLine();

            string pattern = @"\b(?<firstName>[A-Z][a-z]{1,}) (?<secondName>[A-Z][a-z]{1,})\b";

            Regex regex = new Regex(pattern);
            MatchCollection matches = regex.Matches(names);

            foreach (Match name in matches)
            {
                Console.Write($"{name.Groups["firstName"].Value} {name.Groups["secondName"].Value} ");
            }

            Console.WriteLine();
        }
    }
}