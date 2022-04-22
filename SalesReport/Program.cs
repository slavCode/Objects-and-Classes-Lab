using System;
using System.Collections.Generic;
using System.Linq;

namespace SalesReport
{
    internal class Program
    {
        static void Main()
        {
            var sales = ReadSales();

            PrintSales(sales);
        }

        private static void PrintSales(List<Sale> sales)
        {
            foreach (var sale in sales.OrderBy(s => s.Town).GroupBy(s => s.Town))
            {
                Console.WriteLine($"{sale.Key} -> {Math.Round(sale.Sum(t => t.Sales), 2)}");
            }
        }

        static List<Sale> ReadSales()
        {
            var n = int.Parse(Console.ReadLine());
            var sales = new List<Sale>();
            for (int i = 0; i < n; i++)
            {
                var sale = new Sale();
                var parts = Console.ReadLine().Split().ToArray();

                sale.Town = parts[0];
                sale.Product = parts[1];
                sale.Price = decimal.Parse(parts[2]);
                sale.Quantity = decimal.Parse(parts[3]);

                sales.Add(sale);
            }
            return sales;
        }
    }
    class Sale
    {
        public decimal Quantity { get; set; }
        public decimal Price { get; set; }
        public string Town { get; set; }
        public string Product { get; set; }
        public decimal Sales
        {
            get
            {
                return Price * Quantity;
            }
        }
    }
}
