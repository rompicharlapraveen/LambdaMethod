using System;
using System.Collections.Generic;
using System.Linq;

namespace Lambda1
{
    class Class24
    {
        public static void Main()
        {
            string[] fruits = { "apple", "banana", "mango", "orange",
                      "passionfruit", "grape" };

            var query =
                fruits.Select((fruit, index) =>
                                  new { index, str = fruit.Substring(0, index) });

            foreach (var obj in query)
            {
                Console.WriteLine("{0}", obj);
            }
        }
    }
}
