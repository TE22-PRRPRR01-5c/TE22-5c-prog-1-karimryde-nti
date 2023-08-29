// See https://aka.ms/new-console-template for more information

Console.Clear();
Console.BackgroundColor = ConsoleColor.DarkGreen;
Console.ForegroundColor = ConsoleColor.White;
Console.WriteLine("Mitt första C#-program");

Console.BackgroundColor = ConsoleColor.DarkMagenta;
Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("Hej, vad heter du? ");
string namn = Console.ReadLine();

Console.WriteLine("Hej! " + namn + ", trevligt att se dig.");

Console.ReadLine();
