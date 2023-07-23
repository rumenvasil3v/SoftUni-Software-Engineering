using System.Xml.Linq;
/*
 Mike, John, Eddie
Blacklist Mike
Error 0
Report

Mike, John, Eddie, William
Error 3
Error 3
Change 0 Mike123
Report

Mike, John, Eddie, William
Blacklist Maya
Error 1
Change 4 George
Report
Blacklisted names: 0
Lost names: 1
Mike Lost Eddie William
 */
namespace Problem_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] friends = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);

            int blackListedNamesCount = 0;
            int countOfLostNames = 0;

            string input;
            while ((input = Console.ReadLine()) != "Report")
            {
                string[] arguments = input.Split();

                switch (arguments[0])
                {
                    case "Blacklist":
                        string givenName = arguments[1];
                        bool isFind = false;
                        for (int i = 0; i < friends.Length; i++)
                        {
                            if (friends[i] == givenName)
                            {
                                isFind = true;
                                friends[i] = "Blacklisted";
                                Console.WriteLine($"{givenName} was blacklisted.");
                                blackListedNamesCount++;
                                break;
                            }
                        }

                        if (!isFind)
                        {
                            Console.WriteLine($"{givenName} was not found.");
                        }

                        break;
                    case "Error":
                        int index = int.Parse(arguments[1]);
                        if (index >= 0 && index < friends.Length)
                        {
                            if (friends[index] != "Blacklisted" && friends[index] != "Lost")
                            {
                                Console.WriteLine($"{friends[index]} was lost due to an error.");
                                friends[index] = "Lost";
                                countOfLostNames++;
                            }
                        }
                        break;
                    case "Change":
                        int changeIndex = int.Parse(arguments[1]);
                        string newName = arguments[2];
                        if (changeIndex >= 0 && changeIndex < friends.Length)
                        {
                            string currentName = friends[changeIndex];
                            friends[changeIndex] = newName;
                            Console.WriteLine($"{currentName} changed his username to {newName}.");
                        }
                        break;
                }
            }

            Console.WriteLine($"Blacklisted names: {blackListedNamesCount}");
            Console.WriteLine($"Lost names: {countOfLostNames}");
            Console.WriteLine(string.Join(' ', friends));
        }
    }
}