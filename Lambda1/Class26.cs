﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace Lambda1
{
    class Pet4
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
    class Class26
    {
        public static void Main()
        {
            Pet pet1 = new Pet { Name = "Turbo", Age = 2 };
            Pet pet2 = new Pet { Name = "Peanut", Age = 8 };

            // Create two lists of pets.
            List<Pet> pets1 = new List<Pet> { pet1, pet2 };
            List<Pet> pets2 = new List<Pet> { pet1, pet2 };

            bool equal = pets1.SequenceEqual(pets2);

            Console.WriteLine("The lists {0} equal.", equal ? "are" : "are not");
        }
    }
}
