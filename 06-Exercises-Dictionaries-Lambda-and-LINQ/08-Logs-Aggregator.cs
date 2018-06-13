using System;
using System.Linq;
using System.Collections.Generic;

namespace test2
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
                var input = Console.ReadLine();

                var split = input.Split();

                var user = split[1];
                var ipS  = split[0];
                var seconds = int.Parse(split[2]);


                if ( ! nameIpsDurations.ContainsKey(user))
                {
                    nameIpsDurations[user] = new SortedDictionary<string, int>();
                }
                if ( ! nameIpsDurations[user].ContainsKey(ipS))
                {
                    nameIpsDurations[user][ipS] = 0;
                }
                nameIpsDurations[user][ipS] += seconds;
            }


            foreach (var nameIpsDuration in nameIpsDurations)
            {
                var name = nameIpsDuration.Key;
                var ipAdreses = nameIpsDuration.Value.Keys;
                var secondsSum = nameIpsDuration.Value.Values.Sum();

                Console.WriteLine($"{name}: {secondsSum} [{string.Join(", ", ipAdreses)}]");
            }
        }
    }
}
