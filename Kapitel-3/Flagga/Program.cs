// Program som skan avgöra om användaren är kvalificerad
Console.Clear();
Console.Write("Ange ditt namn: ");
string namn = Console.ReadLine();

// En variabel för att hålla reda på om anv. är kvalificerad
bool ärKvalificerad = true;

Console.WriteLine($"Hej {namn}, nu kommer några frågor för att se om du ärkvalificerad");

// Första frågan
Console.Write("Är du över 18 år (j/n): ");
string svar = Console.ReadLine();
if (svar != "j")
{
    ärKvalificerad = false;
}

// Andra frågan
Console.Write("Har du körkort (j/n): ");
svar = Console.ReadLine();
if (svar != "j")
{
    ärKvalificerad = false;
}

// Ge feedback till användaren
if (ärKvalificerad)
{
    Console.WriteLine($"Grattis {namn}! Du uppfyller villkoren.");
}
else
{
    Console.WriteLine($"Tyvärr {namn}! Du uppfyller inte villkoren.");
}