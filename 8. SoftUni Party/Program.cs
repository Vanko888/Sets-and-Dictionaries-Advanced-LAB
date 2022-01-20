using System;
using System.Collections.Generic;

namespace _8._SoftUni_Party
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            HashSet<string> VIP = new HashSet<string>();
            HashSet<string> regular = new HashSet<string>();
            while (command != "PARTY")
            {
                char[] currCommand = command.ToCharArray();
                char check = currCommand[0];
                if (char.IsDigit(check))
                {
                    VIP.Add(command);
                }
                else
                {
                    regular.Add(command);
                }

                command = Console.ReadLine();
            }
            command = Console.ReadLine();
            while (command != "END")
            {
                char[] currCommand = command.ToCharArray();
                char check = currCommand[0];
                if (char.IsDigit(check))
                {
                    VIP.Remove(command);
                }
                else
                {
                    regular.Remove(command);
                }
                command = Console.ReadLine();
            }
            Console.WriteLine(VIP.Count+regular.Count);
            foreach (var item in VIP)
            {
                Console.WriteLine(item);
            }
            foreach (var item in regular)
            {
                Console.WriteLine(item);
            }
        }
    }
}
