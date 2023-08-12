/*
 Welcome to SoftUni and have fun learning programming

 */
using System;

namespace _1._Randomize_Words
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console
                .ReadLine(); // reading text from the console

            string[] words = text.Split(); // split the text into elements

            Random random = new Random(); // create an instance (object) of type Random
            SwapElements(words, random);

            PrintFinalResult(words);
        }

        static void SwapElements(string[] words, Random random)
        {
            for (int i = 0; i < words.Length; i++) //for loop until the words.Length
            {
                string currentWord = words[i]; // list element from current index[i] to currentWord
                int randomIndex = random.Next(0, words.Length); // make variable from type int to generate random Index

                words[i] = words[randomIndex]; // swap current index[i] with random generated index
                words[randomIndex] = currentWord; // replace random index element with current word from index[i]
            }
        }

        static void PrintFinalResult(string[] words)
        {
            for (int i = 0; i < words.Length; i++)
            {
                Console.WriteLine(words[i]); // print all shuffled words from the array on new line
            }
        }
    }
}