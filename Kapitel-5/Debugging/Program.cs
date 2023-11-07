// Skriv ut namn i en array
Console.Clear();
Console.WriteLine("Skriv ut namn i en array");

// Skapar en array med 5 platser
string[] namnen = new string[5];

// Fylla arrayen med namn
namnen[0] = "Patric";
namnen[1] = "Patricia";
namnen[2] = "Kalle";
namnen[3] = "Jonas";
namnen[4] = "Aaron";

// Skriv ut alla namnen
foreach (var namnet in namnen)
{
    Console.WriteLine(namnet);
}