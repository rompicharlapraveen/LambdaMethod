using System;
using System.Collections.Generic;
using System.Linq;

namespace Lambda1
{
    class Class28
    {
        public static void Main()
        {
            /*
            string[] fruits1 = { "orange" };

            string fruit1 = fruits1.SingleOrDefault();

            Console.WriteLine(fruit1);
            */

            string[] fruits = { "apple", "banana", "mango",
                      "orange", "passionfruit", "grape" };

            string fruit1 = fruits.SingleOrDefault(fruit => fruit.Length > 10);

            Console.WriteLine(fruit1);

        }
    }
}
