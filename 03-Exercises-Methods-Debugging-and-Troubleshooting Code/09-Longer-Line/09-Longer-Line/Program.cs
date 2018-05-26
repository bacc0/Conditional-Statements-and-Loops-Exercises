using System;

namespace LongerLine
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            double maxDistance = double.MinValue;

            double maxX1 = 0.0;
            double maxY1 = 0.0;
            double maxX2 = 0.0;
            double maxY2 = 0.0;

            for (int i = 0; i < 2; i++)
            {
                double x1 = double.Parse(Console.ReadLine());
                double y1 = double.Parse(Console.ReadLine());
                double x2 = double.Parse(Console.ReadLine());
                double y2 = double.Parse(Console.ReadLine());

                double curentDistance = CalculateDistance( x1, x2, 
                                                           y1, y2 );

                if (curentDistance >  maxDistance)
                {
                    maxDistance = curentDistance;

                    maxX1 = x1;
                    maxY1 = y1;
                    maxX2 = x2;
                    maxY2 = y2;
                }
            }

            PrintCartesianPoint(maxX1, maxY1, maxX2, maxY2);
        }


        static double CalculateDistance( double x1, 
                                         double y1, 
                                         double x2, 
                                         double y2 )
        {
            double distnce = Math.Sqrt((x1 - x2) * (x1 - x2)
                                     + (y1 - y2) * (y1 - y2));
            return distnce;
        }


        static void PrintCartesianPoint(double x1,
                                        double y1,
                                        double x2,
                                        double y2)
        {
            double firstPosition = Math.Sqrt(x1 * x1 + y1 * y1);
            double secondPosition = Math.Sqrt(x2 * x2 + y2 * y2);

            if (firstPosition <= secondPosition)
            {
                Console.WriteLine($"({x1}, {y1})({x2}, {y2})");
            }
            else
            {
                Console.WriteLine($"({x2}, {y2})({x1}, {y1})");
            }
        }
    }
}
