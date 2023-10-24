// Register på länder
Console.Clear();
Console.WriteLine("Program för att registrera länder");

// Skapar en array för att lagra 3 länder
string[] länder = new string[3];

/* // Registrera land 1
Console.Write("Ange land 1: ");
länder[0] = Console.ReadLine();

// Registrera land 2
Console.Write("Ange land 2: ");
länder[1] = Console.ReadLine();

// Registrera land 3
Console.Write("Ange land 3: ");
länder[2] = Console.ReadLine();

// Skriv ut alla 3 länder 
Console.WriteLine($"Du har registrerat länderna: {länder[0]}, {länder[1]}, {länder[2]}"); */

// Registrera alla 3 länder
int index = 0;
while (true)
{
    Console.Write($"Ange land {index + 1}: ");
    länder[index] = Console.ReadLine();

    // Räkna upp indexet
    index++;

    // Bryt loopen när vi överstiger arrayens längd
    if (index == länder.Length)
    {
        break;
    }
}

// Utskrift av alla länder på en rad med komma emmellan mha while-loop
index = 0;
while (index < länder.Length)
{
    Console.Write($"{länder[index]}, ");

    // Räkna upp indexet
    index++;
}

// Alternativ 2: använda en for-loop
for (int i = 0; i < länder.Length; i++)
{
    Console.Write($"{länder[i]}, ");
}