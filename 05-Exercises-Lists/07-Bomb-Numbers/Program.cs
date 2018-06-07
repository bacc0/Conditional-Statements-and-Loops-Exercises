using System;
using System.Collections.Generic;
using System.Linq;


namespace BombNumbers
{
    class MainClass

    {
        public static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine()
                                    .Split(' ')
                                    .Select(int.Parse)
                                    .ToList();
            
            int[]  input = Console.ReadLine()
                                  .Split(' ')
                                  .Select(int.Parse)
                                  .ToArray();

            int bomb  = input[0];
            int range = input[1];

            int bombIndex = nums.IndexOf(bomb);

            while (bombIndex != -1)
            {
                int left  = bombIndex - range;
                int right = bombIndex + range;

                if (left < 0)
                {
                    left = 0;
                }
                if (right > nums.Count - 1)
                {
                    right = nums.Count - 1;
                }

                int count = right - left + 1; 
                nums.RemoveRange(left, count);
                bombIndex = nums.IndexOf(bomb);
            }
            
            int sum = 0;
            
            foreach (var num in nums)
            {
                sum += num;
            }
            Console.WriteLine(sum);
        }
    }
}
