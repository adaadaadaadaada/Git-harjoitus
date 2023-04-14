using System;

reppu oletusReppu = new reppu();
reppu uusireppu = new reppu(50, 50, 50);

while (true)
{
    // Console.WriteLine($"Repussa on tällä hetkellä {}/10 tavaraa, {}/30 painoa, ja {}/20 tilavuus.");
    Console.WriteLine("Mitä haluat lisätä?");
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

class nuoli : tavara { public nuoli() : base(0.05f, 0.1f) { } }
class jousi : tavara { public jousi() : base(4, 1) { } }
class koysi : tavara { public koysi() : base(1.5f, 1) { } }
class vesi : tavara { public vesi() : base(2, 2) { } }
class ruokaannos : tavara { public ruokaannos() : base(0.5f, 1) { } }
class miekka : tavara { public miekka() : base(3, 5) { } }

class reppu
{
    tavara[] tavarat;

    int maxTavara;
    float maxTilavuus;
    float maxPaino;

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
        for (int i = 0; i < tavarat.Length; i++)
        {
            if (tavarat[i] == null)
            {
                tavarat[i] = tavara;
                Console.WriteLine("Tavara lisätty.");
            }
            else
            {
                return false;
            }
        }
        return true;
    }

}
