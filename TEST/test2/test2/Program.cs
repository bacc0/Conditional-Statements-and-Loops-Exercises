using System;
using System.Collections.Generic;
using System.Linq;

namespace test2
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var inp = Console.ReadLine();


            var dic = new SortedDictionary<string, Dictionary<string, int>>();


            while (!inp.Equals("end"))
            {

                var input = inp.Split()
                               .ToArray();

                var ipFull = input[0];
                var userFull = input[2];

                var ipHelper = ipFull.Split('=').ToArray();
                var userHelper = userFull.Split('=').ToArray();

                var ip = ipHelper[1];
                var user = userHelper[1];

                if (!dic.ContainsKey(user))
                {
                    dic[user] = new Dictionary<string, int>();
                }
                if (!dic[user].ContainsKey(ip))
                {
                    dic[user][ip] = 0;
                }

                dic[user][ip] += 1;

                inp = Console.ReadLine();
            }

            foreach (var user in dic)
            {
                Console.WriteLine(user.Key + ":");


                var result = "";

                foreach (var pair in user.Value)
                {
                    result += $"{pair.Key} => {pair.Value}, ";
                }
                Console.WriteLine(result.Trim(new char[] {' ', ','}) + '.');
            }
        }
    }
}
