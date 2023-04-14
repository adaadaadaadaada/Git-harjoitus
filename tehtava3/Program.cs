// Tämän alle kaikki
using System;

Nuoli pelaajanuoli = Nuoli.Eliittinuoli();

Console.WriteLine("Valitse yksi: A) valmis nuolipohja, vai B) kustomoitu nuoli?");
string userinput0 = Console.ReadLine();
if (userinput0 == "A")
{
    Console.WriteLine("Minkälainen nuoli? (eliittinuoli, aloittelijanuoli tai perusnuoli)");
    string userinput01 = Console.ReadLine();
    
    // Pelaajan vastaus asettaa yhden näistä arvoista nuolelle
    if (userinput01 == "eliittinuoli") { pelaajanuoli = Nuoli.Eliittinuoli(); }
    if (userinput01 == "aloittelijanuoli") { pelaajanuoli = Nuoli.Aloittelijanuoli(); }
    if(userinput01 == "perusnuoli") { pelaajanuoli = Nuoli.Perusnuoli(); }
}
else if (userinput0 == "B")
{
    // Tänne kustomoitu kärki, perä ja varren pituus
    Console.WriteLine("Minkälainen kärki? (puu, teräs tai timantti): ");
    string userInput = Console.ReadLine();
    if (userInput == "puu")
    {
        pelaajanuoli.Karki = karki.puu;
    }
    if (userInput == "teräs")
    {
        pelaajanuoli.Karki = karki.teras;
    }
    if (userInput == "timantti")
    {
        pelaajanuoli.Karki = karki.timantti;
    }

    Console.WriteLine("Minkälaiset sulat? (lehti, kanansulka tai kotkansulka): ");
    string userInput2 = Console.ReadLine();
    if (userInput2 == "lehti")
    {
        pelaajanuoli.Pera = pera.lehti;
    }
    if (userInput2 == "kanansulka")
    {
        pelaajanuoli.Pera = pera.kanansulka;
    }
    if (userInput2 == "kotkansulka")
    {
        pelaajanuoli.Pera = pera.kotkansulka;
    }

    int userInput3 = 0;

    while (userInput3 < 60 || userInput3 > 100)
    {
        Console.WriteLine("Nuolen pituus (60-100cm): ");
        userInput3 = Convert.ToInt32(Console.ReadLine());

        if (userInput3 < 60)
        {
            Console.WriteLine("Liian pieni luku!");
        }
        else if (userInput3 > 100)
        {
            Console.WriteLine("Liian suuri luku!");
        }
    }

    pelaajanuoli.Varrenpituus = userInput3;
}

Console.WriteLine($"Nuolen hinta on {pelaajanuoli.GetPalautaHinta()} kultaa.");

class Nuoli
{
    public karki Karki
    {
        get; set;
    }
    public pera Pera
    {
        get; set;
    }
    public float Varrenpituus
    {
        get; set;
    }

    public Nuoli(karki karki, pera pera, float varrenpituus)
    {
        Karki = karki;
        Pera = pera;
        Varrenpituus = varrenpituus;
    }

    public Nuoli() { }

    public float GetPalautaHinta()
    {
        float hinta = 0;

        // Nuolenkärjen hinta
        if (Karki == karki.puu) {hinta += 3;}
        else if (Karki == karki.teras) {hinta += 5; }
        else if (Karki == karki.timantti) { hinta += 50;}

        // Nuolenperän hinta
        if (Pera == pera.lehti)
        {
            hinta += 0;
        }
        else if (Pera == pera.kanansulka)
        {
            hinta += 1;
        }
        else if (Pera == pera.kanansulka)
        {
            hinta += 5;
        }

        // Varren hinta
        hinta += (0.05f * Varrenpituus);
        
        return hinta;
    }

    public static Nuoli Eliittinuoli() {return new Nuoli(karki.timantti, pera.kotkansulka, 100); }
    public static Nuoli Aloittelijanuoli() { return new Nuoli(karki.puu, pera.kanansulka, 70); }
    public static Nuoli Perusnuoli() {return new Nuoli(karki.teras, pera.kanansulka, 85);}
}

internal enum karki {puu,  teras, timantti}

internal enum pera {lehti, kanansulka, kotkansulka}