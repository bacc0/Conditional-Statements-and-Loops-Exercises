using System;

namespace test1
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string[] arrOne = Console.ReadLine().Split();
            string[] arrTwo = Console.ReadLine().Split();

            var countLeft  = 0;
            var countRight = 0;
            int avarage = Math.Min(arrOne.Length, arrTwo.Length);

            countLeft = ReturnCount(avarage, countLeft, arrOne, arrTwo);

            Array.Reverse(arrOne);
            Array.Reverse(arrTwo);

            countRight = ReturnCount(avarage, countRight, arrOne, arrTwo);

            Console.WriteLine(Math.Max(countLeft, countRight));
        }

        static int ReturnCount(int avarage, int count , string[] arrOne, string[] arrTwo)
        {
            for (int i = 0; i < avarage; i++)
            {
                if (arrOne[i] == arrTwo[i])
                {
                    count++;
                }
            }
            return count;
        }
    }
}
