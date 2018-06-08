using System;
using System.Collections.Generic;
using System.Linq;


namespace FixEmails
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var mailBook = new Dictionary<string, string>();
            string name = "";
            string mail = "";
            string commands =Console.ReadLine();

            while (commands != "stop")
            {
                name = commands;
                mail = Console.ReadLine();
                if (!mailBook.ContainsKey(name))
                {
                    mailBook.Add(name, mail);
                }
                commands = Console.ReadLine();
            }
            foreach (var pair in mailBook
                     .Where(x => !x.Value.EndsWith(".us") &&
                                 !x.Value.EndsWith(".uk") 
                           ) 
                    )
            {
                Console.WriteLine($"{pair.Key} -> {pair.Value}");
            }
        }
    }
}
