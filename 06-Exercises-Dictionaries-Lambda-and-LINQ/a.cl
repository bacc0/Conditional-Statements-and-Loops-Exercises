using System;
using System.Collections.Generic;
using System.Linq;

namespace Application
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var users = new SortedDictionary<string, Dictionary<string, int>>();
            var input = Console.ReadLine().Split().ToList();

            var user = "";
            var ipS = "";
           
            while ( input[0] != "end")
            {
                try
                {
                    ipS = input[0].Substring(3);
                    user = input[2].Substring(5);
                }
                catch
                {
                    break;
                }

                if ( ! users.ContainsKey(user))
                {

                    users[user] = new Dictionary<string, int>();
                }
                if ( ! users[user].ContainsKey(ipS))
                {
                    users[user][ipS] = 0 ;
                }
                users[user][ipS] += 1;

                input = Console.ReadLine().Split().ToList();
            }

            foreach (var pair in users)
            {
                Console.WriteLine($"{pair.Key}: ");

                var a = pair.Value.Values;

                var i = 0;
                var count = pair.Value.Count();

                foreach (var pairas in pair.Value)
                {
                    
                    if (++i == count) //this is the last item
                    {
                        Console.Write($"{pairas.Key} => {pairas.Value}. "); 
                    }
                    else
                    {
                        Console.Write($"{pairas.Key} => {pairas.Value}, "); 
                    }
                }

                Console.WriteLine();
            }
        }
    }
}
