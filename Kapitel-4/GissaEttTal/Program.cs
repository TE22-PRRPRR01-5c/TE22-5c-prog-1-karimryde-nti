// Program för att gissa ett tal mellan 1-100
Console.Clear();

// Slumpa fram ett tal
Random tärning = new Random();
int slumptal = tärning.Next(1, 101);

// Variabel för att räkna antal gissningar
int antal = 0;

// Spelloop som avslutas när anv. gissat rätt
while (true)
{
    antal += 1;
    
    // Be användare gissa
    Console.Write("Gissa ett tal (1-100): ");
    int gissning = int.Parse(Console.ReadLine());

    // Kontrollera om gissningen är korrekt
    if (gissning == slumptal)
    {
        Console.WriteLine("Bra gissat!");
        break;
    }
    else if (gissning > slumptal)
    {
        Console.WriteLine("För högt!");
    }
    else
    {
        Console.WriteLine("För lågt!");
    }
}

// Avsluta
Console.WriteLine($"Du gissade rätt {antal} gånger.");
