using System.Globalization;
using System.Text;

namespace _05._Multiply_Big_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();
            string multiplier = Console.ReadLine();

            Console.WriteLine(MultiplyNumber(number, multiplier));
        }

        static string MultiplyNumber(string number, string multiplier)
        {
            StringBuilder sb = new StringBuilder();

            if (number == "0" || multiplier == "0")
            {
                return sb.Append(0).ToString();
            }

            int carry = 0;
            int multiplierNumber = int.Parse(multiplier);

            for (int n = number.Length - 1; n >= 0; n--)
            {
                int digit = int.Parse(number[n].ToString());
                int product = digit * multiplierNumber + carry;

                carry = product / 10;

                sb.Insert(0, product % 10);

                if (carry > 0)
                {
                    if (n == 0)
                    {
                        sb.Insert(0, carry);
                    }
                }
            }

            return sb.ToString();
        }
    }
}