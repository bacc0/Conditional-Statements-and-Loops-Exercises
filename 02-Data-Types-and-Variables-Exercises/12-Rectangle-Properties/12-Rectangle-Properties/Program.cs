using System;

namespace RectangleProperties
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var a = double.Parse(Console.ReadLine());
            var b = double.Parse(Console.ReadLine());

            var perimeter = a * 2 + b * 2;
            var area      = a * b;
            var diagonal  = Math.Sqrt(a * a + b * b);

            Console.WriteLine(perimeter);
            Console.WriteLine(area);
            Console.WriteLine(diagonal);
        }
    }
}
