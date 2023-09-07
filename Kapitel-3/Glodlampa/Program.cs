// Hur man lagar ett lampfel
Console.WriteLine("Lampan fungerar inte!");

// Första fråga: är lampan inkopplad?
Console.Write("Är lampan inkopplad? (j/n)");
string svar = Console.ReadLine();

if (svar == "n")
{
    Console.WriteLine("Koppla in lampan!");
}
else
{
    // Andra frågan: är glödlampan utbränd?
    Console.WriteLine("Är glödlampan utbränd? (j/n)");
    string svar2 = Console.ReadLine();

    if (svar2 == "j")
    {
        Console.WriteLine("Ersätt glödlampan!");
    }
    else
    {
        Console.WriteLine("Köp en ny lampa!");
    }
}