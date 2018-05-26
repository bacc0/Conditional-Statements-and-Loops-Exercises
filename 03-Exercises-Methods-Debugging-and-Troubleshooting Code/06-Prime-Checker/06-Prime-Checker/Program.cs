using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class ReverseTheDigitsOfDecimal
{
    static void Main()
    {
        long number = long.Parse(Console.ReadLine());
        bool isPrime = IsPrime(number);
        Console.WriteLine(isPrime);
    }

    static bool IsPrime(long number)
    {
        if (number == 0 || number == 1)
        {
            return false;
        }
        for (long divider = 2; divider < number; divider++)
        {
            if (number % divider == 0)
            {
                return false;
            }
        }
        return true;
    }
}