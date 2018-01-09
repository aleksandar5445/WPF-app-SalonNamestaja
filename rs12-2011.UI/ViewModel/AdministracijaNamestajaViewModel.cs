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
    public class AdministracijaNamestajaViewModel : INotifyPropertyChanged
    {
        private Salon salon = null;
        private DatabaseAccess database = null;
        private ObservableCollection<Namestaj> magacin;
        private Namestaj selektovaniNamestaj = null;

        public AdministracijaNamestajaViewModel(Salon s)
        {
            salon = s;
            database = new DatabaseAccess();

            magacin = new ObservableCollection<Namestaj>(salon.Magacin);
        }

        public AdministracijaNamestajaViewModel()
        {
        }

        public ObservableCollection<Namestaj> Magacin
        {
            get
            {
                return magacin;
            }
        }

        public Namestaj SelektovaniNamestaj
        {
            get
            {
                return selektovaniNamestaj;
            }

            set
            {
                selektovaniNamestaj = value;
            }
        }

        public void ObrisiNamestaj(Namestaj namestaj)
        {
            if (namestaj != null)
            {
                Magacin.Remove(namestaj);

                namestaj.Aktivan = "Neaktivan";

                Magacin.Add(namestaj);
            }

            database.UpdateNamestaj(namestaj);
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
