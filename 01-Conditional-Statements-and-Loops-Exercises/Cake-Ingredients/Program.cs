using System;

namespace gr
{
    class Program
    {
        static void Main(string[] args)
        {
            var count = -1;
            for (int i = 0; i <= 20; i++)
            {
                count++;

                var a = Console.ReadLine();

                if (a != "Bake!")
                {
                    Console.WriteLine($"Adding ingredient {a}.");
                }
                else
                {
                    Console.WriteLine($"Preparing cake with {count} ingredients.");
                    break;
                }
            }
        }
    }
}