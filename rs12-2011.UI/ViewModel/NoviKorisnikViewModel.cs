using rs12_2011.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rs12_2011.UI.ViewModel
{
    class NoviKorisnikViewModel : INotifyPropertyChanged
    {
        private Salon salon;

        public NoviKorisnikViewModel()
        {
        }

        public NoviKorisnikViewModel(Salon s)
        {
            salon = s;

            TipoviKorisnika = new List<string> { "Administrator", "Prodavac" };
            TipKorisnika = TipoviKorisnika[0];
        }

        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string KorisnickoIme { get; set; }
        public string TipKorisnika { get; set; }
        public List<string> TipoviKorisnika { get; }

        public void KreirajKorisnika(string lozinka)
        {
            salon.Korisnici.Add(new Korisnik
            {
                Ime = Ime,
                KorisnickoIme = KorisnickoIme,
                Lozinka = lozinka,
                Prezime = Prezime,
                TipKorisnika = (TipKorisnika)Enum.Parse(typeof(TipKorisnika), TipKorisnika)
            });
        }

        public string Validacija(string password1, string password2)
        {

            if (string.IsNullOrEmpty(KorisnickoIme))
            {
                return "Korisnicko ime je obavezno";
            }

            foreach (var k in salon.Korisnici)
            {
                if (k.KorisnickoIme == KorisnickoIme)
                {
                    return "Korisnik vec postoji";
                }
            }

            if (string.IsNullOrEmpty(password1))
            {
                return "Lozinka je obavezna";
            }

            if (string.IsNullOrEmpty(password2) && !string.IsNullOrEmpty(password1))
            {
                return "Molimo vas ponovite lozinku";
            }

            if (password1 != password2)
            {
                return "Lozinke se ne poklapaju";
            }

            return string.Empty;
        }


        public event PropertyChangedEventHandler PropertyChanged;
    }
}
