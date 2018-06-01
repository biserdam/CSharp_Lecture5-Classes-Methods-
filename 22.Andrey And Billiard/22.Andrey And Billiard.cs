using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22.Andrey_And_Billiard
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, double> goodsList = GetItemsList();

            List<Client> clientsList = new List<Client>();
            string orderString = null;
            while (orderString != "end of clients")
            {
                orderString = Console.ReadLine();
                if (orderString == "end of clients") break;
                var order = orderString.Split(new char[] { '-', ',' });
                clientsList.Add(new Client(order[0], order[1], int.Parse(order[2])));
            }

            List<Client> sortedClientsList = clientsList.OrderBy(n => n.name).ToList();

            foreach (var client in sortedClientsList)
            {
                if (goodsList.ContainsKey(client.item))
                {
                    client.bill = client.quantity * goodsList[client.item];
                    Console.WriteLine(client.name);
                    Console.WriteLine($"-- {client.item} - {client.quantity}");
                    Console.WriteLine($"Bill: {client.bill:f2}");
                }
            }
            var totalBill = sortedClientsList.Sum(b => b.bill);
            Console.WriteLine($"Total bill: {totalBill:f2}");
        }

        static Dictionary<string, double> GetItemsList()
        {
            var n = int.Parse(Console.ReadLine());
            var itemsList = new Dictionary<string, double>();
            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split('-');
                if (!itemsList.Keys.Contains(input[0])) itemsList.Add(input[0], double.Parse(input[1]));
                else
                {
                    itemsList.Remove(input[0]);
                    itemsList.Add(input[0], double.Parse(input[1]));
                }
            }
            return itemsList;
        }
    }
}

public class Client
{
    public string name;
    public string item;
    public int quantity;
    public double bill;

    public double CalculateBill(int q, double p)
    {
        return q * p;
    }

    public Client(string n, string i, int q)
    {
        name = n;
        item = i;
        quantity = q;
    }

    public override string ToString()
    {
        return $"{name}, {item}, {quantity}, {bill}".ToString();
    }
}
