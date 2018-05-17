using System;

namespace cup
{
    class Program
    {
        static void Main(string[] args)
        {
            var goshoDamage = int.Parse(Console.ReadLine());
            var peshoDamage = int.Parse(Console.ReadLine());

            double peshoHelth = 100;
            double goshoHelth = 100;

            var count = 0;

            while (peshoHelth >= 1 || goshoHelth >= 1)
            {
                count++;
                goshoHelth -= goshoDamage;

                if (goshoHelth <= 0)
                {
                    Console.WriteLine($"Pesho won in {count}th round.");
                    Environment.Exit(0);
                }

                Console.WriteLine($"Pesho used Roundhouse kick and reduced Gosho to {goshoHelth} health.");

                if (count % 3 == 0)
                {
                    peshoHelth += 10;
                    goshoHelth += 10;
                }

                count++;
                peshoHelth -= peshoDamage;

                if (peshoHelth <= 0)
                {
                    Console.WriteLine($"Gosho won in {count}th round.");
                    Environment.Exit(0);
                }

                Console.WriteLine($"Gosho used Thunderous fist and reduced Pesho to {peshoHelth} health.");


                if (count % 3 == 0)
                {
                    peshoHelth += 10;
                    goshoHelth += 10;
                }
            }
        }
    }
}

