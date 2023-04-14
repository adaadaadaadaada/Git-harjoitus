using System;

Robotti robotti = new Robotti();

for (int i = 0; i < robotti.Käskyt.Length; i++)
{
    Console.WriteLine("Mitä komentoja syötetään robotille? Vaihtoehdot: Käynnistä, Sammuta, Ylös, Alas, Oikea, Vasen.");
    string userinput =  Console.ReadLine();

    if (userinput == "Käynnistä") { robotti.Käskyt[i] = new Käynnistä(); }
    if (userinput == "Sammuta") { robotti.Käskyt[i] = new Sammuta(); }
    if (userinput == "Ylös") { robotti.Käskyt[i] = new YlösKäsky(); }
    if (userinput == "Alas") { robotti.Käskyt[i] = new AlasKäsky(); }
    if (userinput == "Oikea") { robotti.Käskyt[i] = new OikeaKäsky(); }
}

robotti.Suorita(robotti);

// Jokaisen kysymyksen jälkeen käskyt - 1 (pelaaja saa antaa vain 3 käskyä robotille)

public class Robotti: IRobottiKäsky
{
    public int X { get; set; }
    public int Y { get; set; }
    public bool OnKäynnissä { get; set; }
    public IRobottiKäsky?[] Käskyt { get; } = new IRobottiKäsky?[3];

    public void Suorita(Robotti robotti)
    {
        foreach (IRobottiKäsky? käsky in Käskyt)
        {
            käsky?.Suorita(this);
            Console.WriteLine($"[{X} {Y} {OnKäynnissä}]");
        }
    }
}

public interface IRobottiKäsky
{
    void Suorita(Robotti robotti);
}

class Käynnistä : IRobottiKäsky
{
    public void Suorita(Robotti robotti)
    {
        robotti.OnKäynnissä = true;
    }
}
class Sammuta : IRobottiKäsky
{
    public void Suorita(Robotti robotti)
    {
        robotti.OnKäynnissä = false;
    }
}

class YlösKäsky : IRobottiKäsky
{
    public void Suorita(Robotti robotti)
    {
        if (robotti.OnKäynnissä) { robotti.Y++; }
    }
}
class AlasKäsky : IRobottiKäsky
{
    public void Suorita(Robotti robotti)
    {
        if (robotti.OnKäynnissä) { robotti.Y--;  }
    }
}
class VasenKäsky : IRobottiKäsky
{
    public void Suorita(Robotti robotti)
    {
        if (robotti.OnKäynnissä) { robotti.X--; }
    }
}
class OikeaKäsky : IRobottiKäsky
{
    public void Suorita(Robotti robotti)
    {
        if (robotti.OnKäynnissä) { robotti.X++; }
    }
}