Console.Clear();
Console.WriteLine("Citatgenerator");

// Läs in textfilen
List<string> rader = File.ReadAllLines("quotes.txt").ToList<string>();
List<string> citatLista = new List<string>();

// Loopa igenom raderna
string citat = "";
foreach (var rad in rader)
{
    if (rad != "")
    {
        citat += rad;
    }
    else
    {
        citatLista.Add(citat);
        citat = "";
    }
}

Console.WriteLine($"Antal citat: {citatLista.Count}");
