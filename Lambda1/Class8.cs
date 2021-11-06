using System;
using System.Collections.Generic;
using System.Linq;

namespace Lambda1
{
    class Person
    {
        public string Name { get; set; }
    }

    class Pet1
    {
        public string Name { get; set; }
        public Person Owner { get; set; }
    }
    class Class8
    {
        public static void GroupJoinEx1()
        {
            Person magnus = new Person { Name = "Hedlund, Magnus" };
            Person terry = new Person { Name = "Adams, Terry" };
            Person charlotte = new Person { Name = "Weiss, Charlotte" };

            Pet1 barley = new Pet1 { Name = "Barley", Owner = terry };
            Pet1 boots = new Pet1 { Name = "Boots", Owner = terry };
            Pet1 whiskers = new Pet1 { Name = "Whiskers", Owner = charlotte };
            Pet1 daisy = new Pet1 { Name = "Daisy", Owner = magnus };

            List<Person> people = new List<Person> { magnus, terry, charlotte };
            List<Pet1> pets = new List<Pet1> { barley, boots, whiskers, daisy };
            var query =
                people.GroupJoin(pets,
                                 person => person,
                                 pet => pet.Owner,
                                 (person, petCollection) =>
                                     new
                                     {
                                         OwnerName = person.Name,
                                         Pets = petCollection.Select(pet => pet.Name)
                                     });

            foreach (var obj in query)
            {
                // Output the owner's name.
                Console.WriteLine("{0}:", obj.OwnerName);
                // Output each of the owner's pet's names.
                foreach (string pet in obj.Pets)
                {
                    Console.WriteLine("  {0}", pet);
                }
            }
        }
    }
}
