using System;

namespace ovi
{
    class Program
    {
        static void Main(string[] args)
        {
            Ovi ovenAsento = Ovi.Lukossa;
            string vastaus;

            while (true)
            {
                
                Console.WriteLine($"Ovi on {ovenAsento}. Mitä haluat tehdä?");
                vastaus = Console.ReadLine();

                // Lukossa
                if (vastaus == "Avaa lukko" && ovenAsento == Ovi.Lukossa) 
                {
                    ovenAsento = Ovi.Kiinni;
                }

                else if (vastaus == "Lukitse ovi" && ovenAsento == Ovi.Lukossa)
                {
                    ovenAsento = Ovi.Lukossa;
                }

                else if (vastaus == "Sulje ovi" && ovenAsento == Ovi.Lukossa)
                {
                    ovenAsento = Ovi.Lukossa;
                }

                else if (vastaus == "Avaa ovi" && ovenAsento == Ovi.Lukossa)
                {
                    ovenAsento = Ovi.Lukossa;
                }
                //
                // Auki
                else if (vastaus == "Avaa lukko" && ovenAsento == Ovi.Auki)
                {
                    ovenAsento = Ovi.Auki;
                }

                else if (vastaus == "Sulje ovi" && ovenAsento == Ovi.Auki)
                {
                    ovenAsento = Ovi.Kiinni;
                }

                else if (vastaus == "Lukitse ovi" && ovenAsento == Ovi.Auki)
                {
                    ovenAsento = Ovi.Auki;
                }

                else if (vastaus == "Avaa ovi" && ovenAsento == Ovi.Auki)
                {
                    ovenAsento = Ovi.Auki;
                }
                //
                // Kiinni
                else if (vastaus == "Avaa lukko" && ovenAsento == Ovi.Kiinni)
                {
                    ovenAsento = Ovi.Kiinni;
                }

                else if (vastaus == "Avaa ovi" && ovenAsento == Ovi.Kiinni)
                {
                    ovenAsento = Ovi.Auki;
                }

                else if (vastaus == "Sulje ovi" && ovenAsento == Ovi.Kiinni)
                {
                    ovenAsento = Ovi.Kiinni;
                }

                else if (vastaus == "Lukitse ovi" && ovenAsento == Ovi.Kiinni)
                {
                    ovenAsento = Ovi.Lukossa;
                }


                //
                else
                {
                    Console.WriteLine("Epäselkeä vastaus. Yritä uudelleen.");
                }
            }
            }

            enum Ovi { Auki, Kiinni, Lukossa }
        }
    }
