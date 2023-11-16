// Konsolspel - styra en smiley
Console.Clear();
Console.WriteLine("Konsolspel - styra en smiley");
Console.Write("Vill du starta spelet? (j/n) ");
if (Console.ReadLine().ToLower() != "j")
{
    return; // Avslutar programmet
}

// Symboler vi använder
// 0 = "⬛" (bakgrund)
// 1 = "🐧" (figuren)
// 2 = "🐱";

Console.OutputEncoding = System.Text.Encoding.UTF8;

// Virtuella spelplan
int[] rad = { 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 2, 0, 0, 0 };
int smileyPos = 4;
int kattPos = 10;
int poäng = 0;
Random generator = new Random();

// Animationsloop
while (true)
{
    // Rensa konsolen
    Console.Clear();

    // Rita ut spelplan
    foreach (var ruta in rad)
    {
        switch (ruta)
        {
            case 0:
                Console.Write("⬛");
                break;
            case 1:
                Console.Write("🐧");
                break;
            case 2:
                Console.Write("🐱");
                break;
        }
    }
    Console.WriteLine(); // Avsluta raden
    Console.WriteLine($"poäng: {poäng}");

    // Rensa gamla positionen
    rad[smileyPos] = 0;

    // Lyssna på tangenttryckningar
    ConsoleKeyInfo tanget = Console.ReadKey(true);
    switch (tanget.Key)
    {
        case ConsoleKey.LeftArrow:
            smileyPos--;
            // Kontroll att figuren inte hamnar utanför
            if (smileyPos < 0)
            {
                smileyPos = rad.Length - 1;
            }
        break;
        case ConsoleKey.RightArrow:
            smileyPos++;
            // Kontroll att figuren inte hamnar utanför
            if (smileyPos >= rad.Length)
            {
                smileyPos = 0;
            }
        break;
    }

    // Uppdatera arrayen
    rad[smileyPos] = 1;

    // Äta katten
    if (smileyPos == kattPos)
    {
        poäng++;
        kattPos = generator.Next(0, rad.Length -1);
        rad[kattPos] = 2;
    }
}