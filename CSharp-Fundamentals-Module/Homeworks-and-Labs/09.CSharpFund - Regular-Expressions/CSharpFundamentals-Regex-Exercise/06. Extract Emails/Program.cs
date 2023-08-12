/*
Just send email to s.miller@mit.edu and j.hopking@york.ac.uk for more information.
Many users @ SoftUni confuse email addresses. We @ Softuni.BG provide high-quality training @ home or @ class. –- steve.parker@softuni.de.
 */

using System.Text.RegularExpressions;

namespace _06._Extract_Emails
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            string emailPattern = @"[^-_.]\b([a-zA-Z0-9]+)([.\-_]*?)([a-zA-Z0-9]+?)@([a-zA-Z0-9](?:[a-zA-Z0-9-]*[a-zA-Z0-9])?\.)+([a-zA-Z0-9](?:[a-zA-Z0-9]*[a-zA-Z0-9])?)";

            Regex regex = new Regex(emailPattern, RegexOptions.Multiline);

            MatchCollection matches = regex.Matches(text);

            foreach (Match match in matches)
            {
                Console.WriteLine(match.Value.Trim());
            }
        }
    }
}