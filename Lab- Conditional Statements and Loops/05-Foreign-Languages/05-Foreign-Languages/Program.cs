using System;

namespace _05_Foreign_Languages
{
    class Program
    {
        static void Main(string[] args)
        {
            var language = Console.ReadLine();

            switch (language)
            {
                case "England":
                case "USA":
                    Console.WriteLine("English");
                    break;

                case "Spain":
                case "Argentina":
                case "Mexico":
                    Console.WriteLine("Spanish");
                    break;

                default:
                    Console.WriteLine("unknown");
                    break;
            }
        }
    }
}
