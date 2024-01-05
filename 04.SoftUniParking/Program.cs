using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.SoftUniParking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> parkingList = new Dictionary<string, string>();

          int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                List<string> input = Console.ReadLine().Split().ToList();
                string name = string.Empty;
                string carNumber = string.Empty;

                string command = input[0];

                if (command == "register")
                {
                    name = input[1];
                    carNumber = input[2];
                    
                    if (!parkingList.ContainsKey(name))
                    {
                        parkingList[name] = carNumber;
                        Console.WriteLine($"{name} registered {carNumber} successfully");
                        continue;
                    }

                    Console.WriteLine($"ERROR: already registered with plate number {carNumber}");


                }
                else if (command == "unregister")
                {
                    name = input[1];

                    if (!parkingList.ContainsKey(name))
                    {
                        Console.WriteLine($"ERROR: user {name} not found");
                        continue;
                    }
                    parkingList.Remove(name);
                    Console.WriteLine($"{name} unregistered successfully");

                }


            }
                foreach (var i in parkingList)
                {
                Console.WriteLine($"{i.Key} => {i.Value}");
            }
        }
    }
}
