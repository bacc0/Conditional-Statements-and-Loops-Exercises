using System;
using System.Collections.Generic;
using System.Linq;

namespace user-Logs
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var userHolder = new SortedDictionary<string, Dictionary<string, int>>();

            while (true)
            {
                var input = Console.ReadLine().Split()
                                              .ToList();

                if (input[0].Equals("end"))
                {
                    break;
                }

                var ipS  = input[0].Substring(3);
                var user = input[2].Substring(5);


                if (!userHolder.ContainsKey(user))
                {

                    userHolder[user] = new Dictionary<string, int>();
                }
                if (!userHolder[user].ContainsKey(ipS))
                {
                    userHolder[user][ipS] = 0;
                }
                userHolder[user][ipS] += 1;
            }

            foreach (var pair in userHolder)
            {
                Console.WriteLine($"{pair.Key}:");


                var lenght  = pair.Value.Count;
                var counter = 0;

                foreach (var pairS in pair.Value)
                {
                    ++counter;

                    Console.Write($"{pairS.Key} => {pairS.Value}");

                    if (counter != lenght)
                    {
                        Console.Write(", ");
                    }
                    else
                    {
                        Console.Write(".");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
