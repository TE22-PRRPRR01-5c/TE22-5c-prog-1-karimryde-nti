/* ************************************************
 * **************** Metoder ***********************
 ************************************************* */
static public class Metoder
{
    static public void Presentation()
    {
        Console.Clear();
        Console.WriteLine("Välkommen till den stora äggjakten!");
        Console.WriteLine("Lycka till men förätt dig inte!");
    }

    static public void VisaMeny()
    {
        Console.WriteLine("1. Hitta påskägg");
        Console.WriteLine("2. Äta påskägg");
        Console.WriteLine("3. Visa antal påskägg");
        Console.WriteLine("4. Avsluta");
        Console.Write("Vad väljer du? ");
    }

    static public int HittaPåskägg(int antal)
    {
        int slumptal = Random.Shared.Next(0, 6); // Slumpar 0-5
        antal += slumptal;
        Console.WriteLine($"Du hittade {slumptal} påskägg");
        return antal;
    }

    static public int ÄtaPåskägg(int antal)
    {
        int slumptal = Random.Shared.Next(1, 4); // Slumpar 0-3

        if (slumptal <= antal)
        {
            antal -= slumptal;
            Console.WriteLine($"Du har ätit {slumptal} påskägg");
        }
        else
        {
            antal = 0;
            Console.WriteLine($"Du har ätit alla dina påskägg");
        }

        if (antal >= 3)
        {
            Console.WriteLine($"Oj, nu får du ont i magen!");
        }

        return antal;
    }

    static public void VisaAntalPåskägg(int antal)
    {
        Console.WriteLine($"Du har {antal} påskägg kvar i korgen");
    }
}
