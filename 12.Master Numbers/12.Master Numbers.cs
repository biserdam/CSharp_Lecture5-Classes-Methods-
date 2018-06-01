using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Master_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var endNumber = int.Parse(Console.ReadLine());
            for (int i = 1; i <= endNumber; i++)
            {
                if (IsPalindrome(i) && SumOfDigits7(i) && ContainsEvenDigit(i))
                {
                    Console.WriteLine(i);
                }
            }
        }

        static bool IsPalindrome(int num)
        {
            bool result = true;
            char[] numToChar = num.ToString().ToCharArray();
            for (int i = 0; i < numToChar.Length; i++)
            {
                if (numToChar[i] != numToChar[numToChar.Length - 1 - i]) result = false;
            }
            return result;
        }

        static bool SumOfDigits7(int num)
        {
            bool result = false;
            int sum = 0;
            while (num > 0)
            {
                sum += num % 10;
                num /= 10;
            }
            if (sum % 7 == 0) result = true;
            return result;
        }

        static bool ContainsEvenDigit(int num)
        {
            bool result = false;
            while (num > 0)
            {
                if (num % 2 == 0) result = true;
                num /= 10;
            }
            return result;
        }
    }
}
