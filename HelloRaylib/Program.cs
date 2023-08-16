using System.Numerics;
using Raylib_cs;

Console.WriteLine("Hello, World!");

// Skapa ett fönster
Raylib.InitWindow(800, 600, "Hello, World!");

// Spel-loop
while (!Raylib.WindowShouldClose())
{
    // Rensa skärmen
    Raylib.BeginDrawing();
    Raylib.ClearBackground(Color.RAYWHITE);

    // Rita en text
    Raylib.DrawText("Hello, World!", 12, 12, 20, Color.BLACK);

    // Rita en cirkel
    Raylib.DrawCircle(400, 300, 100, Color.RED);

    // Rita en rektangel
    Raylib.DrawRectangle(400, 300, 100, 100, Color.BLUE);

    // Rita en linje
    Raylib.DrawLine(0, 0, 800, 600, Color.GREEN);

    Raylib.EndDrawing();

}