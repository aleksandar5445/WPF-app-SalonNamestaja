using System;
using System.Collections.Generic;

namespace rs12_2011.model
{
    public class ProdajaNamestaja
    {
        public string Kupac { get; set; }
        public string BrojRacuna { get; set; }
        public DateTime DatumProdaje { get; set; }
        public decimal UkupnaCena { get; set; }
        public List<Namestaj> Namestaj { get; set; }
        public Usluga DodatneUsluge { get; set; }
        public bool Aktivan { get; set; }
    }

    public enum Usluga
    {
        Dostava, Montaza
    }
}
