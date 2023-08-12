/*
3
Fur Elise|Beethoven|A Minor
Moonlight Sonata|Beethoven|C# Minor
Clair de Lune|Debussy|C# Minor
Add|Sonata No.2|Chopin|B Minor
Add|Hungarian Rhapsody No.2|Liszt|C# Minor
Add|Fur Elise|Beethoven|C# Minor
Remove|Clair de Lune
ChangeKey|Moonlight Sonata|C# Major
Stop
*/

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Problem_3___The_Pianist
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Piece> pieces = new Dictionary<string, Piece>();

            int numberOfLines = int.Parse(Console.ReadLine());
            for (int n = 0; n < numberOfLines; n++)
            {
                string[] composerInfo = Console
                    .ReadLine()
                    .Split('|');

                string currentPiece = composerInfo[0];
                string currentComposer = composerInfo[1];
                string key = composerInfo[2];

                Piece piece = new Piece(currentPiece, key, currentComposer);

                if (!pieces.ContainsKey(currentPiece))
                {
                    pieces.Add(piece.Name, piece);
                    continue;
                }

                pieces.Add(piece.Name, piece);
            }

            string input;
            while ((input = Console.ReadLine()) != "Stop")
            {
                string[] commands = input
                    .Split("|");

                string piece = string.Empty;
                switch (commands[0])
                {
                    case "Add":
                        piece = commands[1];
                        string composer = commands[2];
                        string key = commands[3];

                        Piece newPiece = new Piece(piece, key, composer);
                        if (!pieces.ContainsKey(piece))
                        {
                            pieces.Add(piece, newPiece);
                            Console.WriteLine($"{piece} by {composer} in {key} added to the collection!");
                        }
                        else
                        {
                            Console.WriteLine($"{piece} is already in the collection!");
                        }
                        break;
                    case "Remove":
                        piece = commands[1];
                        if (pieces.ContainsKey(piece))
                        {
                            pieces.Remove(piece);
                            Console.WriteLine($"Successfully removed {piece}!");
                        }
                        else
                        {
                            Console.WriteLine($"Invalid operation! {piece} does not exist in the collection.");
                        }
                        break;
                    case "ChangeKey":
                        piece = commands[1];
                        string newKey = commands[2];

                        if (pieces.ContainsKey(piece))
                        {
                            pieces[piece].Key = newKey;
                            Console.WriteLine($"Changed the key of {piece} to {newKey}!");
                        }
                        else
                        {
                            Console.WriteLine($"Invalid operation! {piece} does not exist in the collection.");
                        }
                        break;
                }
            }

            foreach (var kvp in pieces)
            {
                Console.WriteLine($"{kvp.Key} -> Composer: {kvp.Value.Composer}, Key: {kvp.Value.Key}");
            }
        }
    }

    public class Piece
    {

        public Piece(string name, string key, string composer)
        {
            Name = name;
            Composer = composer;
            Key = key;
        }

        public string Composer { get; set; }

        public string Key { get; set; }

        public string Name { get; set; }
    }
}