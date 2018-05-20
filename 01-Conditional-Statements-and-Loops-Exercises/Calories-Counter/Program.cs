using System;

namespace test_today
{
    class Program
    {
        static void Main(string[] args)
        {
            var count = 0;
            while (true)
            {
                count++;
                var ingredient = Console.ReadLine();

                if (ingredient == "Bake!")
                {
                    Console.WriteLine($"Preparing cake with {--count} ingredients.");
                    break;
                }
                else
                {
                    Console.WriteLine($"Adding ingredient {ingredient}.");
                }
            }
        }
    }
}
