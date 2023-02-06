using System;

namespace ruokaannos
{
    class Program
    {
        static void Main(string[] args)
        {
            (paaruoka paaruokaPaaruoka, lisuke lisukeLisuke, kastike kastikeKastike) annos = (paaruoka.Kanaa, lisuke.Perunoita, kastike.Pippuri);


            // Kysytään pelaajalta ainesosat annokseen.
            Console.Write("Pääraaka-aine (kana, nauta, kala): ");
            string playerInput = Console.ReadLine();

            if (playerInput == "kana")
            {
                annos.paaruokaPaaruoka = paaruoka.Kanaa;
            }
            else if (playerInput == "nauta")
            {
                annos.paaruokaPaaruoka = paaruoka.Nautaa;
            }
            else if (playerInput == "kala")
            {
                annos.paaruokaPaaruoka = paaruoka.Kalaa;
            }

            Console.Write("Lisuke (perunaa, kasvikset, pastaa): ");
            string playerInput2 = Console.ReadLine();

            if (playerInput == "perunaa")
            {
                annos.lisukeLisuke = lisuke.Perunoita;
            }
            else if (playerInput == "kasvikset")
            {
                annos.lisukeLisuke = lisuke.Kasviksia;
            }
            else if (playerInput == "pastaa")
            {
                annos.lisukeLisuke = lisuke.Pastaa;
            }

            Console.Write("Kastike (pippuri, chili, tomaatti): ");
            string playerInput3 = Console.ReadLine();

            if (playerInput == "pippuri")
            {
                annos.kastikeKastike = kastike.Pippuri;
            }
            else if (playerInput == "chili")
            {
                annos.kastikeKastike = kastike.Chili;
            }
            else if (playerInput == "tomaatti")
            {
                annos.kastikeKastike = kastike.Tomaatti;
            }

            // Koko annos
            Console.WriteLine($"{annos.paaruokaPaaruoka} ja {annos.lisukeLisuke} {annos.kastikeKastike}-kastikkeella");
        }
    }

    enum paaruoka { Kanaa, Nautaa, Kalaa }
    enum lisuke { Perunoita, Kasviksia, Pastaa}
    enum kastike { Pippuri, Chili, Tomaatti}
}
