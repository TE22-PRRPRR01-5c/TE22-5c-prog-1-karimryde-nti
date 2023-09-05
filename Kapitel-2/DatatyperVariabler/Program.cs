// Roligt program om när jag tar examen

Console.Clear();

// Läs in namnet
Console.Write("Vad heter du? "); 
string namn = Console.ReadLine();

// Läs in ålder
Console.Write("Hur gammal är du? ");
string ålder = Console.ReadLine();

// Konvertera från text till tal
int ålderHeltal = int.Parse(ålder);

// Räkna ut ålder vid examen
int ålderVidExamen = ålderHeltal + 1;

// Skriv ut hur gammal man är vid examen
Console.WriteLine("När du " + namn + " tar examen är du " + ålderVidExamen + " år!");

// Hur lång är du?
Console.Write("Hur lång är du i meter? ");
string längdString = Console.ReadLine();

// Konvertera till decimaltal
double längd = double.Parse(längdString);

// Omvandla till centimeter
längd = längd * 100;

// Skriv ut ett svar
//Console.WriteLine("Du är " + längd + " cm lång!");
Console.WriteLine($"Du är {längd} cm lång");