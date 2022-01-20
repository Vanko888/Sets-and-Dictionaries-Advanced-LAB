using System;
using System.Collections.Generic;
using System.Linq;

namespace _4._Product_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            Dictionary<string, Dictionary<string, double>> shops = new Dictionary<string, Dictionary<string, double>>();
            while (command != "Revision")
            {
                string[] currShop = command.Split(", ");
                if (shops.ContainsKey(currShop[0]))
                {

                    shops[currShop[0]].Add(currShop[1], double.Parse(currShop[2]));
                }
                else
                {
                    shops[currShop[0]] = new Dictionary<string, double>();
                    shops[currShop[0]].Add(currShop[1], double.Parse(currShop[2]));
                }

                command = Console.ReadLine();
            }
            var newShops = shops.OrderBy(s => s.Key).ToDictionary(x => x.Key, x => x.Value);
            foreach (var item in newShops)
            {
                Console.WriteLine($"{item.Key}->");
                foreach (var product in item.Value)
                {
                    Console.WriteLine($"Product: {product.Key}, Price: {product.Value}");
                }
            }
        }
    }
}
