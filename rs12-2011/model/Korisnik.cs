namespace rs12_2011.model
{
    public class Korisnik
    {
        public string Aktivan { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string KorisnickoIme { get; set; }
        public string Lozinka { get; set; }
        public TipKorisnika TipKorisnika { get; set; }
    }

    public enum TipKorisnika
    {
        Administrator, Prodavac
    }
}
