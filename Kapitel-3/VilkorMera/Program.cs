// Kedjade if-satser
Console.Clear();

/* // Läs in en färg
Console.Write("Ange en färg (orange, lila, gul): ");
string färg = Console.ReadLine();

// Hantera svaret
if (färg == "orange")
{
    Console.WriteLine("Du valde färgen orange");
}
else if (färg == "lila")
{
    Console.WriteLine("Du valde färgen lila");
}
else if (färg == "gul")
{
    Console.WriteLine("Du valde färgen gul");
} */

/* // Användaren skall gissa ett tal
int vinstNummer = 456;

// Läs in gissning
Console.Write("Gissa vinstnummer (1-999): ");
//string gissningString = Console.ReadLine();
//int gissning = int.Parse(gissningString);
int gissning = int.Parse(Console.ReadLine());

// Kolla om gissnigen är rätt
if (gissning == vinstNummer)
{
    Console.WriteLine("Du vann!");
}
else if (gissning > vinstNummer)
{
    Console.WriteLine("Du gissade för högt!");
}
else
{
    Console.WriteLine("Du gissade för lågt!");
} */

// TP-fråga
Console.Write("Vem var statsminister i Sverige år 1979? ");
string svar = Console.ReadLine();

// Omvandla svaret till små bokstäver (gemena)
svar = svar.ToLower();

// Kolla om svaret är rätt
if (svar == "palme")
{
    Console.WriteLine("Rätt svar");
}
else
{
    Console.WriteLine("Fel svar");
}