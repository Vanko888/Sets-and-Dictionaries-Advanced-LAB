using System;
using System.Collections.Generic;

namespace _7._Parking_Lot
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> carPlates = new HashSet<string>();
            string command = Console.ReadLine();
            while (command != "END")
            {
                string[] input = command.Split(", ");
                string currCommand = input[0];
                string number = input[1];
                if (currCommand == "IN")
                {
                    carPlates.Add(number);
                }
                else
                {
                    carPlates.Remove(number);
                }
                command = Console.ReadLine();
            }
            if (carPlates.Count > 0)
            {
                foreach (var item in carPlates)
                {
                    Console.WriteLine(item);
                }
            }
            else
            {
                Console.WriteLine("Parking Lot is Empty");
            }
        }
    }
}
