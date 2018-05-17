using System;

namespace Купа
{
    class Program
    {
        static void Main(string[] args)
        {
            var counter = 0;

            try
            {
                while (true)
                {
                    int integer = int.Parse(Console.ReadLine());
                    counter++;
                }
            }
            catch
            {
                Console.WriteLine(counter);
            }
        }
    }
}