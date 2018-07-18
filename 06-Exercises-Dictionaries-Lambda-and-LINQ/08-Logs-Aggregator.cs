using System;
using System.Collections.Generic;
using System.Linq;


namespace Phonebook
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var userDuration = new SortedDictionary<string, SortedDictionary<string, int>>();

            var r = int.Parse(Console.ReadLine());

            for (int i = 0; i < r; i++)
            {
                var input = Console.ReadLine().Split().ToList();

                var ipS = input[0];
                var user = input[1];
                var sec = int.Parse(input[2]);

                if (!userDuration.ContainsKey(user))
                {
                    userDuration[user] = new SortedDictionary<string, int>();
                }
                if (!userDuration[user].ContainsKey(ipS))
                {
                    userDuration[user][ipS] = 0;
                }
                userDuration[user][ipS] += sec;
            }

            foreach (var u in userDuration)
            {
                Console.WriteLine($"{u.Key}: {u.Value.Values.Sum()} [{string.Join(", ",u.Value.Keys)}]");
            }

        }
    }
}


// using System;
// using System.Linq;
// using System.Collections.Generic;

// namespace test2
// {
//     class MainClass
//     {
//         public static void Main(string[] args)
//         {
//             var nameIpsDurations = new SortedDictionary
//                                  <string, SortedDictionary<string, int>>();

//             var count = int.Parse(Console.ReadLine());

//             for (int i = 0; i < count; i++)
//             {
//                 var input = Console.ReadLine();

//                 var split = input.Split();

//                 var user = split[1];
//                 var ipS  = split[0];
//                 var seconds = int.Parse(split[2]);


//                 if ( ! nameIpsDurations.ContainsKey(user))
//                 {
//                     nameIpsDurations[user] = new SortedDictionary<string, int>();
//                 }
//                 if ( ! nameIpsDurations[user].ContainsKey(ipS))
//                 {
//                     nameIpsDurations[user][ipS] = 0;
//                 }
//                 nameIpsDurations[user][ipS] += seconds;
//             }


//             foreach (var nameIpsDuration in nameIpsDurations)
//             {
//                 var name = nameIpsDuration.Key;
//                 var ipAdreses = nameIpsDuration.Value.Keys;
//                 var secondsSum = nameIpsDuration.Value.Values.Sum();

//                 Console.WriteLine($"{name}: {secondsSum} [{string.Join(", ", ipAdreses)}]");
//             }
//         }
//     }
// }
