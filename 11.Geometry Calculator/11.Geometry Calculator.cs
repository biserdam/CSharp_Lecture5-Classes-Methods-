using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Geometry_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            var figureType = Console.ReadLine().ToLower();
            double area=0;

            if (figureType=="triangle")
            {
                var side = double.Parse(Console.ReadLine());
                var height = double.Parse(Console.ReadLine());
                area = CalculateTriangleArea(side, height);
            }
            else if (figureType=="square")
            {
                var side = double.Parse(Console.ReadLine());
                area = CalculateSquareArea(side);
            }
            else if (figureType == "rectangle")
            {
                var width = double.Parse(Console.ReadLine());
                var height = double.Parse(Console.ReadLine());
                area = CalculateRectangleArea(width, height);
            }
            else if (figureType == "circle")
            {
                var radius = double.Parse(Console.ReadLine());
                area = CalculateCircleArea(radius);
            }

        Console.WriteLine($"{area:f2}");
        }


        static double CalculateTriangleArea(double s, double h)
        {
            return s * h / 2;
        }

        static double CalculateSquareArea(double s)
        {
            return s*s;
        }

        static double CalculateRectangleArea(double w, double h)
        {
            return w * h;
        }

        static double CalculateCircleArea(double r)
        {
            return Math.PI*r*r;
        }

    }
}
