using System;

namespace MasterNumbers
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            for (int currentNum = 1; currentNum < number; currentNum++)
            {
                if ( IsSymetric(currentNum)        &&
                     ContainsEvenDigit(currentNum) &&
                     SumDigits(currentNum) % 7 == 0  )
                {
                    Console.WriteLine(currentNum);
                }
            }
        }

        static bool IsSymetric(int number)
        {
            string currentNum = number.ToString();

            int counter = 0;

            for (int i = currentNum.Length - 1; i >= 0; i--)
            {
                if (currentNum[i] != currentNum[counter])
                {
                    return false;
                }
                counter++;
            }
            return true;
        }

        static int SumDigits(int number)
        {
            int sum = 0;

            while (number != 0)
            {
                int digit = number % 10;
                sum += digit;
                number /= 10;
            }
            return sum;
        }

        static bool ContainsEvenDigit(int number)
        {
            while (number != 0)
            {
                int digit = number % 10;
                if (digit % 2 == 0)
                {
                    return true;
                }
                number /= 10;
            }
            return false;
        }
    }
}
