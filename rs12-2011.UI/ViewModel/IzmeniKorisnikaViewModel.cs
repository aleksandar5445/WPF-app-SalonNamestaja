using rs12_2011.model;
using rs12_2011.UI.DataAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rs12_2011.UI.ViewModel
{
    class IzmeniKorisnikaViewModel : INotifyPropertyChanged
    {
        private Salon salon;
        private DatabaseAccess databaseAccess;

        public event PropertyChangedEventHandler PropertyChanged;

        public IzmeniKorisnikaViewModel(Salon s,Korisnik korisnik)
        {
            databaseAccess = new DatabaseAccess();

            salon = s;
            Ime = korisnik.Ime;
            Lozinka = korisnik.Lozinka;
            KorisnickoIme = korisnik.KorisnickoIme;
            Prezime = korisnik.Prezime;
            TipoviKorisnika = new List<string> { "Administrator", "Prodavac" };
            TipKorisnika = korisnik.TipKorisnika.ToString();
        }

        public IzmeniKorisnikaViewModel() { }

        public string Ime { get; set; }
        public string Lozinka { get; set; }
        public string KorisnickoIme { get; set; }
        public string Prezime { get; set; }
        public string TipKorisnika { get; set; }
        public List<string> TipoviKorisnika { get; }

        public void IzmeniKorisnika()
        {
            Korisnik korisnik = null;
            foreach(var n in salon.Korisnici)
            {
                if (n.KorisnickoIme == KorisnickoIme)
                {
                    korisnik = n;
                }
            }
            if(korisnik != null)
            {
                salon.Korisnici.Remove(korisnik);
                korisnik.Ime = Ime;
                korisnik.KorisnickoIme = KorisnickoIme;
                korisnik.Lozinka = !string.IsNullOrEmpty(Lozinka) ? Lozinka : korisnik.Lozinka;
                korisnik.Prezime = Prezime;
                korisnik.TipKorisnika=(TipKorisnika)Enum.Parse(typeof(TipKorisnika), TipKorisnika);

                salon.Korisnici.Add(korisnik);
            }
            salon.UlogovaniKorisnik = korisnik;
            databaseAccess.UpdateKorisnik(korisnik);
        }



    }
}
