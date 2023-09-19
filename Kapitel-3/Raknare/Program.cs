// Program som för hälsovanor

Console.Clear();

// Frågar efter namn
Console.Write("Hej! Ange ditt namn: ");
string namn = Console.ReadLine();

// Tandborstning j/n
Console.Write("Har du borstat tänderna idag (j/n)? ");
string svar = Console.ReadLine();

// Variabel för att räkna antal ja-svar
int jaRäknare = 0;

// Kontroll
if (svar == "j")
{
    jaRäknare += 1;
}

// Frukost j/n
Console.Write("Har du ätit frukost idag (j/n)? ");
svar = Console.ReadLine();

// Kontroll
if (svar == "j")
{
    jaRäknare += 1;
}
// Motion j/n
Console.Write("Har du ätit motionerat idag (j/n)? ");
svar = Console.ReadLine();

// Kontroll
if (svar == "j")
{
    jaRäknare += 1;
}

// Resultat av frågorna
Console.WriteLine($"{namn}, du svarade ja {jaRäknare} gånger.");