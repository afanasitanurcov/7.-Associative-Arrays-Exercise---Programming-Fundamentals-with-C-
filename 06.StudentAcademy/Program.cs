using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace _06.StudentAcademy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<double>> list = new Dictionary<string, List<double>>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string name = Console.ReadLine();
                double grade = double.Parse(Console.ReadLine());

                if (!list.ContainsKey(name))
                {
                    list[name] = new List<double>();
                    list[name].Add(grade);
                    continue;

                }

                list[name].Add(grade);


            }
            foreach (var i in list.Where(x => x.Value.Sum() / x.Value.Count >= 4.5))
            {
                Console.WriteLine($"{i.Key} -> {(i.Value.Sum() / i.Value.Count):f2}");
            }
        }
    }
}
