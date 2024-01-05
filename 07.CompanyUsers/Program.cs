using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.CompanyUsers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> list = new Dictionary<string, List<string>>();

            while (true)
            {
                List<string> input = Console.ReadLine().Split(" -> ").ToList();

                if (input[0] == "End") break;

                if (!list.ContainsKey(input[0]))
                {
                    list[input[0]] = new List<string>();
                    list[input[0]].Add(input[1]);
                    continue;
                }

                if (list[input[0]].Any(x => x == input[1])) continue;

                list[input[0]].Add(input[1]);
            }
            foreach (var i in list)
            {
                Console.WriteLine($"{i.Key}");
                foreach (var k in i.Value)
                {
                    Console.WriteLine($"-- {k}");
                }
            }
        }
    }
}
