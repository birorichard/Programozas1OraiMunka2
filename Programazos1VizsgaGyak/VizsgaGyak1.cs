using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programazos1VizsgaGyak
{
    internal class VizsgaGyak1
    {
        public static void Run()
        {
            // 1. feladat
            var numbers = new List<int>();

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