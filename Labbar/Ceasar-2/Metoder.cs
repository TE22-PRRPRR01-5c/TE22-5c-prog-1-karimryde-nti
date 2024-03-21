/* ***************************
* Metoderna
* Program för att kryptera meddellande 
* med Ceasar-krypto
* Av: Karim Ryde
* Datum: 21/3-2024
****************************** */

static public class Metoder
{
    /// <summary>
    /// Skriv ut en presentation av programmet
    /// </summary>
    static public void Presentation()
    {
        Console.Clear();
        Console.WriteLine("==================================");
        Console.WriteLine("Ceasar-kryptering");
        Console.WriteLine("Detta program hjälper dig att kryptera/dekryptera dina meddelande med Ceasar-krypto");
        Console.WriteLine("==================================");
    }

    /// <summary>
    /// Visar menyn och frågar användaren vilket val hen gör
    /// </summary>
    /// <returns>val som 1, 2 eller 3</returns>
    static public string MenyVal()
    {
        Console.WriteLine("\n1. Kryptera meddelande");
        Console.WriteLine("2. Dekryptera meddelande");
        Console.WriteLine("3. Avsluta");
        Console.Write("Välj ett alternativ: ");
        return Console.ReadLine();
    }

    /// <summary>
    /// Metod för att kryptera ett meddelande med Ceasar-krypto
    /// Metoden frågar också efter en nyckel som anger skiftet i alfabetet
    /// </summary>
    static public void KrypteraMeddelande()
    {
        string meddelande = LäsInText(">>> Skriv meddelandet: ");
        int nyckel = LäsInHeltal(">>> Ange nyckel (heltal): ");

        // Loopa igenom meddelandet
        string krypteratMeddelande = "";
        foreach (var tecken in meddelande)
        {
            if (char.IsLetter(tecken))
            {
                // Skifta i alfabetet
                krypteratMeddelande += (char)(tecken + nyckel); 
            }
            else
            {
                krypteratMeddelande += tecken;
            }
        }
        Console.WriteLine($"<<< Resultat: '{krypteratMeddelande}'");
    }

    /// <summary>
    /// Metod för att kryptera ett meddelande med Ceasar-krypto
    /// Metoden frågar också efter en nyckel som anger skiftet i bakåt
    /// </summary>
    static public void DekrypteraMeddelande()
    {
        string meddelande = LäsInText("<<< Skriv meddelandet: ");
        int nyckel = LäsInHeltal("<<< Ange nyckel (heltal): ");

        // Loopa igenom meddelandet
        string krypteratMeddelande = "";
        foreach (var tecken in meddelande)
        {
            if (char.IsLetter(tecken))
            {
                // Skifta i alfabetet
                krypteratMeddelande += (char)(tecken - nyckel); 
            }
            else
            {
                krypteratMeddelande += tecken;
            }
        }
        Console.WriteLine($"<<< Resultat: '{krypteratMeddelande}'");
    }

    /// <summary>
    /// Hjälpmetod för att läsa in en text
    /// </summary>
    /// <param name="fråga">Frågan till användaren</param>
    /// <returns>texten</returns>
    static public string LäsInText(string fråga)
    {
        Console.Write(fråga);
        return Console.ReadLine();
    }

    /// <summary>
    /// Hjälpmetod för att läsa in ett heltal på säkert sätt
    /// </summary>
    /// <param name="fråga">Frågan till användaren</param>
    /// <returns>heltalet</returns>
    static public int LäsInHeltal(string fråga)
    {
        while (true)
        {
            Console.Write(fråga);
            if (int.TryParse(Console.ReadLine(), out int heltal))
            {
                return heltal;
            }
            else
            {
                Console.WriteLine("Felaktig inmatning, försök igen!");
            }
        }
    }
}
