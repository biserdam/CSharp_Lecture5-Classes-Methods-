using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Prime_Checker
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = Math.Abs(long.Parse(Console.ReadLine()));
            Console.WriteLine(IsPrime(n));
        }

        static bool IsPrime(long n)
        {
            bool result = true;
            if (n == 0 || n == 1) result = false;
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0) result = false;
            }
            return result;
        }
    }
}
