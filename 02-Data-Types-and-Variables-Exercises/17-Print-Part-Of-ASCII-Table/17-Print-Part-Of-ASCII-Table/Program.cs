using System;

namespace PrintPartOfASCIITable
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var numberA = int.Parse(Console.ReadLine());
            var numberB= int.Parse(Console.ReadLine());

            var charA = Convert.ToChar(numberA);
            var charB = Convert.ToChar(numberB);

            for (char i = charA; i <= charB; i++)
            {
                Console.Write(i +" ");
            }
        }
    }
}
