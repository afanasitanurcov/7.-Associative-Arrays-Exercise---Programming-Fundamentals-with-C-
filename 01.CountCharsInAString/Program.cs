using System;
using System.Collections.Generic;

namespace _01.CountCharsInAString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            List<char> charList = new List<char>();
            Dictionary<char, int> result = new Dictionary<char, int>();
            charList.AddRange(input);
            charList.RemoveAll(x => x == ' ');

            foreach (char c in charList)
            {
                if (!result.ContainsKey(c))
                {
                    result.Add(c, 0);

                }
                result[c]++;

            }

            foreach (var c in result)
            {
                Console.WriteLine($"{c.Key} -> {c.Value}");
            }
        }
    }
}
