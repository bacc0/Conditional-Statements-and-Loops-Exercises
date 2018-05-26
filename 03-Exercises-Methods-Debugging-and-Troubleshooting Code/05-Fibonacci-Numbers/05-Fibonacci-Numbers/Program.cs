using System;

namespace FibonacciNumbers
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            int result = CalculateFibunacciNum(number);
            Console.WriteLine(result);
        }

        static int CalculateFibunacciNum(int num)
        {
            int result = 0;

            if (num == 0 || num == 1)
            {
                return 1;
            }
            int prevNumber = 1;
            int oneBeforePrevNumber = 1;

            for (int i = 2; i <= num; i++)
            {
                result = prevNumber + oneBeforePrevNumber;
                oneBeforePrevNumber = prevNumber;
                prevNumber = result;
            }
            return result;
        }
    }
}
