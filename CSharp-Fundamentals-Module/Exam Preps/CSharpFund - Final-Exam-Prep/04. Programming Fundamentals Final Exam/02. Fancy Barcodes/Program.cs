using System;
using System.Text.RegularExpressions;

namespace Problem_2_Fancy_Barcodes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string pattern = "(\\@#+)(([A-Z][A-Za-z0-9]{4,})[A-Z])\\@\\#{1,}";
            string pattern = "@#+(?<item>[A-Z][A-Za-z0-9]{4,}[A-Z])@#+";
            Regex regex1 = new Regex(pattern);
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                Match match = regex1.Match(input);
                if (!match.Success)
                {
                    Console.WriteLine("Invalid barcode");
                    continue;

                }
                string secondPatern = "\\d";
                Regex regex = new Regex(secondPatern);
                MatchCollection digits = regex.Matches(match.ToString());
                string productGroup = string.Empty;
                if (digits.Count > 0)
                {

                    foreach (Match m in digits)
                    {
                        productGroup += m.Value;

                    }
                }
                else
                {
                    productGroup += "00";

                }


                Console.WriteLine($"Product group: {productGroup}");
            }

        }
    }
}