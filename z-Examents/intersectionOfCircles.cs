using System;
using System.Linq;



class Point
{
    public int X { get; set; }
    public int Y { get; set; }
    
    public Point( int x, int y)
    {
        X = x;
        Y = y;
    }

    public static int calculateDistance(Point p1, Point p2)
    {
        return (int)Math.Sqrt(Math.Pow(p2.X - p1.X, 2) + Math.Pow(p2.Y - p1.Y, 2));
    }
}


class Circle
{
    public int Radius { get; set; }
    public Point Center { get; set; }

    public Circle(Point center, int radius)
    {
        Center = center;
        Radius = radius;
    }

    public static bool Intersect( Circle c1, Circle c2)
    {
        int d = Point.calculateDistance(c1.Center, c2.Center);

        if (d <= c1.Radius + c2.Radius)
        {
            return true;
        }
        return false;
    }
}

public class Example
{
    public static void Main()
    {
        int[] firstCircle  = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int[] secondCircle = Console.ReadLine().Split().Select(int.Parse).ToArray();

        Point firstPoint  = new Point(firstCircle[0],  firstCircle[1]);
        Point secondPoint = new Point(secondCircle[0], secondCircle[1]);

        Circle circleOne  = new Circle(firstPoint, firstCircle[2]);
        Circle circleTwo = new Circle(secondPoint, secondCircle[2]);

        if (Circle.Intersect(circleOne, circleTwo))
        {
            Console.WriteLine("Yes");
        }
        else
        {
            Console.WriteLine("No");
        }
    }
}
