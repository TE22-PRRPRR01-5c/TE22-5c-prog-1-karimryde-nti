// Ett bokregister
Console.Clear();
Console.WriteLine("Välkommen till bokregister");
Console.WriteLine("Här kan du registrera dina böcker");

/* ****************************************** */
/* ********* H U V U D D E L  *************** */
/* ****************************************** */

// En list för att lagra boknamn
List<string> boklista = new List<string>();
string filnamn = "bibliotek.txt";

// Programloop
while (true)
{
    // Meny med val
    Console.WriteLine(@"
    1. Lägg till en bok
    2. Visa alla böcker
    3. Sök efter en bok
    4. Ta bort en bok
    5. Avsluta
    Ange ditt val (1-5)?");
    string val = Console.ReadLine();

    switch (val)
    {
        // Lägg till en bok
        case "1":
            LäggTillBok(boklista);
            break;

        // Visa alla böcker
        case "2":
            VisaAllaBöcker(boklista);
            break;

        // Sök efter en bok
        case "3":
            SökBok(boklista);
            break;

        // Ta bort en bok
        case "4":
            RaderaBok(boklista);
            break;

        // Spara ned boklista i textfil
        case "5":
            SparaIFil(boklista, filnamn);
            break;

        // Läsa in boklista från textfil
        case "6":
            boklista = LäsaFil(filnamn);
            break;

        // Avsluta
        case "7":
            Console.WriteLine("Tack för idag!");
            return;

        default:
            Console.WriteLine("Felaktigt val, försök igen!");
            break;
    }
}

/* ****************************************** */
/* ********* M E T O D E R ****************** */
/* ****************************************** */

static void LäggTillBok(List<string> lista)
{
    Console.Write("Ange namnet på en bok: ");
    string boknamn = Console.ReadLine();
    lista.Add(boknamn);
}

static void VisaAllaBöcker(List<string> lista)
{
    foreach (var bok in lista)
    {
        Console.WriteLine(bok);
    }
}

/// <summary>
/// Lista alla böcker som matchar en sökterm
/// </summary>
/// <param name="lista"></param>
static void SökBok(List<string> lista)
{
    // Läser in sökterm
    Console.Write("Ange en sökterm: ");
    string sökterm = Console.ReadLine();

    // Gå igenom listan & skriv alla böcker som matchar
    foreach (var bok in lista)
    {
        // Finns sökterm i boken
        if (bok.Contains(sökterm))
        {
            Console.WriteLine($"Hittade: {bok}");
        }
    }
}

/// <summary>
/// Sök bok för att kunna radera den
/// </summary>
/// <param name="lista"></param>
static void RaderaBok(List<string> lista)
{
    // Läser in sökterm
    Console.Write("Ange en sökterm: ");
    string sökterm = Console.ReadLine();

    // Gå igenom listan & skriv alla böcker som matchar
    List<string> listaRadera = new List<string>();
    foreach (var bok in lista)
    {
        // Finns sökterm i boken
        if (bok.Contains(sökterm))
        {
            Console.WriteLine($"Hittade: {bok}");

            Console.Write($"Vill du raderna '{bok}' (j/n)?  ");
            string svar = Console.ReadLine();
            if (svar == "j")
            {
                listaRadera.Add(bok);
            }
        }
    }

    // Gå igenom lista på böcker att radera
    foreach (var bok in listaRadera)
    {
        lista.Remove(bok);
    }
}

static void SparaIFil(List<string> lista, string filnamn)
{
    File.WriteAllLines(filnamn, lista);
}

static List<string> LäsaFil(string filnamn)
{
    return File.ReadAllLines(filnamn).ToList();
}

