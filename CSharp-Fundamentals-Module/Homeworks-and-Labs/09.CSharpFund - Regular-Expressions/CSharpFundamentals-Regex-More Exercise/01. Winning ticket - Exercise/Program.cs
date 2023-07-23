using System;
using System.Linq;
using System.Text.RegularExpressions;

class WinningTicket
{
    static void Main()
    {
        var regex = new Regex(@"@{6,}|\${6,}|#{6,}|\^{6,}");

        var tickets = Console.ReadLine().Split(',').Select(x => x.Trim()).ToArray();

        foreach (var ticket in tickets)
        {
            if (ticket.Length != 20)
            {
                Console.WriteLine("invalid ticket");
                continue;
            }

            var leftSide = ticket.Substring(0, 10); //Взимаме първата половина
            var matchLeft = regex.Match(leftSide); //Проверяваме за съвпадение в нея
            var rightSide = ticket.Substring(9, 10);//Взимаме втората половина
            var matchRight = regex.Match(rightSide);//Проверяваме за съвпадение в нея

            var ch = matchLeft.Value[0];

            if ((matchLeft.Success && matchRight.Success && matchLeft.Value[0] == matchRight.Value[0]))
            {
                var winningString = Math.Min(matchLeft.Value.Length, matchRight.Value.Length);//Дължина на печелившата линия
                var winningSymbol = matchLeft.Value[0];//Печеливш символ
                if (winningString == 10) //Отпечатване на джакпот
                {
                    Console.WriteLine($@"ticket ""{ticket}"" - {winningString}{winningSymbol} Jackpot!");
                }
                else //Отпечатване за обикновен печеливш билет
                {
                    Console.WriteLine($@"ticket ""{ticket}"" - {winningString}{winningSymbol}");
                }
            }
            else
            {
                Console.WriteLine($@"ticket ""{ticket}"" - no match");
            }
        }
    }
}