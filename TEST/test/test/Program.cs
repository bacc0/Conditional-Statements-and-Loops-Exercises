using System;
using System.Collections.Generic;
using System.Linq;


namespace test
{
    class MainClass
    {
        private static void Main(string[] args)
        {

            List<int> numbers = Console.ReadLine()
                                       .Split()
                                       .Select(int.Parse)
                                       .ToList();

            var counter = 1;
            var counterMax = 0;
            var numberMax = 0;

            for (int i = 0; i < numbers.Count - 1; i++)
            {
                if (numbers[i] == numbers[i + 1])
                {
                    counter++;
                    if (counterMax < counter)
                    {
                        counterMax = counter;
                        numberMax = numbers[i];
                    }
                }
                else
                {
                    counter = 1;
                }
            }
            for (int i = 0; i < counterMax; i++)
            {
                Console.Write(numberMax + " ");
            }
        }
    }
}


//     3 4 4 5 5 5 2 2