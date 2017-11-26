using rs12_2011.model;
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
        private AdministracijaKorisnikaViewModel adminKM;

        public event PropertyChangedEventHandler PropertyChanged;

        public IzmeniKorisnikaViewModel(AdministracijaKorisnikaViewModel adk,Korisnik korisnik)
        {
            adminKM = adk;

            Ime = korisnik.Ime;
            Lozinka = korisnik.Lozinka;
            KorisnickoIme = korisnik.KorisnickoIme;
            Prezime = korisnik.Prezime;
            TipKorisnika = korisnik.TipKorisnika;
        }

        public IzmeniKorisnikaViewModel() { }

        public string Ime { get; set; }
        public string Lozinka { get; set; }
        public string KorisnickoIme { get; set; }
        public string Prezime { get; set; }
        public TipKorisnika TipKorisnika { get; set; }

        public void IzmeniKorisnika()
        {
            Korisnik korisnik = null;
            //foreach (var n in adminKM.)
        }



    }
}
