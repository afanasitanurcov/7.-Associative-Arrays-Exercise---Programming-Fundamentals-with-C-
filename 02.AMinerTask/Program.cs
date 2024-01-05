using System;
using System.Collections.Generic;

namespace _02.AMinerTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, double> resources = new Dictionary<string, double>();

            while (true)
            {
                string inputResourse = Console.ReadLine();

                if (inputResourse == "stop") break;

                double quantity = double.Parse(Console.ReadLine());

                if (resources.ContainsKey(inputResourse))
                {
                    resources[inputResourse] += quantity;
                    continue;
                }

                resources[inputResourse] = quantity;
            }
            foreach (var i in resources)
            {
                Console.WriteLine($"{i.Key} -> {i.Value}");
            }
        }
    }
}
