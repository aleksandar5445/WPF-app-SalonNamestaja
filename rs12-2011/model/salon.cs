using System;
using System.Collections.Generic;

namespace rs12_2011.model
{
    public class Salon
    {
        public Salon()
        {
            Magacin = new List<Namestaj>();
            Korpa = new List<Tuple<Namestaj, int>>();
            Korisnici = new List<Korisnik>();

            Aktivan = true;
        }

        public string Naziv { get; set; }
        public string Adresa { get; set; }
        public string Telefon { get; set; }
        public string Mail { get; set; }
        public string Sajt { get; set; }
        public string PIB { get; set; }
        public string MaticniBr { get; set; }
        public string ZiroRacun { get; set; }
        public bool Aktivan { get; set; }

        public List<Namestaj> Magacin { get; set; }
        public List<Korisnik> Korisnici { get; set;}
        public List<Tuple<Namestaj, int>> Korpa { get; set; }
    }
}
