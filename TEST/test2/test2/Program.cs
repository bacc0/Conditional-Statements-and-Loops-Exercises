using System;
using System.Collections.Generic;
using System.Linq;

namespace test2
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var dic = new Dictionary<string, Dictionary<string, int>>();

            var input = Console.ReadLine()
                               .Split()
                               .ToArray();

            while (!input[0].Equals("end"))
            {
                var userHelper = input[2].Split('=').ToArray();
                var ipHelper = input[0].Split('=').ToArray();

                var user = userHelper[1];
                var ip = ipHelper[1];

                if ( !dic.ContainsKey(user))
                {
                    dic[user] = new Dictionary<string, int>();
                }
                if ( ! dic[user].ContainsKey(ip))
                {
                    dic[user][ip] = 0;
                }
                dic[user][ip] += 1;

                input = Console.ReadLine()
                               .Split()
                               .ToArray();
            }

            foreach (var item in dic.OrderBy( x => x.Key))
            {
                Console.WriteLine(item.Key + ": ");

                var arr = new List<string>();

                foreach (var ipS in item.Value)
                {
                    
                    arr.Add($"{ipS.Key} => {ipS.Value}");

                }
                Console.WriteLine(string.Join(", ", arr) + '.');
            }
        }
    }
}



//01.

//using System;
//using System.Collections.Generic;
//using System.Linq;

//namespace test2
//{
//    class MainClass
//    {
//        public static void Main(string[] args)
//        {
//            var inp = Console.ReadLine();


//            var dic = new SortedDictionary<string, Dictionary<string, int>>();


//            while (!inp.Equals("end"))
//            {

//                var input = inp.Split()
//                               .ToArray();

//                var ipFull = input[0];
//                var userFull = input[2];

//                var ipHelper = ipFull.Split('=').ToArray();
//                var userHelper = userFull.Split('=').ToArray();

//                var ip = ipHelper[1];
//                var user = userHelper[1];

//                if (!dic)
//                {
//                    dic[user] = new Dictionary<string, int>();
//                }
//                if (!dic[user].ContainsKey(ip))
//                {
//                    dic[user][ip] = 0;
//                }

//                dic[user][ip] += 1;

//                inp = Console.ReadLine();
//            }

//            foreach (var user in dic)
//            {
//                Console.WriteLine(user.Key + ":");


//                var result = "";

//                foreach (var pair in user.Value)
//                {
//                    result += $"{pair.Key} => {pair.Value}, ";
//                }
//                Console.WriteLine(result.Trim(new char[] { ' ', ',' }) + '.');
//            }
//        }
//    }
//}




// 02.

//using System;
//using System.Collections.Generic;
//using System.Linq;

//namespace test2
//{
//    class MainClass
//    {
//        public static void Main(string[] args)
//        {

//            var dic = new Dictionary<string, Dictionary<string, long>>();

//            while (true)
//            {
//                var input = Console.ReadLine();

//                if (input.Equals("report"))
//                {
//                    break;
//                }
//                var elements = input.Split('|').ToArray();

//                var capital = elements[0];
//                var state = elements[1];
//                var population = long.Parse(elements[2]);

//                if (!dic.ContainsKey(state))
//                {
//                    dic[state] = new Dictionary<string, long>();
//                }
//                if (!dic[state].ContainsKey(capital))
//                {
//                    dic[state][capital] = 0;
//                }

//                dic[state][capital] += population;
//            }

//            foreach (var pair in dic.OrderByDescending(x => x.Value.Values.Sum()))
//            {
//                Console.WriteLine($"{pair.Key} (total population: {pair.Value.Values.Sum()})");

//                foreach (var town in pair.Value.OrderByDescending(y => y.Value))
//                {
//                    Console.WriteLine($"=>{town.Key}: {town.Value}");
//                }
//            }
//        }
//    }
//}


//03.

//using System;
//using System.Collections.Generic;
//using System.Linq;

//namespace test2
//{
//    class MainClass
//    {
//        public static void Main(string[] args)
//        {
//            var dic = new SortedDictionary<string, Dictionary<string, int>>();

//            var interations = int.Parse(Console.ReadLine());

//            for (int i = 0; i < interations; i++)
//            {
//                var input = Console.ReadLine()
//                                   .Split()
//                                   .ToArray();

//                var user = input[1];

//                var userIp = input[0];
//                var duration = int.Parse(input[2]);

//                if (!dic.ContainsKey(user))
//                {
//                    dic[user] = new Dictionary<string, int>();
//                }
//                if (!dic[user].ContainsKey(userIp))
//                {
//                    dic[user][userIp] = 0;
//                }
//                dic[user][userIp] += duration;
//            }

//            foreach (var userName in dic)
//            {
//                Console.Write(userName.Key + ": ");


//                var ipS = new List<string>();
//                var sum = 0;

//                foreach (var ipD in userName.Value.OrderBy(x => x.Key))
//                {
//                    ipS.Add(ipD.Key);

//                    sum += ipD.Value;
//                }
//                Console.Write(sum + " ");

//                Console.WriteLine("[" + string.Join(", ", ipS) + "]");
//            }
//        }
//    }
//}
