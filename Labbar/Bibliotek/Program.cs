using Bibliotek;

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
            Metoder.LäggTillBok(boklista);
            break;

        // Visa alla böcker
        case "2":
            Metoder.VisaAllaBöcker(boklista);
            break;

        // Sök efter en bok
        case "3":
            Metoder.SökBok(boklista);
            break;

        // Ta bort en bok
        case "4":
            Metoder.RaderaBok(boklista);
            break;

        // Spara ned boklista i textfil
        case "5":
            Metoder.SparaIFil(boklista, filnamn);
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
