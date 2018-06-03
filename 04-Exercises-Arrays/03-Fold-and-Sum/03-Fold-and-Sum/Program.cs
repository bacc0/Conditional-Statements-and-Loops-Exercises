using System;
using System.Linq;

namespace _03_Fold_and_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                               .Split(' ')
                               .Select(int.Parse)
                               .ToArray();
            
            var k = arr.Length / 4;

            int[] upper = new int[k * 2];
            int[] lower = new int[k * 2];
            int[] sum   = new int[k * 2];

            for (int i = 0; i < k ;i++)
            {
                upper[i] = arr[arr.Length - k * 3 - 1 - i];
                upper[k + i] = arr[arr.Length - 1 - i];
            }
            for (int i = 0; i < k * 2 ; i++)
            {
                lower[i] = arr[k + i];
            }
            for (int i = 0; i < k * 2; i++)
            {
                sum[i] = upper[i] + lower[i];
            }
            Console.WriteLine(string.Join(" ",sum));
        }
    }
}
