using System;

namespace _11_Odd_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            var integer = 0;

            while (true)
            {
                integer = int.Parse(Console.ReadLine());

                if (integer % 2 == 0)
                {
                    Console.WriteLine("Please write an odd number.");
                }
                else
                {
                    break;
                }
            }
            Console.WriteLine($"The number is: {Math.Abs(integer)}");
        }
    }
}
