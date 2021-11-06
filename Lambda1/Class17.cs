using System;
using System.Collections.Generic;
using System.Linq;

namespace Lambda1
{
    class Class17
    {
        public static void Main()
        {
            System.Collections.ArrayList fruits = new System.Collections.ArrayList(4);
            fruits.Add("Mango");
            fruits.Add("Orange");
            fruits.Add("Apple");
            fruits.Add(3.0);
            fruits.Add("Banana");

            // Apply OfType() to the ArrayList.
            IEnumerable<string> query1 = fruits.OfType<string>();

            Console.WriteLine("Elements of type 'string' are:");
            foreach (string fruit in query1)
            {
                Console.WriteLine(fruit);
            }

            // The following query shows that the standard query operators such as
            // Where() can be applied to the ArrayList type after calling OfType().
            IEnumerable<string> query2 =
                fruits.OfType<string>().Where(fruit => fruit.ToLower().Contains("n"));

            Console.WriteLine("\nThe following strings contain 'n':");
            foreach (string fruit in query2)
            {
                Console.WriteLine(fruit);
            }
        }
    }
}
