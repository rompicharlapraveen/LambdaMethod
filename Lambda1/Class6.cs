using System;
using System.Collections.Generic;
using System.Linq;

namespace Lambda1
{
    class Class6
    {
        public static void Main()
        {
            /*
            int[] numbers = { };
            int first = numbers.FirstOrDefault();
            Console.WriteLine(first);
            */

            string[] names = { "Hartono, Tommy", "Adams, Terry",
                     "Andersen, Henriette Thaulow",
                     "Hedlund, Magnus", "Ito, Shu" };
            string firstLongName = names.FirstOrDefault(name => name.Length > 20);
            Console.WriteLine("The first long name is '{0}'.", firstLongName);
            string firstVeryLongName = names.FirstOrDefault(name => name.Length > 30);
            Console.WriteLine("There is {0} name longer than 30 characters.",
                string.IsNullOrEmpty(firstVeryLongName) ? "not a" : "a");
        }
    }
}
