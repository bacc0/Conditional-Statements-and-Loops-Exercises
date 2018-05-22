using System;

namespace ReverseCharacters
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            char[] array = new char[3];

            for (int i = 0; i < 3; i++)
            {
                array[i] = char.Parse(Console.ReadLine());
            }
            Array.Reverse(array);
            Console.WriteLine(array);
        }
    }
}
