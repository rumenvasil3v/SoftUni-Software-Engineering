using System;

namespace _06._Sum_And_Product
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            bool isValid = false;

            double sum = 0;
            double product = 0;
            double anotherCombination = 0;
            string num = string.Empty;
  
            for (int a = 1; a < 9; a++)
            {
                for (int b = 9; b > a; b--)
                {
                    for (int c = 0; c < 9; c++)
                    {
                        for (int d = 9; d > c; d--)
                        {
                            sum = a + b + c + d;
                            product = a * b * c * d;
                            if (sum == product && n % 10 == 5)
                            {
                                isValid = true;
                                num = $"{a}{b}{c}{d}";
                                break;
                            }
                            else
                            {
                                
                                anotherCombination = Math.Floor(product / sum);
                                if (anotherCombination == 3 && n % 3 == 0)
                                {
                                    isValid = true;
                                    num = $"{d}{c}{b}{a}";
                                    break;
                                } 
                            }
                        }
                        if (isValid == true)
                        {
                            break;
                        }
                    }
                    if (isValid == true)
                    {
                        break;
                    }
                }
                if (isValid == true)
                {
                    break;
                }
            }
            if (isValid)
            {
                Console.WriteLine($"{num}");
            }
            else
            {
                Console.WriteLine("Nothing found");
            }
            
        }
    }
}