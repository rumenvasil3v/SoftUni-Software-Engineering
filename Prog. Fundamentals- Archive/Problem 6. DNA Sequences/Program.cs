using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_6.DNA_Sequences
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sumOfNucleotids = int.Parse(Console.ReadLine());

            int col = 0;
            int a = 0;
            int b = 0;
            int c = 0;

            for (char l1 = 'A'; l1 <= 'T'; l1++)
            {

                if (l1 != 'A' && l1 != 'C' && l1 != 'G' && l1 != 'T')
                {
                    continue;
                }

                a++;
                

                for (char l2 = 'A'; l2 <= 'T'; l2++)
                {

                    if (l2 != 'A' && l2 != 'C' && l2 != 'G' && l2 != 'T')
                    {
                        continue;
                    }

                    b++;
                    

                    for (char l3 = 'A'; l3 <= 'T'; l3++)
                    {
                        
                        if (l3 != 'A' && l3 != 'C' && l3 != 'G' && l3 != 'T')
                        {
                            continue;
                        }

                        c++;
                        if (a + b + c >= sumOfNucleotids)
                        {
                            Console.Write($"O{(char)l1}{(char)l2}{(char)l3}O ");
                        }
                        else
                        {
                            Console.Write($"X{(char)l1}{(char)l2}{(char)l3}X ");
                        }

                        col++;

                        if (col == 4)
                        {
                            Console.WriteLine();
                            col = 0;
                            c = 0;
                            break;
                        }         
                    }
                }

                b = 0;
            }
        }
    }
}