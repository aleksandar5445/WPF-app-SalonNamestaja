using System;
using System.Collections.Generic;

namespace rs12_2011.model
{
    public class Akcija
    {
        private bool aktivan = true;

        public string Naziv { get; set; }
        public DateTime DatumPocetka { get; set; }
        public DateTime DatumKraja { get; set; }
        public Dictionary<string, int> Popusti { get; set; } //<sifra_namestaja, popust>
        public string Aktivan
        {
            get
            {
                return aktivan ? "Aktivan" : "Neaktivan";
            }

            set
            {
                aktivan = value == "Aktivan" ? true : false;
            }
        }
    }
}
