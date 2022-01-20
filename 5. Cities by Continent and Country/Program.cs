using System;
using System.Collections.Generic;

namespace _5._Cities_by_Continent_and_Country
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, Dictionary<String, List<string>>> countries = new Dictionary<string, Dictionary<string, List<string>>>();
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();
                string kontinent = input[0];
                string country = input[1];
                string city = input[2];
                if (!countries.ContainsKey(kontinent))
                {
                    countries[kontinent] = new Dictionary<string, List<string>>();
                }
                if (!countries[kontinent].ContainsKey(country))
                {
                    countries[kontinent][country] = new List<string>();
                }
                countries[kontinent][country].Add(city);
            }
            foreach (var kontinent in countries)
            {
                Console.WriteLine($"{kontinent.Key}:");
                foreach (var country in kontinent.Value)
                {
                    Console.Write($"  {country.Key} -> ");
                    for (int i = 0; i < country.Value.Count; i++)
                    {
                        if (i == country.Value.Count - 1)
                        {
                            Console.Write($"{country.Value[i]}");
                        }
                        else
                        {
                            Console.Write($"{country.Value[i]}, ");
                        }
                    }
                    Console.WriteLine();
                }
            }

        }
    }
    
}
