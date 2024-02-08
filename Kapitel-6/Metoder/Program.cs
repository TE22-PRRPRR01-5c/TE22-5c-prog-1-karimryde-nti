// Intro till metoder
using System.Text.Encodings.Web;

Console.Clear();

// En enkel metod
static void Hälsning()  // Signatur
{
    Console.WriteLine("Hej världen!");
}

// Använda metoden
Hälsning();
Hälsning();
Hälsning();

// En menymetod
static void VisaMeny()
{
    Console.WriteLine("1. Skriv ut rapport");
    Console.WriteLine("2. Skapa rapport");
    Console.WriteLine("3. Radera rapport");
    Console.WriteLine("4. Avsluta");
}

// Använda menymetoden
VisaMeny();

// Metod med parameter (argument)
static void PersonligHälsning(string namn)
{
    Console.WriteLine($"Hej {namn}");
}

// Använder metoden
PersonligHälsning("Alex");
PersonligHälsning("Anita");
PersonligHälsning("Zebra");

// Metod med parameter (2 argument)
/* static void PersonligHälsning(string förnamn, string efternamn)
{
    Console.WriteLine($"Hej {förnamn} {efternamn}");
}

PersonligHälsning("", ""); */

// Metoder som returnerar
static string MenyMedVal()    // Signatur
{
    Console.Clear();
    Console.WriteLine("1. Skriv ut rapport");
    Console.WriteLine("2. Skapa rapport");
    Console.WriteLine("3. Radera rapport");
    Console.WriteLine("4. Avsluta");
    Console.Write("Ange ditt val");
    string val = Console.ReadLine();
    return val;
}
string användarensVal = MenyMedVal();
Console.WriteLine($"Användaren valde {användarensVal}");

string val = MenyMedVal();
Console.WriteLine($"Användaren valde {val}");

/* ************************************* */
/* Skapa en metod som tar emot ett ord som parameter och returnerar antalet bokstäver i ordet. */
static int RäknaBokstäver(string ord)
{
    int antal = ord.Length;

    return antal;
}

/* Skapa en metod som tar emot ett ord som parameter och returnerar antalet vokaler i ordet. */
static int RäknaVokaler(string ord)
{
    int antal = 0;

    // Loopa igenom ordet
    foreach (char bokstav in ord)
    {
        if (bokstav == 'a' || bokstav ==  'e' || bokstav == 'i' || bokstav == 'o' || bokstav == 'y')
        {
            antal++;
        }
    }

    return antal;
}

/* Skapa en metod som tar emot två heltal och returnerar summan iform av en text: "Summan av 2 och 3 är 5" */
static string SummaSomText(int tal1, int tal2)
{
    string texten = $"Summan av {tal1} och {tal2} är {tal1 + tal2}";
    return texten;
}