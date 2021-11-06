using System;
using System.Collections.Generic;
using System.Linq;

namespace Lambda1
{
    class Package
    {
        public string Company { get; set; }
        public double Weight { get; set; }
    }
    class Class32
    {
        public static void Main()
        {
            List<Package> packages = new List<Package>
            { new Package { Company = "Coho Vineyard", Weight = 25.2 },
              new Package { Company = "Lucerne Publishing", Weight = 18.7 },
              new Package { Company = "Wingtip Toys", Weight = 6.0 },
              new Package { Company = "Adventure Works", Weight = 33.8 } };

            double totalWeight = packages.Sum(pkg => pkg.Weight);

            Console.WriteLine("The total weight of the packages is: {0}", totalWeight);
        }

    }
}
