// Inloggningsprogram
Console.Clear();

// Läs in ett användarnamn
Console.Write("Ange användarnamn: ");
string anamn = Console.ReadLine();

// Läs in ett lösenord
Console.Write("Ange lösenord: ");
string lösenord = Console.ReadLine();

// Kolla om användarnamn är rätt
/* if (anamn == "karre")
{
    Console.WriteLine("Trevligt att se dig igen!");
}
else
{
    Console.WriteLine("Du finns inte i systemet!");
} */

// Kolla om lösenordet är rätt
/* if (lösenord == "qwertyui")
{
    Console.WriteLine("Du är inloggad!");
}
else
{
    Console.WriteLine("Lösenordet stämmer inte!");
}
 */
// Vi kollar båda villkoren samtidigt
if (anamn == "karre" && lösenord == "qwertyui")
{
    Console.WriteLine("Alla uppgifter stämmer! Du är inloggad!");
}
else
{
    Console.WriteLine("Användarnamnet eller lösenordet är fel!");
}