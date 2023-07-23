namespace _03._Word_Synonyms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> words = new Dictionary<string, List<string>>();

            //List<string> synonyms = new List<string>();

            int countOfWords = int.Parse(Console.ReadLine());

            for (int w = 0; w < countOfWords; w++)
            {
                string word = Console
                    .ReadLine();

                string synonym = Console
                    .ReadLine();

                //synonyms.Add(synonym);

                if (!words.ContainsKey(word))
                {
                    words[word] = new List<string>();
                }

                words[word].Add(synonym);
            }

            foreach (var word in words)
            {
                Console.Write($"{word.Key} - ");
                /*
                List<string> s = new List<string>();

                foreach (var synonyms in word.Value)
                {                                                 FIRST SOLUTION
                    s.Add(synonyms);
                }                                                             

                //Console.WriteLine(string.Join(", ", s));
                */

                Console.WriteLine(string.Join(", ", word.Value));
            }
        }
    }
}