using rs12_2011.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rs12_2011.UI.ViewModel
{
    public class LoginViewModel : INotifyPropertyChanged
    {
        private Salon salon;
        public LoginViewModel(Salon s)
        {
            salon = s;
        }

        public LoginViewModel() { }

        public string KorisnickoIme { get; set; }

        public bool LoginKorisnik(string lozinka)
        {

            foreach(var k in salon.Korisnici)
            {
                if(k.KorisnickoIme == KorisnickoIme && k.Lozinka == lozinka)
                {
                    return true;
                }
            }

            return false;
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
