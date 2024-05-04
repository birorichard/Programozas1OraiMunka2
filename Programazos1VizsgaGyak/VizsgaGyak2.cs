using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Programazos1VizsgaGyak
{
    internal class VizsgaGyak2
    {
        public static void Run()
        {
            // 1. feladat
            var dogNames = new List<string>();

            // 2. feladat
            dogNames.AddRange(["Rex", "Bulldog", "Buksi", "Rexi", "Puppy"]);
            dogNames.Sort();

            // 3. feladat
            // Ez is jó:
            dogNames.ForEach(Console.WriteLine);

            Console.WriteLine("\n");

            // Ez is jó:
            foreach (var dogName in dogNames)
            {
                Console.WriteLine(dogName);
            }

            // 4. feladat
            var sunSystemPlanets = new Dictionary<string, int>();
            sunSystemPlanets.Add("Merkúr", 0);
            sunSystemPlanets.Add("Vénusz", 0);
            sunSystemPlanets.Add("Föld", 1);
            sunSystemPlanets.Add("Mars", 2);
            sunSystemPlanets.Add("Jupiter", 95);
            sunSystemPlanets.Add("Szaturnusz", 146);
            sunSystemPlanets.Add("Uránusz", 28);
            sunSystemPlanets.Add("Neptunusz", 16);

            Console.WriteLine("\n");

            foreach (var planetName in sunSystemPlanets.Keys)
            {
                int moonCount = sunSystemPlanets[planetName];

                if (moonCount > 20) 
                {
                    Console.WriteLine(planetName);
                }
            }

        }
    }
}
