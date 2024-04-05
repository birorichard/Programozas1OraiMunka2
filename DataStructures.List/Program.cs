Console.WriteLine("2024.03.09. - List adatszerkezet");

int number = 12312;
List<int> numbers = [];  // Üres integer típusú változókat fogadó lista.
List<string> texts = [];
List<char> characters = [];
numbers.Add(567);
/* numbers.Add("kisCica"); */ /* Ez így nem működik, mert egész számokat tartalmazó
                               * listához akarunk szöveget hozzáadni. */
texts.Add("KisCica");
/* texts.Add(567); */ /* Ez így nem működik, mert szöveget tartalmazó
                    *  listához akarunk egész számot hozzáadni. */

Console.WriteLine("\n");
Console.WriteLine("\n");
var userName = "Károly";  // Ez jön valahonnan, adatbázisból mondjuk...
//Console.WriteLine("Hello, Richard!");

Console.WriteLine("\n");
Console.WriteLine("\n");

string welcomeText = $"Hello, {userName}!";

string elementsOfNumbersList = string.Join(", ", numbers);
Console.WriteLine($"A numbers lista elemei: {elementsOfNumbersList}");
Console.WriteLine(welcomeText);

List<string> cats = ["Buci", "Felix", "Bruce", "Hami"];
Console.WriteLine(cats);

Console.WriteLine("\n");
Console.WriteLine("\n");

/* string.Join(): Összefűzi egy lista elemeit egyetlen szöveggé, és a megadott
 szeparátorral választja el őket egymástól. */


/* egy string típusú változón meghívható a Split fv, ami a megadott szeparátor
 szerint szétválasztja az elemeket és eltárolja egy tömbben*/
var catNamesText = "Buci, Felix, Bruce, Hami";
var catNamesList = catNamesText.Split(", ");

var catNames = string.Join(", ", cats);
Console.WriteLine($"A cats lista elemei: {catNames}");

Console.WriteLine("\n");
Console.WriteLine("\n");


string name;  // Deklaracio
string firstName = "";
string lastName = "Biro";

List<string> programmingClassMemberNames = [];
programmingClassMemberNames.Add("Károly");
programmingClassMemberNames.Add("Fanni");
programmingClassMemberNames.Add("Tibor");

// Elemek hozzáadása és eltávolítása
cats.Add("Tom");
var newCats = new string[] { "Tom2", "Tom3", "Tom4" };
cats.AddRange(newCats);

var lotteryNumbers = new int[] { 67, 2, 3 };
numbers.AddRange(lotteryNumbers);
Console.WriteLine($"A cats lista elemei: {string.Join(", ", cats)}");
Console.WriteLine($"A numbers lista elemei: {string.Join(", ", numbers)}");

cats.Remove("Tom");  // Csak az első előfordulást távolítja el
cats.RemoveAll(catName => catName == "Tom");  // A megfogalmazott feltételnek megfelelő összes előfordulást eltávolítja.
Console.WriteLine($"A cats lista elemei: {string.Join(", ", cats)}");

// Az elemek indexálása nullával keződik.
string firstCatName = cats[0];
Console.WriteLine($"A listából az első cica neve: {firstCatName}");

Console.WriteLine("\n");

// Lista bejárása
foreach(int currentNumber in numbers)
{
    Console.WriteLine(currentNumber);
}

foreach (string currentCat in cats)
{
    Console.WriteLine(currentCat);
}

Console.WriteLine("\n");

cats.ForEach(cat => Console.WriteLine(cat));
cats.ForEach(cat =>
{
    if (true)
    {
        Console.WriteLine(cat);
    }
});

// Lista rendezése
numbers.Sort();
cats.Sort();
Console.WriteLine($"A numbers lista elemei: {string.Join(", ", numbers)}");
Console.WriteLine($"A cats lista elemei: {string.Join(", ", cats)}");

// Elem létezésenek ellenőrzése
bool containsFelix = cats.Contains("Felix");
Console.WriteLine($"A cats lista tartalmaz Felix nevű elemet? {(containsFelix ? "Igen" : "Nem")}");

// Lista mérete
int countOfCats = cats.Count();
Console.WriteLine($"A cats list mérete: {countOfCats}");

// Lista törlése
numbers.Clear();