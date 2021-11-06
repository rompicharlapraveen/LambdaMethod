using System;
using System.Collections.Generic;
using System.Linq;

namespace Lambda1
{
    /*
    class Class2
    {
        public static void Main(string[] args)
        {
            string[] names =
    { "Hartono, Tommy", "Adams, Terry", "Andersen, Henriette Thaulow",

        "Hedlund, Magnus", "Ito, Shu" };
            Random random = new Random(DateTime.Now.Millisecond);

            string name = names.ElementAt(random.Next(0, names.Length));

            Console.WriteLine("The name chosen at random is '{0}'.", name);
        }
    }
    */

    class Class2
    {
        public static void Main()
        {
            string[] names =
    { "Hartono, Tommy", "Adams, Terry", "Andersen, Henriette Thaulow",
        "Hedlund, Magnus", "Ito, Shu" };

            int index = 20;

            string name = names.ElementAtOrDefault(index);

            Console.WriteLine(
                "The name chosen at index {0} is '{1}'.",
                index,
                String.IsNullOrEmpty(name) ? "<no name at this index>" : name);
        }
    }
}
