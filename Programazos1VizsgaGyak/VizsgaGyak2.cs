// 1. Hozz létre egy üres List<string> adatszerkezetet.
// 2. Adj hozzá 5 gyümölcsöt, zöldséget, szuperhős-, kutyanevet, etc.
//    mindegy, ami tetszik, és rendezd őket ABC-sorrendbe
//    (nem kell megírni a rendezést, a List<T> adatszerkezetet egyik
//    függvénye használható).
// 3. Írd ki a konzolra egy ciklus segítségével az előző rendezett
//    adatszerkezet elemeit.
// 4. Hozz létre egy Dictionary<string, int> adatszerkezetet,
//    ami tartalmazza a Naprendszer bolygóit és azt, hogy hány holdjuk van.
//      Merkúr: 0, Vénusz: 0, Föld: 1, Mars: 2, Jupiter: 95,
//      Szaturnusz: 146, Uránusz: 28, Neptunusz: 16
// 5. Egy ciklus segítségével írd ki azoknak a bolygóknaik a neveit,
//    amiknek több holdja van 20-nál.


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
