using System;
using System.Collections.Generic;
using System.Linq;

namespace Lambda1
{
    class Class39
    {
        public static void Main()
        {
            string[] fruits = { "apple", "passionfruit", "banana", "mango",
                      "orange", "blueberry", "grape", "strawberry" };

            List<int> lengths = fruits.Select(fruit => fruit.Length).ToList();

            foreach (int length in lengths)
            {
                Console.WriteLine(length);
            }
        }
    }
}
