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
            int count    = 1;
            int countMax = 0;
            int position = 0;

            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i] < arr[i + 1])
                {
                    count++;
                    if (count > countMax)
                    {
                        countMax = count;
                        position = i + 1;
                    }
                }
                else
                {
                    count = 1;
                }
            }
                int[] result = new int[countMax];

                for (int i = 0; i < result.Length; i++)
                {
                    result[i] = arr[position - countMax + 1 + i];
                }
                Console.WriteLine(string.Join(" ", result));
        }
    }
}
