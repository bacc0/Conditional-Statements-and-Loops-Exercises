using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Phonebook
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var concerts = new Dictionary<string, Dictionary<string, int>>();

            while (true)
            {
                var input = Console.ReadLine();

                if (input.Equals("End"))
                {
                    break;
                }

                string pattern = @"(([a-zA-Z]+\s){1,3})@(([a-zA-Z]+\s){1,3})(\d+)\s(\d+)";
                Match match = Regex.Match(input, pattern);

                if (match.Groups[3].Value != "")
                {
                    var place = match.Groups[3].Value.Trim();

                    var singer = match.Groups[1].Value.Trim();

                    var price = (match.Groups[5].Value);
                    var tickets = (match.Groups[6].Value);

                    int profit = int.Parse(tickets) * int.Parse(price);

                    if (!concerts.ContainsKey(place))
                    {
                        concerts[place] = new Dictionary<string, int>();
                    }
                    if (!concerts[place].ContainsKey(singer))
                    {
                        concerts[place][singer] = 0;
                    }
                    concerts[place][singer] += profit;
                }
            }
            foreach (var place in concerts)
            {
                Console.WriteLine($"{place.Key}");
                
                foreach (var pair in place.Value.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"#  {pair.Key} -> {pair.Value}");
                }
            }
        }
    }
}
