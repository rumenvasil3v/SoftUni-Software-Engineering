using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Problem_5___Match_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Regex regex = new Regex(@"(^|(?<=\s))[-]?\d+(\.\d+)?($|(?=\s))");

            MatchCollection matches = regex.Matches(input);

            var numbers = matches
                .Cast<Match>()
                .Select(x => x.Value)
                .ToArray();

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
