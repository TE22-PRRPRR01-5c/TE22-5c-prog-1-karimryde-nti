/* ***************************
* Program för att kryptera meddellande 
* med Ceasar-krypto
* Av: Karim Ryde
* Datum: 21/3-2024
****************************** */

Metoder.Presentation();

bool avsluta = false;
while (!avsluta)
{
    switch (Metoder.MenyVal())
    {
        case "1":
            Metoder.KrypteraMeddelande();
            break;
        case "2":
            Metoder.DekrypteraMeddelande();
            break;
        case "3":
            Console.WriteLine("Programmet avslutas!");
            avsluta = true;
            break;
        default:
            Console.WriteLine("Felaktigt val, försök igen!");
            break;
    }
}