Console.Clear();
Console.WriteLine("Program för att skapa en veckomeny\n" + 
            "==================================\n" +
            "Det finns 2 arrayer, en för veckodagar och en för maträtter:  \n" +
            "- Den första arrayen innehåller veckodagarna\n" +
            "- Den andra arrayen för maträtterna är tom");

string[] veckodagar = {"Måndag", "Tisdag", "Onsdag", "Torsdag", "Fredag"};
string[] maträtter = new string[5]; // 0, 1, 2, 3, 4

Console.WriteLine("Skapa en veckomenyn");
Console.WriteLine("============================");
Console.WriteLine("Ange maträtterna:");

for (int i = 0; i < maträtter.Length; i++) // i = 0, 1, 2, 3, 4
{
    Console.Write($"{i + 1} {veckodagar[i]}: ");
    maträtter[i] = Console.ReadLine();
}

Console.WriteLine("Blanda i veckomenyn");
Console.WriteLine("===================");

Console.Write("Del 1. Vill du byta ut en maträtt? (j/n) ");
if (Console.ReadLine().ToLower() == "j")
{
    Console.Write("Vilken dag vill du byta maträtt på? (1-5) ");
    string svar = Console.ReadLine();

    // Tvinga användaren att mata in ett heltal annars fråga igen
    int dag = 0;
    while (true)
    {
        bool rättSvarat = int.TryParse(svar, out dag);

        if (rättSvarat)
        {
            break;
        }
        else
        {
            Console.Write("Du måste mata in ett heltal: ");
            svar = Console.ReadLine();
        }
    }

    int dag = 0;
    while (!int.TryParse(svar, out dag))
    {
        Console.Write("Du måste mata in ett heltal: ");
        svar = Console.ReadLine();
    }

    Console.Write("Ange ny maträtt för Måndag: ");
    string nyMaträtt = Console.ReadLine();
    
    maträtter[dag - 1] = nyMaträtt;
}

Console.Write("Del 2. Vill du byta plats på två dagar? (j/n)");
if (Console.ReadLine().ToLower() == "j")
{
    Console.Write("Vilken dag vill du byta plats på? (1-5) ");
    int dag1 = int.Parse(Console.ReadLine());
    Console.Write("Vilken dag vill du byta plats med? (1-5) ");
    int dag2 = int.Parse(Console.ReadLine());

    string tempDagRätt = maträtter[dag1];
    maträtter[dag1] = maträtter[dag2];
    maträtter[dag2] = tempDagRätt;
}

// Skriv ut veckomenyn
for (int i = 0; i < maträtter.Length; i++) // i = 0, 1, 2, 3, 4
{
    Console.Write($"{i + 1} {maträtter[i]}");
    
}
foreach (var maträtt in maträtter)
{
    Console.WriteLine(maträtt);
}