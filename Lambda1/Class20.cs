using System;
using System.Collections.Generic;
using System.Linq;

namespace Lambda1
{
    class Class20
    {
        public static void Main()
        {
            // Creating a list of numbers
            List<int> numbers = new List<int> { 1, 2, 3, 4 };

            // Trying to prepend any value of the same type
            numbers.Prepend(0);

            // It doesn't work because the original list has not been changed
            Console.WriteLine(string.Join(", ", numbers));

            // It works now because we are using a changed copy of the original list
            Console.WriteLine(string.Join(", ", numbers.Prepend(0)));

            // If you prefer, you can create a new list explicitly
            List<int> newNumbers = numbers.Prepend(0).ToList();

            // And then write to the console output
            Console.WriteLine(string.Join(", ", newNumbers));
        }
    }
}
