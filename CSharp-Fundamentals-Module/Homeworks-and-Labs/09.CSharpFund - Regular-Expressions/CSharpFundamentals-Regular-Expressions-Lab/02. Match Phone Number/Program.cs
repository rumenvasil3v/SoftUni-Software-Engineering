/*
+359 2 222 2222,359-2-222-2222, +359/2/222/2222, +359-2 222 2222 +359 2-222-2222, +359-2-222-222, +359-2-222-22222 +359-2-222-2222

*/

using System.Text.RegularExpressions;

namespace _02._Match_Phone_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string phones = Console.ReadLine();

            string pattern = @"\+359( |-)2\1\d{3}\1\d{4}\b";

            Regex regex = new Regex(pattern);
            MatchCollection phoneMatches = regex.Matches(phones);

            var matchedPhones = phoneMatches
                .Cast<Match>()
                .Select(p => p.Value.Trim())
                .ToArray();

            Console.WriteLine(string.Join(", ", matchedPhones));
        }
    }
}