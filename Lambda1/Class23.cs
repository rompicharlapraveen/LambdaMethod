using System;
using System.Collections.Generic;
using System.Linq;

namespace Lambda1
{
    class Class23
    {
        public static void Main()
        {
            char[] apple = { 'P', 'r', 'a', 'v', 'e','e','n' };

            char[] reversed = apple.Reverse().ToArray();

            foreach (char chr in reversed)
            {
                Console.Write(chr + " ");
            }
            Console.WriteLine();
        }
    }
}
