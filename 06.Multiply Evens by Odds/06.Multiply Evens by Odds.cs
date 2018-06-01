using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Multiply_Evens_by_Odds
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = Math.Abs(int.Parse(Console.ReadLine()));

            Console.WriteLine(GetMultipleOfEvensAndOdds(n));
        }

        static int GetMultipleOfEvensAndOdds(int n)
        {
            return GetSumOfEven(n) * GetSumOfOdds(n);
        }

        static int GetSumOfEven(int n)
        {
            var sum = 0;
            while (n > 0)
            {
                var lastDigit = n % 10;
                if (lastDigit % 2 == 0)
                {
                    sum += lastDigit;
                }
                n = n / 10;
            }
            return sum;
        }

        static int GetSumOfOdds(int n)
        {
            var sum = 0;
            while (n > 0)
            {
                var lastDigit = n % 10;
                if (lastDigit % 2 != 0)
                {
                    sum += lastDigit;
                }
                n = n / 10;
            }
            return sum;
        }
    }
}
