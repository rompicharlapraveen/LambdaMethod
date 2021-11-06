using System;
using System.Collections.Generic;
using System.Linq;

namespace Lambda1
{
    class Package1
    {
        public string Company { get; set; }
        public double Weight { get; set; }
    }
    class Class36
    {
        public static void Main()
        {
            List<Package> packages =
                new List<Package>
                    { new Package { Company = "Coho Vineyard", Weight = 25.2 },
              new Package { Company = "Lucerne Publishing", Weight = 18.7 },
              new Package { Company = "Wingtip Toys", Weight = 6.0 },
              new Package { Company = "Adventure Works", Weight = 33.8 } };

            string[] companies = packages.Select(pkg => pkg.Company).ToArray();

            foreach (string company in companies)
            {
                Console.WriteLine(company);
            }
        }
    }
}
