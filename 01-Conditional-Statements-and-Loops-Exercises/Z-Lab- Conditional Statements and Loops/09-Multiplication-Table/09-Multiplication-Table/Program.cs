using System;

namespace _09_Multiplication_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            var integer = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{integer} X {i} = {integer * i}");
            }
        }
    }
}
