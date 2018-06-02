using System;
using System.Linq;

namespace Application
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            int[] arr = Console.ReadLine()
                               .Split(' ')
                               .Select(int.Parse).ToArray();
            int counter  = 1;
            int countMax = 0;
            int numMax   = 0;

            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i] == arr[i + 1])
                {
                    counter++;

                }
                else
                {
                    if (counter > countMax)
                    {
                        countMax = counter;
                        numMax = arr[i];
                    }
                    counter = 1;
                }
                if (i + 1 == arr.Length - 1)
                {
                    if (counter > countMax)
                    {
                        countMax = counter;
                        numMax = arr[i];
                    }
                }
            }
            for (int i = 0; i < countMax; i++)
            {
                Console.Write(numMax + " ");
            }
        }
    }
}
