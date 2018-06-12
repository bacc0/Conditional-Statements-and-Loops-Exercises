using System;
using System.Linq;
using System.Collections.Generic;


namespace Population=Counter
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var countries = new Dictionary<string, Dictionary<string, long>>();

            var input = Console.ReadLine()
                               .Split('|')
                               .ToList();

            var country = "";
            var town = "";
            long population = 0;
            
            while (input[0] != "report")
            {
                country = input[1];
                town = input[0];
                population = long.Parse(input[2]);

                if ( ! countries.ContainsKey(country))
                {
                    var townInfo = new Dictionary<string, long>();
                    townInfo.Add(town, population);
                    
                    countries.Add(country, townInfo);
                }
                else
                {
                    if ( ! countries[country].ContainsKey(town))
                    {
                        countries[country].Add(town, population);
                    }
                }

                input = Console.ReadLine()
                               .Split('|')
                               .ToList();
            }

            foreach (var pair in countries
                                       .OrderByDescending( 
                                        x => x.Value.Values.Sum()))
            {
                Console.WriteLine($"{pair.Key} (total population: {pair.Value.Values.Sum()})");

                foreach (var pairTown in pair.Value
                                             .OrderByDescending( 
                                              y => y.Value))
                {
                    Console.WriteLine($"=>{pairTown.Key}: {pairTown.Value}");
                }
            }
        }
    }
}

