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

namespace _03._Deck_of_Cards
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
                        if (IsItContainThisCard(cards, cardName, arguments[0]))
                        {
                            Console.WriteLine("Card is already in the deck");
                        }
                        else
                        {
                            AddCardToTheDeck(cards, cardName, arguments[0]);
                        }
                        break;
                    case "Remove":
                        string removeCardName = arguments[1];
                        if (IsItContainThisCard(cards, removeCardName, arguments[0]))
                        {
                            Console.WriteLine("Card not found");
                        }
                        else
                        {
                            RemoveCardFromTheDeck(cards, removeCardName, arguments[0]);
                        }
                        break;
                    case "Remove At":
                        int removeCardIndex = int.Parse(arguments[1]);
                        if (IsIndexInsideTheBoundaries(cards, removeCardIndex, arguments[0]))
                        {
                            RemoveCardFromTheDeck(cards, arguments[1], arguments[0]);
                        }
                        else
                        {
                            Console.WriteLine("Index out of range");
                        }
                        break;
                    case "Insert":
                        int insertAtIndex = int.Parse(arguments[1]);
                        string insertCardName = arguments[2];
                        if (IsIndexInsideTheBoundaries(cards, insertAtIndex, arguments[0]))
                        {
                            if (IsItContainThisCard(cards, insertCardName, arguments[0]))
                            {
                                Console.WriteLine("Card is already added");
                            }
                            else
                            {
                                AddCardToTheDeck(cards, insertCardName, arguments[1]);
                            }
                        }
                        else
                        {
                            Console.WriteLine("Index out of range");
                        }
                        break;
                }
            }

            PrintFinalCards(cards);
        }

        static bool IsItContainThisCard(List<string> cards, string cardNameOrRemoveCardNameOrInsertCardName, string arguments)
        {
            switch (arguments)
            {
                case "Add":
                    if (cards.Contains(cardNameOrRemoveCardNameOrInsertCardName))
                    {
                        return true;
                    }
                    break;
                case "Remove":
                    if (!cards.Contains(cardNameOrRemoveCardNameOrInsertCardName))
                    {
                        return true;
                    }
                    break;
                case "Insert":
                    if (cards.Contains(cardNameOrRemoveCardNameOrInsertCardName))
                    {
                        return true;
                    }
                    break;
            }

            return false;
        }

        static void AddCardToTheDeck(List<string> cards, string cardName, string arguments)
        {
            switch (arguments)
            {
                case "Add":
                    cards.Add(cardName);
                    Console.WriteLine("Card successfully added");
                    break;
                default:
                    int insertAtIndex = int.Parse(arguments);
                    cards.Insert(insertAtIndex, cardName);
                    Console.WriteLine("Card successfully added");
                    break;
            }
        }

        static void RemoveCardFromTheDeck(List<string> cards, string removeCardName, string arguments)
        {
            switch (arguments)
            {
                case "Remove":
                    cards.Remove(removeCardName);
                    Console.WriteLine("Card successfully removed");
                    break;
                case "Remove At":
                    int removeAtIndex = int.Parse(removeCardName);
                    cards.RemoveAt(removeAtIndex);
                    Console.WriteLine("Card successfully removed");
                    break;
            }
        }

        static bool IsIndexInsideTheBoundaries(List<string> cards, int removeOrInsertAtIndex, string arguments)
        {
            switch (arguments)
            {
                case "Remove At":
                    if (removeOrInsertAtIndex >= 0 && removeOrInsertAtIndex < cards.Count)
                    {
                        return true;
                    }
                    break;
                case "Insert":
                    if (removeOrInsertAtIndex >= 0 && removeOrInsertAtIndex < cards.Count)
                    {
                        return true;
                    }
                    break;
            }

            return false;
        }

        static void PrintFinalCards(List<string> cards)
        {
            Console.WriteLine(string.Join(", ", cards));
        }
    }
}