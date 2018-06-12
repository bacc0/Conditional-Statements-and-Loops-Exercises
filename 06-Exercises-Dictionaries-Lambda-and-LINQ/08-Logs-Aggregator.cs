using System;
using System.Linq;
using System.Collections.Generic;

namespace Logs-Aggregator
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var nameIpsDurations = new SortedDictionary
                              <string, SortedDictionary<string, int>>();

            var count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++) 
            {
                var line = Console.ReadLine();

                var split = line.Split()
                                .ToArray();

                var nameUser = split[1];
                var ip   = split[0];
                var duration = int.Parse(split[2]);



                if ( ! nameIpsDurations.ContainsKey(nameUser))
                {
                    nameIpsDurations[nameUser] = new SortedDictionary<string, int>();
                }
                if (! nameIpsDurations[nameUser].ContainsKey(ip))
                {
                    nameIpsDurations[nameUser][ip] = 0;
                }

                nameIpsDurations[nameUser][ip] += duration;
            }

            foreach (var nameIpsDuration in nameIpsDurations)
            {
                var name = nameIpsDuration.Key;
                var ipDuration = nameIpsDuration.Value;

                var totalDurations = ipDuration.Sum( x => x.Value);

                var ipS = ipDuration.Keys.ToArray();

                Console.WriteLine($"{name}: {totalDurations} [{string.Join(", ", ipS)}]");
            }
        }
    }
}

        

