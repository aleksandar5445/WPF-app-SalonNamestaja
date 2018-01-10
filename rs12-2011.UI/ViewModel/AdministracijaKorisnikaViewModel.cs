using rs12_2011.model;
using rs12_2011.UI.DataAccess;
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
        private DatabaseAccess database = null;

        public AdministracijaKorisnikaViewModel(Salon s)
        {
            salon = s;
            database = new DatabaseAccess();
            korisnici = new ObservableCollection<Korisnik>(salon.Korisnici);
        }
        public AdministracijaKorisnikaViewModel()
        {

        }

        public ObservableCollection<Korisnik> Korisnik
        {
            get
            {
                return korisnici;
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
