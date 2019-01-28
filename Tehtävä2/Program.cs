using System;
using System.Collections.Generic;
using System.IO;

//Tämä ohjelma hakee annettua sanaa annetusta hakemistosta ja sen alahakemistoista löytyvistä txt ja cs tiedostoista


namespace Tehtävä2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool tila = true;

            while (tila)
            {
                Console.Write("Anna hakemisto: ");
                string hakemisto = Console.ReadLine();
                bool valinta = Hakumoottori.Exists(hakemisto);

                if (valinta)
                {
                    Console.Write("Anna haettava merkkijono: ");
                    string teksti = Console.ReadLine();
                    List<Hakutulos> ht = Hakumoottori.Hae(hakemisto, teksti);

                    foreach (var item in ht)
                    {
                        Console.WriteLine(item);
                    }

                    string vastaus = "";
                    while (vastaus != "k" || vastaus != "e" || vastaus != "kyllä" || vastaus != "ei")
                    {
                        Console.WriteLine("Uusi haku? Kyllä/Ei?");
                        vastaus = Console.ReadLine().ToLower().ToString();
                        if (vastaus == "k" || vastaus == "kyllä")
                        {
                            tila = true;
                            Console.Clear();
                            break;
                        }
                        else if (vastaus == "e" || vastaus == "ei")
                            tila = false;
                        Console.WriteLine("Suljetaan ohjelma");
                        break;
                    }
                }
                else
                    tila = true;
            }
        }
    }
}
