using System;
using System.Collections.Generic;
using System.Linq;

namespace Lambda1
{
	public class Class34
	{
		public static void Main()
		{
            string[] fruits = { "grape", "passionfruit", "banana", "mango","orange"};

            // Sort the strings first by their length and then
            //alphabetically by passing the identity selector function.
            IEnumerable<string> query =
                fruits.OrderBy(fruit => fruit.Length).ThenBy(fruit => fruit);

            foreach (string fruit in query)
            {
                Console.WriteLine(fruit);
            }
        }
    }
}
