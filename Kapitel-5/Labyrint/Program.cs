// Labyrintspel i 2D
Console.Clear();
Console.WriteLine("Labyrintspel i 2D");

Console.Write("Vill du köra spelet? (j/n)");
if (Console.ReadLine().ToLower() != "j")
{
    return;
}

// Slå på UTF8 för att visa Emojis korrekt
Console.InputEncoding = System.Text.Encoding.UTF8;
Console.OutputEncoding = System.Text.Encoding.UTF8;
Console.CursorVisible = false;

// Skapa en spelplan
int[,] spelplan = {
    {1, 1, 1, 1, 1, 1, 1, 1, 1, 1},
    {1, 0, 0, 0, 0, 0, 0, 0, 0, 1},
    {1, 1, 1, 1, 1, 1, 1, 1, 0, 1},
    {1, 0, 0, 0, 0, 0, 0, 0, 0, 1},
    {1, 0, 1, 1, 1, 1, 1, 1, 1, 1},
    {1, 0, 1, 0, 0, 0, 1, 0, 0, 1},
    {1, 0, 1, 0, 1, 0, 1, 0, 0, 1},
    {1, 0, 1, 0, 1, 0, 1, 1, 0, 1},
    {1, 0, 0, 0, 1, 0, 0, 0, 0, 1},
    {1, 1, 1, 1, 1, 1, 1, 1, 1, 1},
};

// Rita ut spelplanen
Console.Clear();
// For-loop för att gå igenom raderna
for (int rad = 0; rad < spelplan.GetLength(0); rad++)
{
    // For-loop för att gå igenom kolumnerna
    for (int kol = 0; kol < spelplan.GetLength(1); kol++)
    {
        // Rita ut emoji för vägg eller gång
        switch (spelplan[rad, kol])
        {
            case 0:
                Console.Write("⬜");
                break;
            case 1:
                Console.Write("⬛");
                break;
        }
    }

    // Bryta raden
    Console.WriteLine();
}

// Position för figuren
int smileyRad = 1;
int smileyKol = 1;

// Animationsloopen
while (true)
{
    // Läs in en tangenttryckning
    ConsoleKeyInfo tangent = Console.ReadKey(true);

    // Vad händer med pil-tangenterna
    switch (tangent.Key)
    {
        case ConsoleKey.RightArrow:
            // Går smiley in i en tom ruta = gång
            if (spelplan[smileyRad, smileyKol + 1] == 0)
            {
                smileyKol++;
            }
            break;
        case ConsoleKey.LeftArrow:
            if (spelplan[smileyRad, smileyKol - 1] == 0)
            {
                smileyKol--;
            }
            break;
        case ConsoleKey.UpArrow:
            if (spelplan[smileyRad - 1, smileyKol] == 0)
            {
                smileyRad--;
            }
            break;
        case ConsoleKey.DownArrow:
        if (spelplan[smileyRad + 1, smileyKol] == 0)
            {
                smileyRad++;
            }
            break;
    }

    // Rita ut smileyn
    Console.SetCursorPosition(smileyKol * 2, smileyRad);
    Console.Write("👽");
}