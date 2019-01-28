using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Tehtävä2
{
    class Hakumoottori
    {
        public static List<Hakutulos> lista;

        public static void Kyselijä()
        {
            Console.Write("Anna hakemisto: ");
            string hakemisto = Console.ReadLine();

            Console.Write("Anna haettava merkkijono: ");
            string teksti = Console.ReadLine();
        }

        public static bool Exists(string path)
        {
            if (Directory.Exists(path))
                return true;
            else
                Console.WriteLine("Annettua polkua ei ole olemassa, anna uusi polku:");
            return false;
        }

        public static List<Hakutulos> Hae(string hakemisto, string teksti)
        {
            lista = new List<Hakutulos>();

            string[] tiedostot = Directory.GetFiles(hakemisto, "*", SearchOption.AllDirectories);

            var tiedosto = from n in tiedostot
                           where n.Contains(".txt") || n.Contains(".cs")
                           select n;

            foreach (var item in tiedosto)
            {
                StreamReader sr = new StreamReader(item);
                int counter = 1;
                string rivi = sr.ReadLine();
                while (rivi != null)
                {
                    if (rivi.Contains(teksti))
                    {
                        lista.Add(new Hakutulos(hakemisto, item, counter, teksti));
                    }
                    counter++;
                    rivi = sr.ReadLine();
                }
            }
            return lista;
        }
    }
}
