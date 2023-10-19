// Program för kryptera/dekryptera meddelande med Ceasar-kryptot
Console.Clear();
Console.WriteLine("Program för kryptera/dekryptera meddelande med Ceasar-kryptot");

// Programmeny
Console.WriteLine("1. Kryptera meddelande");
Console.WriteLine("2. Dekryptera meddelande");
Console.WriteLine("3. Avsluta");

// Läs in användarens val
string val = Console.ReadLine();

// Kryptera meddelande
if (val == "1")
{
    // Läs in meddelande
    Console.Write("Skriv ett meddelande: ");
    string meddelande = Console.ReadLine();

    // Läs in krypteringsnyckel
    Console.Write("Ange krypteringsnyckel: ");
    int nyckel = int.Parse(Console.ReadLine());
    
    // Ta gå igenom bokstäverna en-och-en
    string meddelandeSkiftat = "";
    for (int i = 0; i < meddelande.Length; i++)
    {
        // En bokstav
        char bokstav = meddelande[i];
        //Console.WriteLine(bokstav);

        // Hitta ASCII-värdet på för bokstaven
        int bokstavAscii = (int)bokstav;
        //Console.WriteLine(bokstavAscii);

        // Addera nyckeln
        bokstavAscii += nyckel;
        //Console.WriteLine(bokstavAscii);

        // Om högre än Z börja om på A
        if (bokstavAscii > 90)
        {
            bokstavAscii -= 26;
        }

        // Hitta motsvarande tecken i ASCII-tabellen
        char bokstavSkiftad = (char)bokstavAscii;
        //Console.WriteLine(bokstavSkiftad);

        // Bygg upp det krypterade meddelandet
        meddelandeSkiftat += bokstavSkiftad;
    }

    // Skriv ut det krypterade meddelandet
    Console.WriteLine(meddelandeSkiftat);
}
// Dekryptera meddelande
else if (val == "2")
{
    
}
// Avsluta
else if (val == "3")
{
    
}
else
{
    Console.WriteLine("Felaktigt val. Försök igen!");
}