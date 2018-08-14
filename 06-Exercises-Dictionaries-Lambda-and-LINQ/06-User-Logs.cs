using System;
using System.Collections.Generic;
using System.Linq;


namespace Phonebook
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var dic = new SortedDictionary<string, Dictionary<string, int>>();

            var input = Console.ReadLine();

            while (!input.Equals("end"))
            {
                var splited = input.Split().ToList();

                var ipS  = splited[0].Substring(3);
                var user = splited[2].Substring(5);

                if (!dic.ContainsKey(user))
                {
                    dic[user] = new Dictionary<string, int>();
                }
                if (!dic[user].ContainsKey(ipS))
                {
                    dic[user][ipS] = 0;
                }
                dic[user][ipS] += 1;

                input = Console.ReadLine();
            }

            foreach (var user in dic)
            {
                Console.WriteLine(user.Key + ":");

                var result = "";

                    foreach (var pair in user.Value)
                    {
                        result += $"{pair.Key} => {pair.Value}, ";
                    }

                Console.WriteLine(result.TrimEnd(new Char[] { ' ', ',' }) + ".");
            }
        }
    }
}

// using System;
// using System.Collections.Generic;
// using System.Linq;

// namespace user-Logs
// {
//     class MainClass
//     {
//         public static void Main(string[] args)
//         {
//             var userHolder = new SortedDictionary<string, Dictionary<string, int>>();

//             while (true)
//             {
//                 var input = Console.ReadLine().Split()
//                                               .ToList();

//                 if (input[0].Equals("end"))
//                 {
//                     break;
//                 }

//                 var ipS  = input[0].Substring(3);
//                 var user = input[2].Substring(5);


//                 if (!userHolder.ContainsKey(user))
//                 {

//                     userHolder[user] = new Dictionary<string, int>();
//                 }
//                 if (!userHolder[user].ContainsKey(ipS))
//                 {
//                     userHolder[user][ipS] = 0;
//                 }
//                 userHolder[user][ipS] += 1;
//             }

//             foreach (var pair in userHolder)
//             {
//                 Console.WriteLine($"{pair.Key}:");


//                 var lenght  = pair.Value.Count;
//                 var counter = 0;

//                 foreach (var pairS in pair.Value)
//                 {
//                     ++counter;

//                     Console.Write($"{pairS.Key} => {pairS.Value}");

//                     if (counter != lenght)
//                     {
//                         Console.Write(", ");
//                     }
//                     else
//                     {
//                         Console.Write(".");
//                     }
//                 }
//                 Console.WriteLine();
//             }
//         }
//     }
// }
