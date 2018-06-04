using System;
using System.Linq;
using System.Collections.Generic;


namespace _04_Sieve_Оf_Eratosthenes
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                                .Split(' ')
                                .Select(int.Parse)
                                .ToArray();
            int counter    = 1;
            int counterMax = 0;
            int position   = 0;

            for (int i = 0; i < arr.Length - 1; i++) 
            {
                if (arr[i] < arr[i + 1])
                {
                    counter++;
                }
                else
                {
                    if (counter > counterMax)
                    {
                        counterMax = counter;
                        position = i + 1;
                    }
                    counter = 1;
                }
                if (i + 1 == arr.Length - 1)
                {
                    if (counter > counterMax)
                    {
                        counterMax = counter;
                        position = arr.Length  ;
                    }
                }
            }
            int index = position - counterMax;


            for (int i = 0; i < counterMax; i++) 
            {
                Console.Write(arr[index++] + " ");
            }
        }
    }
}
    
