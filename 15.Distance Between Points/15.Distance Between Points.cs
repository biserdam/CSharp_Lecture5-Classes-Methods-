using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.Distance_Between_Points
{
    class Program
    {
        static void Main(string[] args)
        {
            Point point1 = GetPoint();
            Point point2 = GetPoint();

            Console.WriteLine(CalculateDistance(point1, point2));
        }

        static Point GetPoint()
        {
            var pointInfo = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var point = new Point();
            point.x = pointInfo[0];
            point.y = pointInfo[1];
            return point;
        }

        static double CalculateDistance(Point a, Point b)
        {
            var sideA = Math.Abs(a.x - b.x);
            var sideB = Math.Abs(a.y - b.y);
            double distance = Math.Round(Math.Sqrt(Math.Pow(sideA,2) + Math.Pow(sideB,2)),3);
            return distance;
        }
    }

    public class Point
    {
        public int x;
        public int y;
    }
}
