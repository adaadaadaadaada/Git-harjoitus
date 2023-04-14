using System;


reppu uusireppu = new reppu(50, 50, 50);

while (true)
{
    Console.WriteLine($"Repussa on tällä hetkellä {uusireppu.currentTavara}/{uusireppu.maxTavara} tavaraa, {uusireppu.currentPaino}/{uusireppu.maxPaino} painoa, ja {uusireppu.currentTilavuus}/{uusireppu.maxTilavuus} tilavuus.");
    Console.WriteLine(uusireppu.ToString());
    Console.WriteLine("Mitä haluat lisätä?");
    Console.WriteLine($"1 - Nuoli");
    Console.WriteLine($"2 - Jousi");
    Console.WriteLine($"3 - Köysi");
    Console.WriteLine($"4 - Vettä");
    Console.WriteLine($"5 - Ruokaa");
    Console.WriteLine($"6 - Miekka");
    string userInput = Console.ReadLine();

    if (userInput == "1") { uusireppu.Lisää(new nuoli()); }
    if (userInput == "2") { uusireppu.Lisää(new jousi()); }
    if (userInput == "3") { uusireppu.Lisää(new koysi()); }
    if (userInput == "4") { uusireppu.Lisää(new vesi()); }
    if (userInput == "5") { uusireppu.Lisää(new ruokaannos()); }
    if (userInput == "6") { uusireppu.Lisää(new miekka()); }
}

class tavara
{
    public float Paino { get; set; }
    public float Tilavuus { get; set; }

    public tavara(float tilavuus, float paino)
    {
        Paino = paino;
        Tilavuus = tilavuus;
    }
}

class nuoli : tavara { public nuoli() : base(0.05f, 0.1f) { }
    public override string ToString() { return "nuoli"; }
}
class jousi : tavara { public jousi() : base(4, 1) { }
    public override string ToString() { return "jousi"; }
}
class koysi : tavara { public koysi() : base(1.5f, 1) { }
    public override string ToString() { return "köysi"; }
}
class vesi : tavara { public vesi() : base(2, 2) { }
    public override string ToString() { return "vettä"; }
}
class ruokaannos : tavara { 
    public ruokaannos() : base(0.5f, 1) { }
    public override string ToString() { return "ruokaa"; }
}
class miekka : tavara { 
    public miekka() : base(3, 5) { }
    public override string ToString() { return "miekka"; }
}

class reppu
{

    public tavara[] tavarat;

    public int maxTavara;
    public float maxTilavuus;
    public float maxPaino;
    public int currentTavara = 0;
    public float currentTilavuus = 0;
    public float currentPaino = 0;

    public reppu()
    {
        maxTavara = 10;
        maxTilavuus = 20;
        maxPaino = 30;
        
        tavarat = new tavara[maxTavara];
    }

    public reppu(int maxTavara, float maxTilavuus, float maxPaino)
    {
        this.maxTavara = maxTavara;
        this.maxTilavuus = maxTilavuus;
        this.maxPaino = maxPaino;
        tavarat = new tavara[maxTavara];
    }

    public bool Lisää(tavara tavara)
    {
         if (currentTavara  >= maxTavara)
        {
            return false;
        }
         else
        {
            if (currentPaino >= maxPaino || currentTilavuus >= maxTilavuus)
            {
                Console.WriteLine("Reppu täynnä");
                return false;
            }
            else
            {
                tavarat[currentTavara] = tavara;
                currentTavara++;
                currentPaino += tavara.Paino;
                currentTilavuus += tavara.Tilavuus;
                return true;
            }
        }
    }

    public override string ToString()
    {
        string repunSisältö = "Repussa on: ";

        for (int i = 0; i < tavarat.Length; i++)
        {
            if (tavarat[i] != null)
            {
                repunSisältö += tavarat[i].ToString() + " ";
            }
        }

        return repunSisältö;
    }
}
