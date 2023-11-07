// Array med 5 platser
string[] namnen = new string[5];

// Räknare för att hålla koll på antalet sparade namn
int antal = 0;

// Inmatningsloopen
while (antal < 6)
{

    // Fråga efter ett namn
    Console.Write("Ange ett namn eller 'Avbryt' för att avsluta:");
    string input = Console.ReadLine();

    // Om användaren matar in "Avbryt", avsluta loopen
    if (input == "Avbryt")
    {
        break;
    }
    // Om användaren matar in ett namn som redan finns, meddela användaren
    else if (namnen.Contains(input))
    {
        Console.WriteLine("Namnet finns redan, ange ett unikt namn.");
    }
    // Anna, lägg till namnet i arrayen
    else
    {
        namnen[antal] = input;
        antal++;
    }
}

// Hitta det längsta och kortaste namnet
string längstaNamn = "";
string kortasteNamn = "";

// Loopa igenom alla namn
foreach (var name in namnen)
{
    // Om namnet är längre än det längsta namnet, spara det
    if (name.Length > längstaNamn.Length)
    {
        längstaNamn = name;
    }

    // Om namnet är kortare än det kortaste namnet, spara det
    if (name.Length < kortasteNamn.Length)
    {
        kortasteNamn = name;
    }
}

// Skriv ut det längsta och kortaste namnet
Console.WriteLine("Det längsta namnet är: " + längstaNamn);
Console.WriteLine("Det kortaste namnet är: " + kortasteNamn);