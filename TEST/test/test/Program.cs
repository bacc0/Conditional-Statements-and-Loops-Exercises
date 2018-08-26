using System;
using System.Linq;


namespace test
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var arr = Console.ReadLine()
                             .Split(' ')
                             .Select(int.Parse)
                             .ToArray();

            var k = arr.Length / 4;

            var uppeerArr = new int[k * 2];
            var lowerArr  = new int[k * 2];

            for (int i = 0; i < k * 2; i++) 
            {
                lowerArr[i] = arr[i + k];
            }

            for (int i = 0; i < k; i++)
            {
                uppeerArr[i] = arr[k - 1 - i];
                uppeerArr[k + i] = arr[arr.Length - 1 - i];
            }

            var sum = new int[k * 2]; 

            for (int i = 0; i < sum.Length; i++) 
            {
                sum[i] = uppeerArr[i] + lowerArr[i]; 
            }

            Console.WriteLine(String.Join(" ", sum));


        }
    }
}
