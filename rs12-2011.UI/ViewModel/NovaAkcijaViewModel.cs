using rs12_2011.model;
using System;
using System.Collections.Generic;
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
        }
        public NovaAkcijaViewModel() { }

        public string Naziv { get; set; }
        public DateTime DatumPocetka { get; set; }
        public DateTime DatumKraja { get; set; }
        public Dictionary<string,int> Popusti { get; set; }
        public string Aktivan { get; set; }

        public void KreirajAkciju()
        {
            viewModel.Akcije.Add(new Akcija
            {
                Naziv = Naziv,
                DatumPocetka = DatumPocetka,
                DatumKraja = DatumKraja,
                Popusti=Popusti,
                Aktivan=Aktivan
            });
        }

    }
}
