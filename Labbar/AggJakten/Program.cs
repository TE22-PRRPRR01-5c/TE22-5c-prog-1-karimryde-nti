/* *************************************************
 * Namn: Påskäggsjakten
 * Beskrivning: Ett program som simulerar en påskäggsjakt
 * Av: [Ditt namn]
 * Datum: 2021-09-01
 *********************************************** */

Metoder.Presentation();

// Initiera antal påskägg till 0
int antalPåskägg = 0;

// Programloop
while (true)
{
    // Visa en meny för användaren
    Metoder.VisaMeny();
    string val = Console.ReadLine();

    // Hantera användarens val
    if (val == "1")
    {
        antalPåskägg = Metoder.HittaPåskägg(antalPåskägg);
    }
    else if (val == "2")
    {
        antalPåskägg = Metoder.ÄtaPåskägg(antalPåskägg);
    }
    else if (val == "3")
    {
        Metoder.VisaAntalPåskägg(antalPåskägg);
    }
    else if (val == "4")
    {
        Console.WriteLine("Tack för den här gången");
        break;
    }
    else
    {
        Console.WriteLine("Du angav ett felaktigt val, försök igen.");
    }
}