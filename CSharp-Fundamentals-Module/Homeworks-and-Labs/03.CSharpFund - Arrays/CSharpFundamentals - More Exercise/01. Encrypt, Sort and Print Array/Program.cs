using System;
using System.Linq;

namespace _01._Encrypt__Sort_and_Print_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());

            int sum = 0;
            int[] encryptedString = new int[length];

            for (int i = 0; i < length; i++)
            {
                string someText = Console.ReadLine();

                char[] chars = someText.ToCharArray();
                char[] arr = chars;

                for (int j = 0; j < arr.Length; j++)
                {
                    if (arr[j] == 'a' || arr[j] == 'e' || arr[j] == 'i'
                        || arr[j] == 'o' || arr[j] == 'u' || arr[j] == 65 || arr[j] == 69
                        || arr[j] == 79 || arr[j] == 85 || arr[j] == 73)
                    {
                        sum = sum + arr[j] * arr.Length;
                      
                    }
                    else
                    {
                        sum += arr[j] / arr.Length;
                    }
                }

                encryptedString[i] = sum;
                sum = 0;
            }

            Array.Sort(encryptedString);
            foreach (var item in encryptedString)
            {
                Console.WriteLine(item);
            }
        }
    }
}
