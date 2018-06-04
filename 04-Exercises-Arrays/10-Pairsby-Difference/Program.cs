using System;
using System.Linq;


namespace PairsbyDifference
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                                .Split(' ')
                                .Select(int.Parse)
                                .ToArray();
            int difference = int.Parse(Console.ReadLine());

            int count = 0;
           
            for (int i = 0; i < arr.Length; i++) 
            {
                for (int j = i; j < arr.Length; j++)
                {
                    Console.WriteLine($"{arr[i]} - {arr[j]} = {Math.Abs(arr[i] - arr[j])}");
                    if (Math.Abs(arr[i] - arr[j]) == difference)
                    {
                        count++;
                    }
                }
            }
            Console.WriteLine(count);
        }
    }
}
