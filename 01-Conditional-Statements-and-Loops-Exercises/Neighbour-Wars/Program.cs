using System;
using System.Reflection;

namespace cup
{
    class Program
    {
        static void Main(string[] args)
        {
            var peshoDamage = int.Parse(Console.ReadLine());
            var goshoDamage = int.Parse(Console.ReadLine());

            var gosho = 100;
            var pesho = 100;

            var countRestore = 0;

            while (true)
            {
                gosho -= peshoDamage;
                if (gosho <= 0)
                {
                    Console.WriteLine($"Pesho won in {++countRestore}th round.");
                    return;
                }
                Console.WriteLine($"Pesho used Roundhouse kick and reduced Gosho to {gosho} health.");
                countRestore++;
                if (countRestore % 3 == 0)
                {
                    gosho += 10;
                    pesho += 10;
                }
                pesho -= goshoDamage;
                if (pesho <= 0)
                {
                    Console.WriteLine($"Gosho won in {++countRestore}th round.");
                    return;
                }
                Console.WriteLine($"Gosho used Thunderous fist and reduced Pesho to {pesho} health.");
                countRestore++;
                if (countRestore % 3 == 0)
                {
                    gosho += 10;
                    pesho += 10;
                }
            }
        }
    }
}
Binder