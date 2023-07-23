
/*
Ace of Diamonds, Queen of Hearts, King of Clubs
3
Add, King of Diamonds
Insert, 2, Jack of Spades
Remove, Ace of Diamonds

Two of Clubs, King of Spades, Five of Spades, Jack of Hearts
2
Add, Two of Clubs
Remove, Five of Hearts

Jack of Spades, Ace of Clubs, Jack of Clubs
2
Insert, -1, Queen of Spades
Remove At, 1
 */
namespace Problem_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> cards = Console
                .ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            int number = int.Parse(Console.ReadLine());
            for (int i = 0; i < number; i++)
            {
                string commands = Console.ReadLine();
                string[] arguments = commands.Split(", ", StringSplitOptions.RemoveEmptyEntries);

                switch (arguments[0])
                {
                    case "Add":
                        string cardName = arguments[1];
                        if (cards.Contains(cardName))
                        {
                            Console.WriteLine("Card is already in the deck");
                        }
                        else
                        {
                            cards.Add(cardName);
                            Console.WriteLine("Card successfully added");
                        }
                        break;
                    case "Remove":
                        string removeCardName = arguments[1];
                        if (!cards.Contains(removeCardName))
                        {
                            Console.WriteLine("Card not found");
                        }
                        else
                        {
                            cards.Remove(removeCardName);
                            Console.WriteLine("Card successfully removed");
                        }
                        break;
                    case "Remove At":
                        int removeAtIndexCard = int.Parse(arguments[1]);
                        if (removeAtIndexCard >= 0 && removeAtIndexCard < cards.Count)
                        {
                            cards.RemoveAt(removeAtIndexCard);
                            Console.WriteLine("Card successfully removed");
                        }
                        else
                        {
                            Console.WriteLine("Index out of range");
                        }
                        break;
                    case "Insert":
                        int insertAtIndex = int.Parse(arguments[1]);
                        string insertCardName = arguments[2];
                        if (insertAtIndex >= 0 && insertAtIndex < cards.Count)
                        {
                            if (cards.Contains(insertCardName))
                            {
                                Console.WriteLine("Card is already added");
                            }
                            else
                            {
                                cards.Insert(insertAtIndex, insertCardName);
                                Console.WriteLine("Card successfully added");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Index out of range");
                        }
                        break;
                }
            }

            Console.WriteLine(string.Join(", ", cards));
        }
    }
}