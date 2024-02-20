// En enkel anteckningsbok som skriver/läser textfil

/* ****************************************** */
/* ************ Huvudprogrammet ************* */
/* ****************************************** */
Console.Clear();
Console.WriteLine("Anteckningsboken");

// Viktiga variabler
string filnamn = "texter.txt";

// Programloop
while (true)
{
    // Visa meny
    VisaMeny();
    string val = Console.ReadLine();
    switch (val)
    {
        // 1. Spara anteckning (beständigt = textfil)
        case "1":
        SparaAnteckning(filnamn);
        break;

        // 2. Läsa anteckning
        case "2":
        LäsaAnteckningar(filnamn);
        break;

        // 3. Avsluta programmet
        case "3":
        Console.WriteLine("Tack för idag!");
        return;
        
        default:
        Console.WriteLine("Fel val, försök igen!");
        break;
    }
}

/* ****************************************** */
/* **************** Metoderna *************** */
/* ****************************************** */

/// <summary>
/// Skriver ut menyn
/// </summary>
static void VisaMeny()
{
    Console.WriteLine("1. Spara anteckning ");
    Console.WriteLine("2. Läsa anteckning");
    Console.WriteLine("3. Avsluta programmet");
    Console.Write("Ange ditt val: ");
}

/// <summary>
/// Spara anteckning i textfil
/// </summary>
static void SparaAnteckning(string textfilen)
{
    // Användaren matar in en anteckning
    Console.Write("Anteckning: ");
    string anteckning = Console.ReadLine();

    // Spara ned anteckning i textfil
    File.AppendAllText(textfilen, anteckning);
}

/// <summary>
/// Läser anteckningar från textfil
/// </summary>
static void LäsaAnteckningar(string textfilen)
{
    string anteckning = File.ReadAllText(textfilen);
    Console.WriteLine(anteckning);
}