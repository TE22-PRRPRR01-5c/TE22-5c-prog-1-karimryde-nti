namespace Bibliotek;

public static class Metoder
{
    public static void LäggTillBok(List<string> lista)
    {
        Console.Write("Ange namnet på en bok: ");
        string boknamn = Console.ReadLine();
        lista.Add(boknamn);
    }

    public static void VisaAllaBöcker(List<string> lista)
    {
        foreach (var bok in lista)
        {
            Console.WriteLine(bok);
        }
    }

    /// <summary>
    /// Lista alla böcker som matchar en sökterm
    /// </summary>
    /// <param name="lista"></param>
    public static void SökBok(List<string> lista)
    {
        // Läser in sökterm
        Console.Write("Ange en sökterm: ");
        string sökterm = Console.ReadLine();

        // Gå igenom listan & skriv alla böcker som matchar
        foreach (var bok in lista)
        {
            // Finns sökterm i boken
            if (bok.Contains(sökterm))
            {
                Console.WriteLine($"Hittade: {bok}");
            }
        }
    }

    /// <summary>
    /// Sök bok för att kunna radera den
    /// </summary>
    /// <param name="lista"></param>
    public static void RaderaBok(List<string> lista)
    {
        // Läser in sökterm
        Console.Write("Ange en sökterm: ");
        string sökterm = Console.ReadLine();

        // Gå igenom listan & skriv alla böcker som matchar
        List<string> listaRadera = new List<string>();
        foreach (var bok in lista)
        {
            // Finns sökterm i boken
            if (bok.Contains(sökterm))
            {
                Console.WriteLine($"Hittade: {bok}");

                Console.Write($"Vill du raderna '{bok}' (j/n)?  ");
                string svar = Console.ReadLine();
                if (svar == "j")
                {
                    listaRadera.Add(bok);
                }
            }
        }

        // Gå igenom lista på böcker att radera
        foreach (var bok in listaRadera)
        {
            lista.Remove(bok);
        }
    }

    public static void SparaIFil(List<string> lista, string filnamn)
    {
        File.WriteAllLines(filnamn, lista);
    }

    public static List<string> LäsaFil(string filnamn)
    {
        return File.ReadAllLines(filnamn).ToList();
    }

}
