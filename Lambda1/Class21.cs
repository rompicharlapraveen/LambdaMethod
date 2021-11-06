using System;
using System.Collections.Generic;
using System.Linq;

namespace Lambda1
{
    class Class21
    {
        public static void Main()
        {
            // Generate a sequence of integers from 1 to 10
            // and then select their squares.
            IEnumerable<int> squares = Enumerable.Range(1, 10).Select(x => x * x);

            foreach (int num in squares)
            {
                Console.WriteLine(num);
            }
        }
    }
}
