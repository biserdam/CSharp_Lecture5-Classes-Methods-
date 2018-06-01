using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17.Closest_Two_Points
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            Point[] pointsArray = new Point[n];

            for (int i = 0; i < n; i++)
            {
                pointsArray[i] = Point.GetPoint();
            }
            var closestPoint1 = Point.FindClosestPoints(pointsArray)[0];
            var closestPoint2 = Point.FindClosestPoints(pointsArray)[1];
            Console.WriteLine($"{Point.CalculateDistance(closestPoint1, closestPoint2):f3}");
            Console.WriteLine($"({closestPoint1.x}, {closestPoint1.y})");
            Console.WriteLine($"({closestPoint2.x}, {closestPoint2.y})");
        }
    }

    public class Point
    {
        public int x;
        public int y;

        public static Point GetPoint()
        {
            var pointInfo = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
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

        public static Point[] FindClosestPoints(Point[] points)
        {
            var globalDistance = CalculateDistance(points[0], points[1]);
            Point[] ClosestTwoPoints = new Point[2] { points[0], points[1] };

            for (int i = 0; i < points.Length; i++)
            {
                for (int j = i + 1; j < points.Length; j++)
                {
                    var distance = CalculateDistance(points[i], points[j]);
                    if (distance < globalDistance)
                    {
                        globalDistance = distance;
                        ClosestTwoPoints[0] = points[i];
                        ClosestTwoPoints[1] = points[j];
                    }
                }
            }

            return ClosestTwoPoints;
        }
    }
}
