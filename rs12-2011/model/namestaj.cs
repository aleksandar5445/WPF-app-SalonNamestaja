namespace rs12_2011.model
{
    public class Namestaj
    {
        private bool aktivan = true;

        public string Naziv { get; set; }
        public string Sifra { get; set; }
        public decimal JedinicnaCena { get; set; }
        public long KolicinaUMagacinu { get; set; }
        public TipNamestaja TipNamestaja { get; set; }
        public string Aktivan {
            get
            {
                return aktivan? "Aktivan" : "Neaktivan";
            }

            set
            {
                aktivan = value == "Aktivan" ? true : false;
            }
        }
    }

    public enum TipNamestaja
    {
        Kreveti, Predsoblje, Kuhinja
    }
}
