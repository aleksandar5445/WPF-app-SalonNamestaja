using rs12_2011.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rs12_2011.UI.ViewModel
{
    public class NoviNamestajViewModel : INotifyPropertyChanged
    {
        private AdministracijaNamestajaViewModel adminVM;

        public event PropertyChangedEventHandler PropertyChanged;

        public NoviNamestajViewModel(AdministracijaNamestajaViewModel adm)
        {
            adminVM = adm;
        }

        public NoviNamestajViewModel() { }

        public string Naziv { get; set; }
        public string Sifra { get; set; }
        public decimal JedinicnaCena { get; set; }
        public long KolicinaUMagacinu { get; set; }
        public string TipNamestaja { get; set; }

        public void KreirajNoviNamestaj()
        {
            adminVM.Magacin.Add(new Namestaj
            {
                Naziv = Naziv,
                JedinicnaCena = JedinicnaCena,
                Sifra = Sifra,
                KolicinaUMagacinu = KolicinaUMagacinu,
                TipNamestaja = (TipNamestaja)Enum.Parse(typeof(TipNamestaja), TipNamestaja)
            });
        }
    }
}
