using System;
using System.Linq;

namespace _3._Largest_3_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] sorted = numbers.OrderByDescending(x => x).ToArray();
            int count = sorted.Length >= 3 ? 3 : sorted.Length;
            for (int i = 0; i < count; i++)
                Console.Write($"{sorted[i]} ");


        }
    }
}
