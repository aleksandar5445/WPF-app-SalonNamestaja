using rs12_2011.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rs12_2011.UI.ViewModel
{
    public class IzmeniNamestajViewModel : INotifyPropertyChanged
    {
        private AdministracijaNamestajaViewModel adminVM;

        public event PropertyChangedEventHandler PropertyChanged;

        public IzmeniNamestajViewModel(AdministracijaNamestajaViewModel adm, Namestaj sel)
        {
            adminVM = adm;

            TipoviNamestaja = new List<string> { "Kreveti", "Predsoblje", "Kuhinja" };
            TipNamestaja = TipoviNamestaja[0];
            Naziv = sel.Naziv;
            Sifra = sel.Sifra;
            JedinicnaCena = sel.JedinicnaCena;
            KolicinaUMagacinu = sel.KolicinaUMagacinu;
            TipNamestaja = sel.TipNamestaja.ToString();
        }

        public IzmeniNamestajViewModel() { }

        public List<string> TipoviNamestaja { get;}
        public string Naziv { get; set; }
        public string Sifra { get; set; }
        public decimal JedinicnaCena { get; set; }
        public long KolicinaUMagacinu { get; set; }
        public string TipNamestaja { get; set; }

        public void IzmeniNamestaj()
        {
            Namestaj namestaj = null;
            foreach(var n in adminVM.Magacin)
            {
                if(n.Sifra == Sifra)
                {
                    namestaj = n;
                }
            }

            if (namestaj != null)
            {
                adminVM.Magacin.Remove(namestaj);

                namestaj.Naziv = Naziv;
                namestaj.JedinicnaCena = JedinicnaCena;
                namestaj.KolicinaUMagacinu = KolicinaUMagacinu;
                namestaj.TipNamestaja = (TipNamestaja)Enum.Parse(typeof(TipNamestaja), TipNamestaja);

                adminVM.Magacin.Add(namestaj);
             }
        }
    }
}
