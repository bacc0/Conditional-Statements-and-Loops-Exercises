using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace _06_PrimeChecker
{
    class Program
    {
        static void Main()
        {
            long inputNum = long.Parse(Console.ReadLine());
            Console.WriteLine(IsPrime(inputNum));
        }

        static bool IsPrime(long inputNum)
        {
            inputNum = Math.Abs(inputNum);
            bool result = true;

            if (inputNum == 2)
            {
                return true;
            }
            else if (inputNum == 1 || inputNum == 0)
            {
                return false;
            }

            for (int i = 2; i <= Math.Sqrt(inputNum); i++)
            {
                if (inputNum % i == 0)
                {
                    result = false;
                    break;
                }
            }
            return result;
        }
    }
}