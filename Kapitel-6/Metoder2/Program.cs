Console.Clear();

/* // Skriv ut ett meddelande vertikalt
string meddelande1 = "Metoder är bra ha!";
for (int i = 0; i < meddelande1.Length; i++)
{
    Console.WriteLine(meddelande1[i]);
}

// Skriv ut ett meddelande vertikalt
string meddelande2 = "Metoder förenklar kodning!";
for (int i = 0; i < meddelande2.Length; i++)
{
    Console.WriteLine(meddelande2[i]);
}

// Skriv ut ett meddelande vertikalt
string meddelande3 = "Metoder gör min kod mer strukturerad!";
for (int i = 0; i < meddelande3.Length; i++)
{
    Console.WriteLine(meddelande3[i]);
} */

/// <summary>
/// Skriver text vertikalt
/// </summary>
static void SkrivUtVertikalt()
{
    string meddelande3 = "Metoder gör min kod mer strukturerad!";
    for (int i = 0; i < meddelande3.Length; i++)
    {
        Console.WriteLine(meddelande3[i]);
    }
}

// Kör metoder
SkrivUtVertikalt();
SkrivUtVertikalt();
SkrivUtVertikalt();

/// <summary>
/// Skriver ut en text vertikalt
/// </summary>
/// <param name="meddelande3">Texten som ska skrivas ut</param>
static void SkrivUtTextVertikalt(string meddelande3)
{
    for (int i = 0; i < meddelande3.Length; i++)
    {
        Console.WriteLine(meddelande3[i]);
    }
}

// Kör metoden
SkrivUtTextVertikalt("Vi tränar på metoder");
SkrivUtTextVertikalt("En metod ska göra EN sak bra");
SkrivUtTextVertikalt("Metoder är bra");