using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.Courses
{
    internal class Program
    {
        static void Main(string[] args)
        {
         Dictionary<string, List<string>> list = new Dictionary<string, List<string>>();

            while (true)
            {
                List<string> input = Console.ReadLine().Split(" : ").ToList();

                if (input[0] == "end") break; 

                string course = input[0];
                string name = input[1];

                if (!list.ContainsKey(course))
                {
                    list[course] = new List<string>();
                    list[course].Add(name);
                    continue;
                }
                list[course].Add(name);

            }
            foreach (var i in list)
            {
                Console.WriteLine($"{i.Key}: {i.Value.Count}");
                foreach (var k in i.Value)
                {
                    Console.WriteLine($"-- {k}");
                }
            }




        }
    }
}
