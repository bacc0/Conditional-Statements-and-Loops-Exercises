using System;
using System.Linq;

namespace _02_otate_and_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int intirationsNum = int.Parse(Console.ReadLine());


            var sum = new int[nums.Length];

            for (int i = 0; i < intirationsNum; i++)
            {
                var temp = nums[nums.Length - 1];
                for (int j = nums.Length - 1 ; j> 0; j--)
                {
                    nums[j] = nums[j - 1];
                }
                nums[0] = temp;

                for (int j = 0; j < nums.Length; j++)
                {
                    sum[j] += nums[j];
                }
            }

            Console.WriteLine(string.Join(" ", sum));
        }
    }
}
