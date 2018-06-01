using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Primes_in_Given_Range
{
    class Program
    {
        static void Main(string[] args)
        {
            var start = int.Parse(Console.ReadLine());
            var end = int.Parse(Console.ReadLine());

            Console.WriteLine(string.Join(", ", GetPrimesInRange(start, end)));
        }

        static List<int> GetPrimesInRange(int start, int end)
        {
            var resultList = new List<int>();
            for (int i = start; i <= end; i++)
            {
                bool result = true;
                if (i == 0 || i == 1) result = false;
                else
                {
                    for (int j = 2; j <= Math.Sqrt(i); j++)
                    {
                        if (i % j == 0) result = false;
                    }
                    if (result) resultList.Add(i);
                }
            }
            return resultList;
        }
    }
}
