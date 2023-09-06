using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Problem_3___Match_Hexadecimal_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Regex regex = new Regex(@"\b(0x)?([A-F0-9]{1,})\b");

            MatchCollection matches = regex.Matches(input);

            string[] hexadecimalNumbers = matches
                .Cast<Match>()
                .Select(x => x.Value)
                .ToArray();

            Console.WriteLine(string.Join(" ", hexadecimalNumbers));
        }
    }
}
