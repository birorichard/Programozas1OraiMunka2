Console.WriteLine("Programozás 1. - Vezérlő szerkezetek");
Console.WriteLine("Órai munka - 2024.02.24.");

Console.WriteLine("\n");

// Létrehozunk egy tömb típusú változót, amibe integer típusú értékeket tudunk tenni.
// A tömbök indexelése 0-val kezdődik.
int[] temperatureInCelsiusToday = 
    [/*0. indexű elem: */3, 
    /*1. indexű elem: */5, 
    /*2. indexű elem: */12, 17, 15, 6, 3, 1];

// Kettes indexű elem hozzárendelése egy új int típusú változóhoz.
int thirdTemperatureValue = temperatureInCelsiusToday[2];

// 12 lesz az eredmény.
Console.WriteLine($"A tömb kettes indexű elem: {thirdTemperatureValue}");

Console.WriteLine("\n");


// Szelekció - Feltételvizsgálat
if (thirdTemperatureValue > 10)
{
    // Csinálja ezt, ha IGAZ a fenti kifejezés értéke
    Console.WriteLine("A hőmérséklet értéke nagyobb, mint 10");
}
else
{
    // Csinálja ezt, ha HAMIS a fenti kifejezés értéke
    Console.WriteLine("A hőmérséklet értéke kisebb vagy egyenlő mint 10");
}

Console.WriteLine("\n");

// Ciklusvezérlés
for (/*Ciklusváltozó, ami csak a for cikluson belül létezik: */int i = 0; /*Végfeltétel: */ i < temperatureInCelsiusToday.Length; i++)
{
    // Ciklusmag
    Console.WriteLine($"A(z) {i}. indexű elem értéke: {temperatureInCelsiusToday[i]}");
}