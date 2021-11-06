using System;
using System.Collections.Generic;
using System.Linq;

namespace Lambda1
{
    class Class22
    {
        public static void Main()
        {
            IEnumerable<string> strings =Enumerable.Repeat("Hello", 15);

            foreach (String str in strings)
            {
                Console.WriteLine(str);
            }
        }
    }
}
