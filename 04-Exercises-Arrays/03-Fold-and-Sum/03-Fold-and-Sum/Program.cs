using System;
using System.Linq;

namespace _03_Fold_and_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                                 .Split()
                                 .Select(int.Parse)
                                 .ToArray();

            int k = arr.Length / 4;

            int[] left  = new int[k];
            int[] mid   = new int[2 * k];
            int[] right = new int[k];

            for (int i = 0; i < k; i++)
            {
                left[i]  = arr[i];
                right[i] = arr[arr.Length - 1 - i];
            }
            Array.Reverse(left);

            int[] upper = new int[2 * k];

            for (int i = 0; i < k; i++)
            {
                upper[i]     = left[i];
                upper[i + k] = right[i];
            }

            int[] sum = new int[2 * k];

            for (int i = 0; i < 2 * k; i++)
            {
                mid[i] = arr[ k + i];
                sum[i] = upper[i] + mid[i];
            }
            Console.WriteLine(string.Join(" ", sum));
        }
    }
}
