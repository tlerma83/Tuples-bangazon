using System;
using System.Collections.Generic;

namespace tuples
{
    class Program
    {
        static void Main(string[] args)
        {
            List<(string product, double amount, int quantity)> transactions = new List<(string, double, int)>();

            transactions.Add(("things", 15.99, 5));
            transactions.Add(("cake", 5.89, 3));
            transactions.Add(("sweaters", 49.50, 17));
            transactions.Add(("coffee", 85.99, 200));
            transactions.Add(("more things", 10.99, 15));

            double quantity = 0;
            double amount = 0;
            
            foreach ((string product, double amount, int quantity) item in transactions)
            {
                Console.WriteLine($"Stuff: {item.product} {item.amount} {item.quantity}");
                quantity += item.quantity;
                amount += item.amount;
                // totalQuantity = quantity + "{1}";
            }
                Console.WriteLine($"Items sold today: {quantity}");
                Console.WriteLine($"Total Revenue: ${amount}");
        }
    }
}
