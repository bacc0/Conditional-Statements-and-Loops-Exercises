using System;

namespace MaxMethod
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int firstNum  = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            int thirdNum  = int.Parse(Console.ReadLine());

            int result = GetMaxNumber(firstNum, GetMaxNumber(secondNum, thirdNum));

            Console.WriteLine(result);

        }
        static int GetMaxNumber(int firstNum, int secondNum)
        {
            if (firstNum > secondNum)
            {
                return firstNum;
            }
            return secondNum;
        }
    }
}
