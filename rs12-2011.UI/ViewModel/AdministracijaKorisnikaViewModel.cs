using rs12_2011.model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace rs12_2011.UI.ViewModel
{
    class AdministracijaKorisnikaViewModel : INotifyPropertyChanged
    {
        private Salon salon = null;
        private ObservableCollection<Korisnik> korisnici;

        public AdministracijaKorisnikaViewModel(Salon s)
        {
            salon = s;
            korisnici = new ObservableCollection<Korisnik>(salon.Korisnici);
        }
        public AdministracijaKorisnikaViewModel()
        {

        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
