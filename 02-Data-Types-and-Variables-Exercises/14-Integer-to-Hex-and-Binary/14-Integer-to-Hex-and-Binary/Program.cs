using System;

namespace IntegertoHexandBinary
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());

            string hex = Convert.ToString(number, 16).ToUpper();
            string binary = Convert.ToString(number, 2);

            Console.WriteLine(hex);
            Console.WriteLine(binary);
        }

    }
}
