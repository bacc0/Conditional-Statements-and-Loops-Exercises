using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace sarbianUnleashed
{
    class MainClass
    {
        public static void Main(string[] args)

        {
            var dict = new Dictionary<string, Dictionary<string, int>>();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "End")
                {
                    break;
                }



                string correctInputPattern = @"(([a-zA-Z]+\s){1,3})@(([a-zA-Z]+\s){1,3})(\d+)\s(\d+)";



                if (Regex.IsMatch(input, correctInputPattern))
                {
                    Match match = Regex.Match(input, correctInputPattern);

                    var place = match.Groups[3].Value.Trim();

                    var singer = match.Groups[1].Value.Trim();

                    var ticketsPrice = int.Parse(match.Groups[5].Value);
                    var ticketsCount = int.Parse(match.Groups[6].Value);

                    var totalMoney = ticketsCount * ticketsPrice;



                    if ( ! dict.ContainsKey(place))
                    {
                        dict[place] = new Dictionary<string, int>();
                    }
                    if ( ! dict[place].ContainsKey(singer))
                    {
                        dict[place][singer]= 0;
                    }
                    dict[place][singer] += totalMoney;

                }
            }

            foreach (var place in dict)
            {
                Console.WriteLine($"{place.Key}");

                foreach (var pair in place.Value.OrderByDescending( x => x.Value))
                {
                    Console.WriteLine($"#  {pair.Key} -> {pair.Value}");
                }
            }
        }
    }
}
