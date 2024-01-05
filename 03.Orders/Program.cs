using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<double>> result = new Dictionary<string, List<double>>();
            while (true)
            {
            List<string> input = Console.ReadLine().Split().ToList();

                if (input[0] == "buy") break; 

                string product = input[0];
                double price = double.Parse(input[1]);
                double amount = double.Parse(input[2]);

                if (!result.ContainsKey(product))
                {
                    result[product] = new List<double>();
                    result[product].Add(price);
                    result[product].Add(amount);
                    continue;
                    //result.Add(product, result[product]);
                }

                result[product][0] = price;
                result[product][1] += amount;
            }
            foreach (var i in result)
            {
                Console.WriteLine($"{i.Key} -> {(i.Value[0] * i.Value[1]):f2}");
            }



        }
    }
}
