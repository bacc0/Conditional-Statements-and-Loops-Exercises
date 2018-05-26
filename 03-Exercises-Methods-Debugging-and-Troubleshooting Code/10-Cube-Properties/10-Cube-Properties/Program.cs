using System;

namespace CubeProperties
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            double side = double.Parse(Console.ReadLine());
            string request = Console.ReadLine();

            double result = 0.0;

            switch (request)
            {
                case "face":
                    result = CalcFace(side);
                    break;
                case "space":
                    result = CalcSpace(side);
                    break;
                case "volume":
                    result = CalcVolume(side);
                    break;
                default:
                    result = CalcAea(side);
                    break;
            }
            Console.WriteLine($"{result:f2}");
        }


        static double CalcFace(double side)
        {
            double result = Math.Sqrt(2 * side * side);
            return result;
        }

        static double CalcSpace(double side)
        {
            double result = Math.Sqrt(3 * side * side);
            return result;
        }

        static double CalcVolume(double side)
        {
            double result = side * side * side;
            return result;
        }

        static double CalcAea(double side)
        {
            double result = 6 * side * side;
            return result;
        }
    }
}
