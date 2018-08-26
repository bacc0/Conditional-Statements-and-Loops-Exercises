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

            var arrDown = new int[k * 2]; 
            var arrUp = new int[k * 2]; 

            for (int i = 0; i < arrDown.Length ; i++) 
            {
                arrDown[i] = arr[k + i];
            }

            for (int i = 0; i < k; i++)
            {
                arrUp[i] = arr[k - 1 -i];
                arrUp[ k + i ] = arr[arr.Length - 1 - i];
            }

            var sum = new int[k * 2]; 

            for (int i = 0; i < sum.Length; i++) 
            {
                sum[i] = arrUp[i] + arrDown[i];
            }
            Console.WriteLine(string.Join(" ", arrUp));
            Console.WriteLine(string.Join(" ", arrDown));
            Console.WriteLine(string.Join(" ", sum));

        }
    }
}


//     1 2 3 4 5 6 7 8