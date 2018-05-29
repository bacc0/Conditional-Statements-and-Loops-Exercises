using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class MainClass
{
    static void Main()
    {
        BigInteger num = BigInteger.Parse(Console.ReadLine());

        BigInteger facturel = FactorialCalc(num);

        Console.WriteLine(CountZeros(facturel));
    }

    static BigInteger FactorialCalc(BigInteger num)
    {
        BigInteger sum = num;
        for (BigInteger i = num - 1; i >= 1; i--)
        {
            sum *= i;
        }
        return sum;
    }

    static BigInteger CountZeros(BigInteger facturel)
    {
        var counter = 0;
        while (facturel > 0)
        {
            var temp = facturel % 10;

            if (temp == 0)
            {
                counter++;
            }
            else
            {
                return counter;
            }
            facturel = facturel / 10;
        }
        return counter;
    }
}


