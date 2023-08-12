/*
>2>1asd>2>4sd
1a>2<>2
1a>2<>2>
 */

using System.Text;

namespace _07._String_Explosion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console
                .ReadLine();

            StringBuilder sb = new StringBuilder();
            sb.Append(text);

            int strength = 0;
            int rangeExplosion = 0;

            for (int t = 0; t < text.Length; t++)
            {
                if (t - 1 < 0)
                {
                    continue;
                }

                if (text[t - 1] == '>')
                {
                    strength += int.Parse(text[t].ToString());
                    int bombRange = strength;

                    for (int s = t; s < t + bombRange; s++)
                    {
                        if (s > text.Length - 1 || sb.Length < s - rangeExplosion)
                        {
                            break;
                        }

                        if (text[s] == '>')
                        {
                            break;
                        }

                        sb.Remove(s - rangeExplosion, 1);

                        strength--;
                        rangeExplosion++;
                    }
                }
            }

            Console.WriteLine(sb);
        }
    }
}