using System;
using System.Collections.Generic;
using System.Linq;

namespace _1._Count_Same_Values_in_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<double, int> count = new Dictionary<double, int>();
            double[] input = Console.ReadLine().Split().Select(double.Parse).ToArray();
            foreach (var item in input)
            {
                if (count.ContainsKey(item))
                {
                    count[item]++;
                }
                else
                {
                    count[item] = 1; ;
                }
            }
            foreach (var item in count)
            {
                Console.WriteLine($"{item.Key} - {item.Value} times");
            }
        }
    }
}
