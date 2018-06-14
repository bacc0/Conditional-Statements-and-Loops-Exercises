using System;
using System.Linq;
using System.Collections.Generic;

namespace _04_Sieve_Оf_Eratosthenes
{
    class Program
    {
        static void Main(string[] args)
        {
            var players = new Dictionary<string, List<string>>();

            while (true)
            {
                var line = Console.ReadLine();

                if (line == "JOKER")
                {
                    break;
                }

                var tokens = line.Split(':');

                var name  = tokens[0];
                var cards = tokens[1]
                                .Split(new char[] { ' ', ',' }
                                       ,StringSplitOptions
                                       .RemoveEmptyEntries);

                if ( ! players.ContainsKey(name))
                {
                    players[name] = new List<string>();
                }
                players[name].AddRange(cards);
            }

            var powers = new Dictionary<string, int>();

            for (int i = 2; i < 10; i++)
            {
                powers.Add(i.ToString(), i);
            }
            powers.Add("1", 10);  

            powers.Add("J", 11);  
            powers.Add("Q", 12);  
            powers.Add("K", 13);  
            powers.Add("A", 14); 

            powers.Add("C", 1);  
            powers.Add("D", 2);
            powers.Add("H", 3);
            powers.Add("S", 4);

            foreach (var player in players)
            {
                var cards = player.Value
                                  .Distinct()
                                  .ToList();
                var sum = 0;

                foreach (var card in cards)
                {
                    var cardPowerStr = card[0].ToString();
                    var cardColorStr = card[card.Length - 1].ToString();

                    int cardPower = powers[cardPowerStr];
                    int cardColor = powers[cardColorStr];

                    sum += cardPower * cardColor;

                }
                Console.WriteLine($"{player.Key}: {sum}");
            }
        }
    }
}
