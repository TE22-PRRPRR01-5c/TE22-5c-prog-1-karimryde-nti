// Metoder som returnerar
Console.Clear();

// En metod som summerar två värden (skicka med 2 tal)
// Returnerar summan
/* static int Summera(int tal1, int tal2)
{
    int summa = tal1 + tal2;
    return summa;
}

// Prova metoden
int summa = Summera(23, 45);
Console.WriteLine(summa);
Console.WriteLine($"Summan av 34 och 56 är {Summera(34, 56)}");
 */
// Den berömda metoden
Console.Write("Ange ett heltal: ");
//int tal = int.Parse(Console.ReadLine()); // Använd istället int.TryParse()
int tal = LäsInHeltal();

/// <summary>
/// Metod för säker inmatning av heltal
/// </summary>
/// <returns>Heltalet</returns>
static int LäsInHeltal()
{
    int heltal = 0;
    while (!int.TryParse(Console.ReadLine(), out heltal))
    {
        Console.WriteLine("Felaktig inmatning. Försök igen!");
    }
    return heltal;
}

static int FrågaLäsInTal(string fråga)
{
    Console.WriteLine(fråga);
    return LäsInHeltal();
}