using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Max_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = int.Parse(Console.ReadLine());
            var b = int.Parse(Console.ReadLine());
            var c = int.Parse(Console.ReadLine());

            var max = GetMax(a, b);
            max = GetMax(max, c);

            Console.WriteLine(max);
        }

        static int GetMax(int a, int b)
        {
            int max;
            if (a > b) max = a;
            else max = b;
            return max;
        }
    }
}
