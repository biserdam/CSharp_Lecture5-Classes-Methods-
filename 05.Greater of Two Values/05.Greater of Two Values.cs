using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Greater_of_Two_Values
{
    class Program
    {
        static void Main(string[] args)
        {
            var type = Console.ReadLine();
            if (type == "int")
            {
                var a = int.Parse(Console.ReadLine());
                var b = int.Parse(Console.ReadLine());
                Console.WriteLine(GetMax(a, b));
            }

            else if (type == "char")
            {
                var a = char.Parse(Console.ReadLine());
                var b = char.Parse(Console.ReadLine());
                Console.WriteLine(GetMax(a,b));
            }

            else if (type == "string")
            {
                var a = Console.ReadLine();
                var b =Console.ReadLine();
                Console.WriteLine(GetMax(a,b));
            }

        }

        static int GetMax(int a, int b)
        {
            if (a >= b) return a;
            else return b;
        }

        static char GetMax(char a, char b)
        {
            if (a >= b) return a;
            else return b;
        }

        static string GetMax(string a, string b)
        {
            if (a.CompareTo(b) >= 0) return a;
            else return b;
        }
    }
}
