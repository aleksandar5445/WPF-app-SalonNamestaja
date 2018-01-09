using System;

namespace rs12_2011.model
{
    public class IstorijaKupovine
    {
        public int Kolicina { get; set; }

        public DateTime DatumKupovine { get; set; }

        public virtual Korisnik Korisnik { get; set; }

        public virtual Namestaj Namestaj { get; set; }
    }
}
