/*
care: worry, anxiety, or concern | care: a state of mind in which one is troubled | face: the front part of the head, from the forehead to the chin
care | kitchen | flower
Test

tackle: the equipment required for a task or sport | code: write code for a computer program | bit: a small piece, part, or quantity of something | tackle: make determined efforts to deal with a problem | bit: a short time or distance
bit | code | tackle
Test 

programmer: an animal, which turns coffee into code | developer: a magician
fish | domino
Hand Over
 */

namespace Problem_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Word> words = new Dictionary<string, Word>();

            string[] wordsWithDefinitions = Console
                .ReadLine().Split(" | ");

            //string[] wordsWithDef = wordsWithDefinitions.Split(" | ");

            for (int n = 0; n < wordsWithDefinitions.Length; n++)
            {
                string[] w = wordsWithDefinitions[n].Split(": ");
                //string[] definitions = w[1].Split(", ");

                Word word = new Word(w[0]);

                if (!words.ContainsKey(w[0]))
                {
                    word.Definitions.Add(w[1]);
                    words.Add(w[0], word);
                    continue;
                }

                words[w[0]].Definitions.Add(w[1]);
            }

            var a = 0;

            string[] randomWords = Console.ReadLine().Split(" | ");
            string command = Console.ReadLine();

            if (command == "Test")
            {
                foreach (var w in randomWords)
                {
                    if (words.ContainsKey(w))
                    {
                        Console.WriteLine($"{w}:");

                        foreach (var def in words[w].Definitions)
                        {
                            Console.WriteLine($" -{def}");
                        }
                    }
                }
            }
            else if (command == "Hand Over")
            {
                foreach (var word in words)
                {
                    Console.Write($"{word.Key} ");
                }

                Console.WriteLine();
            }
        }
    }

    public class Word
    {

        public Word(string name)
        {
            Name = name;
            Definitions = new List<string>();
        }

        public string Name { get; set; }

        public List<string> Definitions { get; set; }
    }
}