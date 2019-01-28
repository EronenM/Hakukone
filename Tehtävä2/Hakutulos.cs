using System;
using System.Collections.Generic;
using System.Text;

namespace Tehtävä2
{
    public class Hakutulos
    {

        public string Hakemisto { get; set; }
        public string Tiedosto { get; set; }
        public int Rivinumero { get; set; }
        public string Teksti { get; set; }

        public Hakutulos(string hakemisto, string tiedosto, int rivinumero, string teksti)
        {
            Hakemisto = hakemisto;
            Tiedosto = tiedosto;
            Rivinumero = rivinumero;
            Teksti = teksti;
        }

        public override string ToString()
        {
            return ($"Rivi: {Rivinumero} {Tiedosto}");
        }
    }
}
