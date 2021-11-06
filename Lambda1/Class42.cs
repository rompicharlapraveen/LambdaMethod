using System;
using System.Collections.Generic;
using System.Linq;

namespace Lambda1
{
    class Class42
    {
        public static void Main()
        {
            List<string> fruits =
    new List<string> { "apple", "passionfruit", "banana", "mango",
                    "orange", "blueberry", "grape", "strawberry" };

            IEnumerable<string> query = fruits.Where(fruit => fruit.Length < 6);

            foreach (string fruit in query)
            {
                Console.WriteLine(fruit);
            }
        }
    }
}
