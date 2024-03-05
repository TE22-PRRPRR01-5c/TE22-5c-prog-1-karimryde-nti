// Ett bokregister
Console.Clear();
Console.WriteLine("Välkommen till bokregister");
Console.WriteLine("Här kan du registrera dina böcker");

// En list för att lagra boknamn
List<string> boklista = new List<string>();

// Programloop
while (true)
{
    // Meny med val
    Console.WriteLine(
@"
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

        // Avsluta
        case "5":
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

static void SökBok(List<string> lista)
{

}

static void RaderaBok(List<string> lista)
{

}