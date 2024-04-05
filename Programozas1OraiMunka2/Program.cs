var numbersInEnglish = new Dictionary<int, string>();
Dictionary<int, string> kisCica2 = new Dictionary<int, string>();
Dictionary<int, string> kisCica3 = new ();
Dictionary<int, string> kisCica4 = [];

// Ez is jó, ugyanaz az eredmény:
// Dictionary<string, int> dictionary = [];

// Elem hozzáadása
numbersInEnglish[31] = "thirtyone";
numbersInEnglish[20] = "twenty";
numbersInEnglish[100] = "hundred";

string valueOfThirtyOne = numbersInEnglish[31];
string valueOfTwenty = numbersInEnglish[20];
Console.WriteLine($"A 31 angolul: {valueOfThirtyOne}");
Console.WriteLine($"A 20 angolul: {valueOfTwenty}");

//var famousBuddies = new Dictionary<string, string>
//{
//    { "Tom", "Jerry" },
//    { "Stan", "Pan" },
//    { "Starsky", "Hutch" }
//};

var famousBuddies = new Dictionary<string, string>();
famousBuddies.Add("Tom", "Jerry");
famousBuddies.Add("Stan", "Pan");
famousBuddies.Add("Starsky", "Hutch");

var buddyOfStarsky = famousBuddies["Starsky"];

Console.WriteLine($"Starsky társa: {buddyOfStarsky}");

Console.WriteLine("\n"); // newline sor, üres sort szúr be

// Ki akarjuk írni az összes kulcs érték-párt
foreach (var key in famousBuddies.Keys)
{
    string currentBuddy = famousBuddies[key];
    Console.WriteLine($"{key} társa: {currentBuddy}");
}