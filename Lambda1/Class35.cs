using System;
using System.Collections.Generic;
using System.Linq;

namespace Lambda1
{
    public class CaseInsensitiveComparer : IComparer<string>
    {
        public int Compare(string x, string y)
        {
            return string.Compare(x, y, true);
        }
    }
    class Class35
    {
        public static void ThenByDescendingEx1()
        {
            string[] fruits = { "apPLe", "baNanA", "apple", "APple", "orange", "BAnana", "ORANGE", "apPLE" };

            // Sort the strings first ascending by their length and
            // then descending using a custom case insensitive comparer.
            IEnumerable<string> query =
                fruits
                .OrderBy(fruit => fruit.Length)
                .ThenByDescending(fruit => fruit, new CaseInsensitiveComparer());

            foreach (string fruit in query)
            {
                Console.WriteLine(fruit);
            }
        }
    }
}
