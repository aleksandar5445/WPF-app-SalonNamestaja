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
    class NovaAkcijaViewModel : INotifyPropertyChanged
    {
        private Salon salon = null;
        private DatabaseAccess database = null;
        AdministracijaAkcijeViewModel viewModel;


        public NovaAkcijaViewModel(AdministracijaAkcijeViewModel adm,Salon s)
        {
            salon = s;
            database = new DatabaseAccess();
            viewModel = adm;
            Popusti = new ObservableCollection<Tuple<string, int>>();
            Magacin = new ObservableCollection<Namestaj>(salon.Magacin);
        }
        public NovaAkcijaViewModel() { }

        public string Naziv { get; set; }
        public DateTime DatumPocetka { get; set; } = DateTime.Now;
        public DateTime DatumKraja { get; set; } = DateTime.Now;
        public ObservableCollection<Tuple<string, int>> Popusti { get; set; }
        public string Aktivan { get; set; }
        public string SifraPopusta { get; set; }
        public int PopustKolicina { get; set; }
        public ObservableCollection<Namestaj> Magacin { get; set;}

        public void KreirajAkciju()
        {
            var nova = new Akcija
            {
                Naziv = Naziv,
                DatumPocetka = DatumPocetka,
                DatumKraja = DatumKraja,
                Popusti = ParsirajPopuste(),
                Aktivan = Aktivan
            };
            viewModel.Akcije.Add(nova);

            database.InsertAkcija(nova);
        }

        public void KreirajPopust()
        {
            Popusti.Add(new Tuple<string, int> (SifraPopusta, PopustKolicina));
        }

        private Dictionary<string, int> ParsirajPopuste()
        {
            var temp = new Dictionary<string, int>();
            foreach (var p in Popusti)
            {
                temp.Add(p.Item1, p.Item2);
            }

            return temp;
        }
        public event PropertyChangedEventHandler PropertyChanged;

    }
}
