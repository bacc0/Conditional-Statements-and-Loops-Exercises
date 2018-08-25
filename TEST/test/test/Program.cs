using System;
using System.Linq;


namespace test
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
                                .Split(' ')
                                .Select(int.Parse)
                                .ToArray();

            var numbersoOfRotations = int.Parse(Console.ReadLine());

            var sum = new int[numbers.Length];

            var rotated = new int[numbers.Length];



            for (int i = 0; i < numbersoOfRotations; i++) 
            {

                rotated = Rotated(numbers);
                    
                for (int j = 0; j < numbers.Length; j++) 
                {
                    sum[j] += rotated[i];
                }
            }
        }

        private static int[] Rotated(int[] numbers)
        {
            var rotated = new int[numbers.Length];

            for (int i = 1; i < rotated.Length; i++) 
            {
                rotated[i] = numbers[i - 1];
            }

            return rotated;
        }
    }
}
