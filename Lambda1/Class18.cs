using System;
using System.Collections.Generic;
using System.Linq;

namespace Lambda1
{
    class Pet3
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
    class Class18
    {
        public static void Main()
        {
            Pet[] pets = { new Pet { Name="Barley", Age=8 },
                   new Pet { Name="Boots", Age=4 },
                   new Pet { Name="Whiskers", Age=1 } };

            IEnumerable<Pet> query = pets.OrderBy(pet => pet.Age);

            foreach (Pet pet in query)
            {
                Console.WriteLine("{0} - {1}", pet.Name, pet.Age);
            }
        }
    }
}
