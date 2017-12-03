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
    class NovaAkcijaViewModel : INotifyPropertyChanged
    {
        AdministracijaAkcijeViewModel viewModel;
        public event PropertyChangedEventHandler PropertyChanged;

        public NovaAkcijaViewModel(AdministracijaAkcijeViewModel adm)
        {
            viewModel = adm;
            Popusti = new ObservableCollection<Tuple<string, int>>();
        }
        public NovaAkcijaViewModel() { }

        public string Naziv { get; set; }
        public DateTime DatumPocetka { get; set; } = DateTime.Now;
        public DateTime DatumKraja { get; set; } = DateTime.Now;
        public ObservableCollection<Tuple<string, int>> Popusti { get; set; }
        public string Aktivan { get; set; }
        public string SifraPopusta { get; set; }
        public int PopustKolicina { get; set; }

        public void KreirajAkciju()
        {
            viewModel.Akcije.Add(new Akcija
            {
                Naziv = Naziv,
                DatumPocetka = DatumPocetka,
                DatumKraja = DatumKraja,
                Popusti=ParsirajPopuste(),
                Aktivan=Aktivan
            });
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

    }
}
