// 1. Hozz létre egy üres List<int> adatszerkezetet
// 2. Adj hozzá 5 tetszőleges számot 1 és 50 között, majd újabb 5-öt 51 és 100 között
// 3. Hozz létre egy üres Dictionary<int, string> adatszerkezetet
// 4. Egy ciklus segítségével töltsd fel a 3. pontban létrehozott Dictionary-t úgy, hogy az első tagja a List tartalma legyen,
//    a második ugyanez, de string típusra konvertálva.
// 5. Egy ciklus segítségével írd ki a List adatszerkezetet elemei közül azokat, amik kisebbek 50-nél.

namespace Programazos1VizsgaGyak
{
    internal class VizsgaGyak1
    {
        public static void Run()
        {
            // 1. feladat
            var numbers = new List<int>();

            // Ez is jó megoldás:
            //numbers.Add(1);
            //numbers.Add(3);
            //numbers.Add(31);
            //numbers.Add(42);

            // 2. feladat
            numbers.AddRange([1, 3, 31, 42, 50]);
            numbers.AddRange([52, 63, 71, 82, 90]);

            // 3. feladat
            var numbersInDictionary = new Dictionary<int, string>();

            // 4. feladat
            foreach (var number in numbers) 
            {
                numbersInDictionary.Add(number, number.ToString());
            }

            // 5. feladat
            foreach (var number in numbers)
            {
                if (number < 50)
                {
                    Console.WriteLine(number.ToString());
                }
            }

        }
    }
}