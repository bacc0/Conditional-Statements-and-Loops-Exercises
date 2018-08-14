using System;
using System.Linq;
using System.Collections.Generic;

namespace populationCounter
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var populationCounter = new Dictionary<string, Dictionary<string, long>>();

            while (true)
            {
                var input = Console.ReadLine().Split('|').ToList();

                if(input[0].Equals("report"))
                {
                    break;
                }

                var state = input[1];
                var town  = input[0];
                var population = long.Parse(input[2]);


                if( ! populationCounter.ContainsKey(state))
                {
                    populationCounter[state] = new Dictionary<string, long>();
                }

                if ( !  populationCounter[state].ContainsKey(town))
                {
                    populationCounter[state][town] = 0;
                }

                populationCounter[state][town] = population;

            }

            foreach (var pair in populationCounter.OrderByDescending( x => x.Value.Values.Sum()))
            {
                Console.WriteLine($"{pair.Key} (total population: {pair.Value.Values.Sum()})");

                foreach (var pairTown in pair.Value.OrderByDescending( x => x.Value))
                {
                    Console.WriteLine($"=>{pairTown.Key}: {pairTown.Value}");
                }
            }
        }
    }
}

        
