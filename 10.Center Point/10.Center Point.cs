using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Center_Point
{
    class Program
    {
        static void Main(string[] args)
        {
            var point1 = ReadPoint();
            var point2 = ReadPoint();

            var distance1 = GetDistanceToCenter(point1);
            var distance2 = GetDistanceToCenter(point2);

            if (distance1<=distance2) Console.WriteLine($"({point1[0]}, {point1[1]})");
            else Console.WriteLine($"({point2[0]}, {point2[1]})");
        }

        static double[] ReadPoint()
        {
            var a = double.Parse(Console.ReadLine());
            var b = double.Parse(Console.ReadLine());
            var point= new double[] { a, b };
            return point;
        }

        static double GetDistanceToCenter(double[] point)
        {
            return Math.Sqrt(Math.Pow(point[0], 2) + Math.Pow(point[1], 2));
        }
    }
}
