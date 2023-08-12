/*
.. | -- .- -.. . | -.-- --- ..- | .-- .-. .. - . | .- | .-.. --- -. --. | -.-. --- -.. .
.. | .... --- .--. . | -.-- --- ..- | .- .-. . | -. --- - | -- .- -..
.. | .-.. --- ...- . | - --- | ... --- .-.. ...- . | .--. .-. --- -... .-.. . -- ...
 */

using System.Collections.Generic;
using System.Diagnostics.Metrics;

namespace _04._Morse_Code_Translator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[] separators = new char[]{ '|', ' ' };

            string morseText = Console
                .ReadLine();

            string[] morseLetter = morseText.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            string[] morseCode = morseText.Split(" | ");

            Dictionary<char, string> morse = new Dictionary<char, string>()
            {
                {'A' , ".-"},
                {'B' , "-..."},
                {'C' , "-.-."},
                {'D' , "-.."},
                {'E' , "."},
                {'F' , "..-."},
                {'G' , "--."},
                {'H' , "...."},
                {'I' , ".."},
                {'J' , ".---"},
                {'K' , "-.-"},
                {'L' , ".-.."},
                {'M' , "--"},
                {'N' , "-."},
                {'O' , "---"},
                {'P' , ".--."},
                {'Q' , "--.-"},
                {'R' , ".-."},
                {'S' , "..."},
                {'T' , "-"},
                {'U' , "..-"},
                {'V' , "...-"},
                {'W' , ".--"},
                {'X' , "-..-"},
                {'Y' , "-.--"},
                {'Z' , "--.."}
            };

            string decodedMorse = string.Empty;

            int index = 0;

            for (int m = 0; m < morseCode.Length; m++)
            {
                string[] letters = morseCode[m].Split(' ', StringSplitOptions.RemoveEmptyEntries);

                for (int l = 0; l < letters.Length; l++)
                {
                    foreach (var kvp in morse)
                    {
                        if (kvp.Value.Equals(morseLetter[index]))
                        {
                            decodedMorse += kvp.Key;
                            break;
                        }
                    }

                    index++;
                }

                decodedMorse += " ";
            }

            Console.WriteLine(decodedMorse);
        }
    }
}