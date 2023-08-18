using System.Text.RegularExpressions;

namespace _4._Santa_s_Helper
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int key = int.Parse(Console.ReadLine());

            List<string> goodChildren = new List<string>();

            string encryptedMessage;
            while ((encryptedMessage = Console.ReadLine()) != "end")
            {
                string decryptedMessage = string.Empty;

                for (int n = 0; n < encryptedMessage.Length; n++)
                {
                    char loweredChar = encryptedMessage[n];

                    loweredChar -= (char)key;

                    decryptedMessage += loweredChar;
                }

                string pattern = @"@(?<childName>[A-Za-z]+)[^@:!\->]+!(?<childBehavior>G|N)!";

                Regex regex = new Regex(pattern);

                Match match = regex.Match(decryptedMessage);

                if (match.Success)
                {
                    string currentChildName = match.Groups["childName"].Value;
                    char currentChildBehavior = char.Parse(match.Groups["childBehavior"].Value);

                    if (currentChildBehavior == 'G')
                    {
                        goodChildren.Add(currentChildName);
                    }
                }
            }

            Console.WriteLine(string.Join(Environment.NewLine, goodChildren));
        }
    }
}