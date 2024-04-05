// 1. Hozz létre egy üres List<string> adatszerkezetet
// 2. Adj hozzá 3 tetszőleges elemet
// 3. Írd ki egymás alá az összes elemnek az értékét

// 4. Hozz létre List<int> adatszerkezetet
// 5. Tartalmazzon 6 számot 10 és 20 között
// 6. Egy ciklus segítségével írd ki egymás alá azokat az elemeket,
//    amik nagyobbak, mint 15

// 4-5
List<int> numbers = [11, 13, 15, 16, 17, 19];

// 6. Első mód
foreach (int number in numbers)
{
    if (number > 15)
    {
        Console.WriteLine(number);
    }
}

// 6. Második mód
Console.WriteLine("\n");
numbers.ForEach(number => 
{
    if (number > 15)
    {
        Console.WriteLine(number);
    }
});