using System;
using System.Collections.Generic;

namespace Dictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> items = new Dictionary<int, string>();
            items.Add(01, "sword");
            items.Add(04, "axe");
            items.Add(12, "food");

            Console.WriteLine(items[1]);
            foreach (var item in items)
                Console.WriteLine(item);

            //Count
            Console.WriteLine(items.Count);

            //Contains
            Console.WriteLine(items.ContainsValue("food"));
            Console.WriteLine(items.ContainsKey(5));

            //Remove
            items.Remove(12);
            foreach (var item in items)
                Console.WriteLine(item);

            //Keys-Values
            foreach (var item in items.Keys)
                Console.WriteLine(item);

            foreach (var item in items.Values)
                Console.WriteLine(item);

        }
    }
}
