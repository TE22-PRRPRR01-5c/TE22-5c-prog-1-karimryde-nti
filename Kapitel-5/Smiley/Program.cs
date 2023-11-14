// Animera en smiley på en rad aka 1D-game
Console.Clear();

Console.WriteLine("Animera en smiley på en rad aka 1D-game");
Console.Write("Vill du starta spelet j/n: ");
if (Console.ReadLine().ToLower() != "j") // oneliner dvs slipper en variabel
{
    return;
}

// Använda Emojis
Console.OutputEncoding = System.Text.Encoding.UTF8;
// Console.WriteLine("⬜⬜⬜⬜😁⬜⬜⬜⬜⬜");
// Console.WriteLine("⬜⬜⬜😁⬜⬜⬜⬜⬜⬜");

// Vilka symboler vi använder
// 0 = "⬜"
// 1 = "😁"
// 2 = "🌸"

// Virtuell spelplan
int[] rad = { 0, 0, 0, 1, 0, 0, 0, 0, 0, 2, 0, 0, 0, 0, 0 };

// Smileyns position
int smileyPos = 3;

// Animationsloopen
while (true)
{
    // Rensa konsolen
    Console.Clear();

    // Skriv ut raden
    foreach (var ruta in rad)
    {
        if (ruta == 0)
        {
            Console.Write("⬜");
        }
        else if (ruta == 1)
        {
            Console.Write("😁");
        }
        else if (ruta == 2)
        {
            Console.Write("🌸");
        }
    }
    // Radslut
    Console.WriteLine(smileyPos);

    // En millipaus 500ms
    Thread.Sleep(100);

    // Flytta på smileyn
    rad[smileyPos] = 0; // Gamla positionen
    smileyPos++;

    // Har smileyn nått sista platsen
    if (smileyPos == rad.Length)
    {
        smileyPos = 0;
    }

    rad[smileyPos] = 1; // Nya positionen
}