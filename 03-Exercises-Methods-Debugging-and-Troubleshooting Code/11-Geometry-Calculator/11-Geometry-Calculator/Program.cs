using System;

namespace GeometryCalculator
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string typeOfFigure = Console.ReadLine();
            double sideWidthRadius = double.Parse(Console.ReadLine());
            double height = 0.0;

            if (typeOfFigure == "triangle" || typeOfFigure == "rectangle")
            {
                 height = double.Parse(Console.ReadLine());
            }

            double area = 0.0;

            switch (typeOfFigure)
            {
                case "triangle":
                    area = retrnAreaTriangle(sideWidthRadius,
                                             height);
                    break;
                case "square":
                    area = retrnAreaSquare(sideWidthRadius);
                    break;
                case "rectangle":
                    area = retrnAreaRectangle(sideWidthRadius,
                                             height);
                    break;
                default:
                    area = retrnAreaCircle(sideWidthRadius);
                    break;
            }
            Console.WriteLine($"{area:f2}");
        }

        static double retrnAreaTriangle(double sideWidthRadius, 
                                        double height)
        {
            double area = sideWidthRadius * height / 2;
            return area;
        }

        static double retrnAreaSquare(double sideWidthRadius)
        {
            double area = sideWidthRadius * sideWidthRadius;
            return area;
        }

        static double retrnAreaRectangle(double sideWidthRadius,
                                        double height)
        {
            double area = sideWidthRadius * height;
            return area;
        }

        static double retrnAreaCircle(double sideWidthRadius)
        {
            double area = Math.PI * sideWidthRadius * sideWidthRadius;
            return area;
        }
    }
}
