using System;
using System.Linq;


namespace EqualSums
{
    class MainClass
    {
        public static void Main(string[] args)
        {
          int[] numbers = Console.ReadLine()
                                 .Split(' ')
                                 .Select(int.Parse)
                                 .ToArray();
            int rightSum = 0;

            foreach (var number in numbers)
            {
                rightSum += number;
            }
            
            int  leftSum = 0;
            bool  index  = false;

            for (int i = 0; i < numbers.Length ; i++)
            {
                int curentNum = numbers[i];
                rightSum -= curentNum;

                if (leftSum == rightSum)
                {
                    index = true;
                    Console.WriteLine(i);
                    break;
                }
                leftSum += curentNum;
            }
            if (!index)
            {
                Console.WriteLine("no");
            }
        }
    }
}
