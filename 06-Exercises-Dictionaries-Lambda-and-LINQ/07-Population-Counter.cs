using System;
using System.Linq;
using System.Collections.Generic;

namespace test2
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var countries = new Dictionary<string, Dictionary<string, long>>();
            var input = Console.ReadLine().Split('|').ToArray();

            var town = "";
            var state = "";
            var population = 0;

            while (input[0] != "report")
            {
                town = input[0];
                state = input[1];
                population = int.Parse(input[2]);


                if ( ! countries.ContainsKey(state))
                {
                    countries[state] = new Dictionary<string, long>();
                }
                if ( ! countries[state].ContainsKey(town))
                {
                    countries[state][town] = 0;
                }
                countries[state][town] = population;


                input = Console.ReadLine().Split('|').ToArray();
            }

            
            foreach (var pair in countries.OrderByDescending( x => x.Value.Values.Sum()))
            {
                Console.WriteLine($"{pair.Key} (total population: {pair.Value.Values.Sum()})");

                foreach (var pairTown in pair.Value.OrderByDescending( y => y.Value))
                {
                    Console.WriteLine($"=>{pairTown.Key}: {pairTown.Value}");
                }
            }
        }
    }
}

        
