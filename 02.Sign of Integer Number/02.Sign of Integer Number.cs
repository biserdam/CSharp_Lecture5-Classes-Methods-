using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Sign_of_Integer_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            PrintSign(n);
        }

        static void PrintSign(int x)
        {
            if (x > 0) Console.WriteLine($"The number {x} is positive.");
            else if (x < 0) Console.WriteLine($"The number {x} is negative.");
            else Console.WriteLine($"The number {x} is zero.");
        }
    }
}
