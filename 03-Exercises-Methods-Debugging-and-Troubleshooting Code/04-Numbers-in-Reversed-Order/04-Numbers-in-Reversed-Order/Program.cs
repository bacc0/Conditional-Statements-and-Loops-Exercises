using System;

namespace NumbersinReversedOrder
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string num = Console.ReadLine();
            Console.WriteLine(ReversingNuber(num));
        }

        static string ReversingNuber(string number)
        {
            string reversedNumber = "";

            for (int i = number.Length - 1; i >= 0; i--)
            {
                reversedNumber += number[i];
            }
            return reversedNumber;
        }
    }
}
