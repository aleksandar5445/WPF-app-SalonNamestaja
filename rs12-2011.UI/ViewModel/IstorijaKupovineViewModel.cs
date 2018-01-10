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
    public class IstorijaKupovineViewModel : INotifyPropertyChanged
    {
        private Salon salon;
        private DatabaseAccess dbaccess;

        public IstorijaKupovineViewModel() { }

        public IstorijaKupovineViewModel(Salon s)
        {
            salon = s;
            dbaccess = new DatabaseAccess();

            if (salon.UlogovaniKorisnik.TipKorisnika == TipKorisnika.Administrator)
            {
                IstorijaKupovine = new ObservableCollection<model.IstorijaKupovine>(dbaccess.GetAllIstorijaKupovine());
            }
            else
            {
                IstorijaKupovine = new ObservableCollection<model.IstorijaKupovine>(dbaccess.GetIstorijaKupovineZaKorisnika(salon.UlogovaniKorisnik.KorisnickoIme));
            }
        }

        public ObservableCollection<IstorijaKupovine> IstorijaKupovine { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
