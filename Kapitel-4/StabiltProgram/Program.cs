// Hur man säkrar inmatning i ett program
using System.Linq.Expressions;

Console.Clear();

// Meny
Console.WriteLine("1. Registrera lön");
Console.WriteLine("2. Skriv ut alla löner");
Console.WriteLine("3. Avsluta");
Console.Write("Ange ditt val: ");
string val = Console.ReadLine();

if (val == "1")
{
    // Inläsning av bruttolön
    int bruttolön = 0;
    bool lyckadKonvertering = false;
    while (!lyckadKonvertering)
    {
        Console.Write("Ange din bruttolön: (kr) ");
        string bruttolönString = Console.ReadLine();

        // Kan vi "parsa" inputen från konsolen?
        lyckadKonvertering = int.TryParse(bruttolönString, out bruttolön);
        Console.WriteLine($"TryParse säger {lyckadKonvertering} och resultat är {bruttolön}");
    }

    // Inläsning av skattesats
    int skattesats = 0;
    lyckadKonvertering = false;
    while (!lyckadKonvertering)
    {
        Console.Write("Ange din skattesats: (kr) ");
        string skattesatsString = Console.ReadLine();

        // Kan vi "parsa" inputen från konsolen?
        lyckadKonvertering = int.TryParse(skattesatsString, out skattesats);
        Console.WriteLine($"TryParse säger {lyckadKonvertering} och resultat är {skattesats}");
    }

    // Utskrift av resultatet
    Console.WriteLine($"Din nettolön är {(100 - skattesats) * bruttolön / 100}");

    // Spara registrering i en textfil
    string textfil = "loner.txt";
    File.AppendAllText(textfil, $"{bruttolön} {skattesats}\n");

}
else if (val == "2")
{
    // Läs in innehållet i textfilen
    string textfil = "loner.txt";

    // Kontrollera att filen finns
    if (File.Exists(textfil))
    {
        string rader = File.ReadAllText(textfil);

        // Skriv ut i konsolen
        Console.WriteLine(rader);
    }
    else
    {
        Console.WriteLine("textfilen med löner finns inte!");
    }
}
else if (val == "3")
{

}
else
{

}
