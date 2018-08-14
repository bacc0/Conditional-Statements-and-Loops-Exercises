using System;
using System.Collections.Generic;
using System.Linq;


namespace AMinerTask
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var mine = new Dictionary<string, int>();

            string  commands = Console.ReadLine();

            string metal = "";
            int quantity = 0;

            while (commands != "stop")
            {
                metal = commands;
                quantity = int.Parse(Console.ReadLine());

                if (!mine.ContainsKey(metal))
                {
                    mine.Add(metal, quantity);
                }
                else
                {
                    mine[metal] += quantity;
                }
                commands = Console.ReadLine();
            }
            foreach (var pair in mine)
            {
                Console.WriteLine($"{pair.Key} -> {pair.Value}");
            }
        }
    }
}
