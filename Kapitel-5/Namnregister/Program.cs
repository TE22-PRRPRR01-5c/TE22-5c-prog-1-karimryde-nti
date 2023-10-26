// Register på namn uatn dubletter
Console.Clear();
Console.WriteLine("Register på namn utan dubletter");

// Be användaren mata in antalet personer
Console.Write("Hur många namn vill du registrera? ");
int antalNamn = int.Parse(Console.ReadLine());

// Skapa en tom array på antalet namn
string[] namnlista = new string[antalNamn];

// Registrera alla namn
int i = 0;
while (i < antalNamn)
{
    Console.Write($"Ange ett namn: ");
    string input = Console.ReadLine();

    // Finns namnet redan i arrayen?
    bool hittad = false;
    foreach (var namn in namnlista)
    {
        if (namn == input)
        {
            hittad = true;
        }
    }

    // Har vi inte hittat namnet så lägger vi till namnet
    if (!hittad)
    {
        namnlista[i] = input;
    }
    i++;
}
