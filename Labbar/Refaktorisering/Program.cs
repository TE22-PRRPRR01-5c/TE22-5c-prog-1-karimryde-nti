bool kör = true;

while (kör)
{
    VisaMeny();
    string val = Console.ReadLine();

    switch (val)
    {
        case 1:
            Console.Write("Ange cirkelns radie: ");
            string radieStr = Console.ReadLine();
            int radie;
            while (!int.TryParse(radieStr, out radie))
            {
                Console.Write("Ange ett giltigt nummer för radien: ");
                radieStr = Console.ReadLine();
            }
            Console.WriteLine($"Arean av cirkeln är: {Math.PI * radie * radie}");
            break;
        case 2:
            Console.Write("Ange cirkelns radie: ");
            radieStr = Console.ReadLine();
            while (!int.TryParse(radieStr, out radie))
            {
                Console.Write("Ange ett giltigt nummer för radien: ");
                radieStr = Console.ReadLine();
            }
            Console.WriteLine($"Omkretsen av cirkeln är: {2 * Math.PI * radie}");
            break;
        case 3:
            kör = false;
            break;
        default:
            Console.WriteLine("Ogiltigt alternativ.");
            break;
    }
}

/* ************************************** */
/* ************ Metoder ***************** */
/* ************************************** */
static void VisaMeny()
{
    Console.WriteLine("\nVälj ett alternativ:");
    Console.WriteLine("1. Beräkna area av en cirkel");
    Console.WriteLine("2. Beräkna omkrets av en cirkel");
    Console.WriteLine("3. Avsluta");
    Console.Write("Ditt val: ");
}