using System;
using System.Collections.Generic;
using System.Linq;

namespace Lambda1
{
    /*
    class Class15
    {
       public static void Main()
        {
            /*
             List<long> longs = new List<long> { 4294967296L, 466855135L, 81125L };

            long max = longs.Max();

            Console.WriteLine("The largest number is {0}.", max);
            */

            /*
            double?[] doubles = { null, 1.5E+104, 9E+103, -2E+103 };

            double? max = doubles.Max();

            Console.WriteLine("The largest number is {0}.", max);
            */
        }
// }
class Pet
{
    public string Name { get; set; }
    public int Age { get; set; }
}
class Class15
{

    public static void Main()
    {
        Pet[] pets = { new Pet { Name="Barley", Age=8 },
                   new Pet { Name="Boots", Age=4 },
                   new Pet { Name="Whiskers", Age=1 } };

        int max = pets.Max(pet => pet.Age + pet.Name.Length);

        Console.WriteLine(
            "The maximum pet age plus name length is {0}.",
            max);
    }
}
