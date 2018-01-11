using rs12_2011.model;
using rs12_2011.UI.DataAccess;
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
        private DatabaseAccess dbaccess;

        public event PropertyChangedEventHandler PropertyChanged;

        public NoviNamestajViewModel(AdministracijaNamestajaViewModel adm)
        {
            adminVM = adm;
            TipoviNamestaja = new List<string> { "Kreveti", "Predsoblje", "Kuhinja" };
            TipNamestaja = TipoviNamestaja[0];
            dbaccess = new DatabaseAccess();
        }

        public NoviNamestajViewModel() { }

        public List<string> TipoviNamestaja { get; }
        public string Naziv { get; set; }
        public string Sifra { get; set; }
        public decimal JedinicnaCena { get; set; }
        public long KolicinaUMagacinu { get; set; }
        public string TipNamestaja { get; set; }

        public void KreirajNoviNamestaj()
        {
            var novi = new Namestaj
            {
                Naziv = Naziv,
                JedinicnaCena = JedinicnaCena,
                Sifra = Sifra,
                KolicinaUMagacinu = KolicinaUMagacinu,
                TipNamestaja = (TipNamestaja)Enum.Parse(typeof(TipNamestaja), TipNamestaja)
            };
            adminVM.Magacin.Add(novi);

            dbaccess.InsertNamestaj(novi);
        }
    }
}
