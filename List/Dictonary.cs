using System;
using System.Collections.Generic;

namespace ConsoleApp1.List
{
    public class Dictonary
    {
        static void Main()
        {
            var array = new[] { "A", "B", "A", "AB", "AB", "BB", "A" };
            var dictionary = new Dictionary<string, int>();

            foreach (var str in array)
                {
                if (!dictionary.ContainsKey(str))
                    dictionary[str] = 1;
                else
                    dictionary[str] = dictionary[str] + 1;
            }

            foreach (var pair in dictionary)
            {
                Console.WriteLine("{0}: {1}", pair.Key, pair.Value);
            }
        }
    }
}
