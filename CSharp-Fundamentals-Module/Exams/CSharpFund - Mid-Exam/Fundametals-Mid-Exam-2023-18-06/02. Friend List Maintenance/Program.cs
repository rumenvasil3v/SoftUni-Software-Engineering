using System;

namespace _02._Friend_List_Maintenance
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
                        isFind = BlacklistedFriends(givenName, isFind, friends);
                        if (IsItFindPersonToBlackList(isFind, givenName))
                        {
                            blackListedNamesCount++;
                        }
                        break;
                    case "Error":
                        int index = int.Parse(arguments[1]);
                        if (IsIndexInsideTheBoundaries(index, friends))
                        {
                            if (IsFriendNotInBlackListAndLost(index, friends))
                            {
                                countOfLostNames = LostedFriend(index, friends, countOfLostNames);
                            }
                        }
                        break;
                    case "Change":
                        int changeIndex = int.Parse(arguments[1]);
                        string newName = arguments[2];
                        if (IsChangeUserNameFriendIndexInsideTheBoundaries(changeIndex, friends))
                        {
                            ChangedUsername(changeIndex, friends, newName);
                        }
                        break;
                }
            }

            PrintFinalFriendList(blackListedNamesCount, countOfLostNames, friends);
        }

        static bool BlacklistedFriends(string givenName, bool isFind, string[] friends)
        {
            for (int i = 0; i < friends.Length; i++)
            {
                if (friends[i] == givenName)
                {
                    isFind = true;
                    friends[i] = "Blacklisted";
                    break;
                }
            }

            return isFind;
        }

        static bool IsItFindPersonToBlackList(bool isFind, string givenName)
        {
            if (isFind)
            {
                Console.WriteLine($"{givenName} was blacklisted.");
            }
            else
            {
                Console.WriteLine($"{givenName} was not found.");
            }

            return isFind;
        }

        static bool IsIndexInsideTheBoundaries(int index, string[] friends)
        {
            if (index >= 0 && index < friends.Length)
            {
                return true;
            }

            return false;
        }

        static bool IsFriendNotInBlackListAndLost(int index, string[] friends)
        {
            if (friends[index] != "Blacklisted" && friends[index] != "Lost")
            {
                return true;
            }

            return false;
        }

        static int LostedFriend(int index, string[] friends, int countOfLostNames)
        {
            Console.WriteLine($"{friends[index]} was lost due to an error.");
            friends[index] = "Lost";
            countOfLostNames++;

            return countOfLostNames;
        }

        static bool IsChangeUserNameFriendIndexInsideTheBoundaries(int changeIndex, string[] friends)
        {
            if (changeIndex >= 0 && changeIndex < friends.Length)
            {
                return true;
            }

            return false;
        }

        static void ChangedUsername(int changeIndex, string[] friends, string newName)
        {
            string currentName = friends[changeIndex];
            friends[changeIndex] = newName;
            Console.WriteLine($"{currentName} changed his username to {newName}.");
        }

        static void PrintFinalFriendList(int countOfBlackListedPeople, int countOfLostPeople, string[] friends)
        {
            Console.WriteLine($"Blacklisted names: {countOfBlackListedPeople}");
            Console.WriteLine($"Lost names: {countOfLostPeople}");
            Console.WriteLine(string.Join(' ', friends));
        }
    }
}