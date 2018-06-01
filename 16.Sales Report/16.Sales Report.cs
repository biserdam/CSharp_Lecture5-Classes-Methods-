using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.Sales_Report
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var salesTownStats = new SortedDictionary<string, double>();

            for (int i = 0; i < n; i++)
            {
                Sale sale = Sale.ReadSale();
       
                if (!salesTownStats.Keys.Contains(sale.town))
                {
                    salesTownStats.Add(sale.town, sale.value);
                }
                else
                {
                    salesTownStats[sale.town] += sale.value;
                }
            }
            foreach (var town in salesTownStats)
            {
            Console.WriteLine($"{town.Key} -> {town.Value:f2}");
            }
        }
    }
    public class Sale
    {
        public string town;
        public string product;
        public double price;
        public double quantity;
        public double value;
        
        public static Sale ReadSale()
        {
            var sale = new Sale();
            var input = Console.ReadLine().Split(' ');
            sale.town = input[0];
            sale.product = input[1];
            sale.price = double.Parse(input[2]);
            sale.quantity = double.Parse(input[3]);
            sale.value = sale.price * sale.quantity;
            return sale;
        }
    }
}
