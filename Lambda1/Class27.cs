using System;
using System.Collections.Generic;
using System.Linq;

namespace Lambda1
{
    class Class27
    {
        public static void Main()
        {
            string[] fruits = { "apple", "banana", "mango",
                      "orange", "passionfruit", "grape" };

            string fruit1 = fruits.Single(fruit => fruit.Length > 10);

            Console.WriteLine(fruit1);
        }
    }
}
