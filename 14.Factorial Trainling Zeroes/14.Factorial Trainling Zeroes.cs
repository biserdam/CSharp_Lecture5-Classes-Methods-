using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _13.Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            Console.WriteLine($"{TrailingZeroesCount(Factorial(n))}");
        }

        static BigInteger Factorial(int n)
        {
            BigInteger fact = 1;
            for (int i = 1; i <= n; i++)
            {
                fact *= i;
            }
            return fact;
        }

        static int TrailingZeroesCount(BigInteger num)
        {
            int count = 0;
            while (num%10==0)
            {
                if (num % 10 == 0)
                {
                    count++;
                    num /= 10;
                }
            }
            return count;
        }
    }
}
