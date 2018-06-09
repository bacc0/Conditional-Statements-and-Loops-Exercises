﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace HandsofCards
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var players = new Dictionary<string, List<string>>();



            while (true)
            {
                string line =Console.ReadLine();

                if (line == "JOKER")
                {
                    break;
                }
                string[] tokens = line.Split(':');

                string playerName = tokens[0];

                string[] cards = tokens[1].Trim()
                                          .Split(new char[] { ' ', ',' }, 
                                                 StringSplitOptions.RemoveEmptyEntries);

                if (players.ContainsKey(playerName) == false)
                {
                    players.Add(playerName, new List<string>());
                }
                players[playerName].AddRange(cards);

            }
           var power = new Dictionary<string, int>();

            for (int i = 2; i < 10; i++) 
            {
                power.Add(i.ToString(), i);
            }
            power.Add("1", 10);

            power.Add("J", 11);
            power.Add("Q", 12);
            power.Add("K", 13);
            power.Add("A", 14);

            power.Add("C", 1);
            power.Add("D", 2);
            power.Add("H", 3);
            power.Add("S", 4);

            foreach (var player in players)
            {
                List<string> cards = player.Value
                                        .Distinct()
                                        .ToList();
                int sum = 0;

                foreach (var card in cards)
                {
                    string cardPowerStr = card[0].ToString();
                    string cardSuitStr = card[card.Length - 1].ToString();

                    int cardPower = power[cardPowerStr];
                    int cardSuit  = power[cardSuitStr];

                    sum += cardPower * cardSuit;
                }
                Console.WriteLine($"{player.Key}: {sum}");
            }
        }
    }
}
