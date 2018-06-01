using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Calculate_Triangle_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            var side = double.Parse(Console.ReadLine());
            var height = double.Parse(Console.ReadLine());
            var area = GetTriangleArea(side, height);
            Console.WriteLine(area);
        }
        static double GetTriangleArea(double a, double b)
        {
            return a * b / 2;
        }
    }
}
