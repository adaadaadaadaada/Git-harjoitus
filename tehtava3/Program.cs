// Tämän alle kaikki
using System;

Nuoli pelaajanuoli = new Nuoli();

Console.WriteLine("Minkälainen kärki? (puu, teräs tai timantti): ");
string userInput = Console.ReadLine();
if (userInput == "puu")
{
    pelaajanuoli.SetKarki(karki.puu);
}
if (userInput == "teräs")
{
    pelaajanuoli.SetKarki(karki.teras);
}
if (userInput == "timantti")
{
    pelaajanuoli.SetKarki(karki.timantti);
}

Console.WriteLine("Minkälaiset sulat? (lehti, kanansulka tai kotkansulka): ");
string userInput2 = Console.ReadLine();
if (userInput2 == "lehti")
{
    pelaajanuoli.SetPera(pera.lehti);
}
if (userInput2 == "kanansulka")
{
    pelaajanuoli.SetPera(pera.kanansulka);
}
if (userInput2 == "kotkansulka")
{
    pelaajanuoli.SetPera(pera.kotkansulka);
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

pelaajanuoli.SetVarsi(userInput3);

Console.WriteLine($"Nuolen hinta on {pelaajanuoli.GetPalautaHinta()} kultaa.");

class Nuoli
{
    private karki nuolenkarki;
    private pera nuolenpera;
    private int nuolenvarsi;

    public float GetPalautaHinta()
    {
        float hinta = 0;

        // Nuolenkärjen hinta
        if (nuolenkarki == karki.puu)
        {
            hinta += 3;
        }
        else if (nuolenkarki == karki.teras)
        {
            hinta += 5;
        }
        else if (nuolenkarki == karki.timantti)
        {
            hinta += 50;
        }

        // Nuolenperän hinta
        if (nuolenpera == pera.lehti)
        {
            hinta += 0;
        }
        else if (nuolenpera == pera.kanansulka)
        {
            hinta += 1;
        }
        else if (nuolenpera == pera.kanansulka)
        {
            hinta += 5;
        }

        // Varren hinta
        hinta += (0.05f * nuolenvarsi);
        
        return hinta;
    }

    public karki GetKarki()
    {
        return nuolenkarki;
    }

    public pera GetPera()
    {
        return nuolenpera;
    }

    public int GetNuolenvarsi()
    {
        return nuolenvarsi;
    }

    public void SetKarki(karki karki)
    {
        nuolenkarki = karki;
    }

    public void SetPera(pera pera)
    {
        nuolenpera = pera;
    }

    public void SetVarsi(int varsi)
    {
        nuolenvarsi = varsi;
    }
}



internal enum karki {puu,  teras, timantti}

internal enum pera {lehti, kanansulka, kotkansulka}