using System;
using System.Collections.Generic;
using System.Linq;

namespace Lambda1
{
    class Class43
    {
        public static void Main()
        {
            int[] numbers = { 1, 2, 3, 4 };
            string[] words = { "one", "two", "three" };

            var numbersAndWords = numbers.Zip(words, (first, second) => first + " " + second);

            foreach (var item in numbersAndWords)
                Console.WriteLine(item);
        }
    }
}
