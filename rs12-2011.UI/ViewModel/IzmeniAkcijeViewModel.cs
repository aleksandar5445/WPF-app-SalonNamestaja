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
    class IzmeniAkcijeViewModel : INotifyPropertyChanged
    {
        private AdministracijaAkcijeViewModel adminAV;

        public event PropertyChangedEventHandler PropertyChanged;

        public IzmeniAkcijeViewModel(AdministracijaAkcijeViewModel aak, Akcija akcija)
        {
            adminAV = aak;

            Naziv = akcija.Naziv;
            DatumPocetka = akcija.DatumPocetka;
            DatumKraja = akcija.DatumKraja;
            Aktivan = akcija.Aktivan;

            Popusti = new ObservableCollection<Tuple<string, int>>();
            foreach(var p in akcija.Popusti)
            {
                Popusti.Add(new Tuple<string, int>(p.Key, p.Value));
            }
        }

        public IzmeniAkcijeViewModel() { }

        public string Naziv { get; set; }
        public DateTime DatumPocetka { get; set; }
        public DateTime DatumKraja { get; set; }
        public ObservableCollection<Tuple<string, int>> Popusti { get; set; }
        public string Aktivan { get; set; }
        public string SifraPopusta { get; set; }
        public int PopustKolicina { get; set; }

        public void IzmeniAkciju()
        {
            Akcija ak = null;
            foreach(var a in adminAV.Akcije)
            {
                if(a.Naziv == Naziv)
                {
                    ak = a;
                }
            }

            adminAV.Akcije.Remove(ak);
            ak.DatumKraja = DatumKraja;
            ak.DatumPocetka = DatumPocetka;
            ak.Popusti = ParsirajPopuste();
            adminAV.Akcije.Add(ak);
        }

        public void KreirajPopust()
        {
            Popusti.Add(new Tuple<string, int>(SifraPopusta, PopustKolicina));
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

