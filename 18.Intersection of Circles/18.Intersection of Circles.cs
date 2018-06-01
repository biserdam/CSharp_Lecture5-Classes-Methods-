using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18.Intersection_of_Circles
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputCircle1 = Console.ReadLine().Split(' ');
            var inputCircle2 = Console.ReadLine().Split(' ');

            Circle circle1 = new Circle();
            circle1.center = Point.GetPoint(inputCircle1);
            circle1.radius = Circle.GetRadius(inputCircle1);

            Circle circle2 = new Circle();
            circle2.center = Point.GetPoint(inputCircle2);
            circle2.radius = Circle.GetRadius(inputCircle2);

            if (Intersect(circle1, circle2)) Console.WriteLine("Yes");
            else Console.WriteLine("No");
        }

        static bool Intersect(Circle c1, Circle c2)
        {
            if (c1.radius + c2.radius >= Point.CalculateDistance(c1.center, c2.center)) return true;
            else return false;
        }

    }

    public class Point
    {
        public int x;
        public int y;

        public static Point GetPoint(string[] inputString)
        {
            var pointInfo = inputString.Select(int.Parse).ToArray();
            var point = new Point();
            point.x = pointInfo[0];
            point.y = pointInfo[1];
            return point;
        }

        public static double CalculateDistance(Point a, Point b)
        {
            var sideA = Math.Abs(a.x - b.x);
            var sideB = Math.Abs(a.y - b.y);
            double distance = Math.Round(Math.Sqrt(Math.Pow(sideA, 2) + Math.Pow(sideB, 2)), 3);
            return distance;
        }
    }

    public class Circle
    {
        public Point center;
        public double radius;

        public static double GetRadius(string[] inputString)
        {
            var circleInfo = inputString.Select(int.Parse).ToArray();
            return circleInfo[2];
        }
    }

}
