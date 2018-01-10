using rs12_2011.model;
using System;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace rs12_2011.UI.ViewModel
{
    public class AdministracijaAkcijeViewModel : INotifyPropertyChanged
    {
        private Salon salon = null;
        private ObservableCollection<Akcija> akcije;
        public AdministracijaAkcijeViewModel(Salon s)
        {
            salon = s;
            akcije = new ObservableCollection<Akcija>(salon.Akcije);
            SelektovaniPopusti = new ObservableCollection<Tuple<string, int>>();
        }
        public AdministracijaAkcijeViewModel()
        {

        }
        public ObservableCollection<Akcija> Akcije
        {
            get
            {
                return akcije;
            }
        }
        //public Akcija SelektovanaAkcija
        //{
        //    get
        //    {
        //        return SelektovanaAkcija;
        //    }
        //    set
        //    {
        //        SelektovanaAkcija = value;
        //    }
        //}

        public ObservableCollection<Tuple<string, int>> SelektovaniPopusti { get; set; }

        public void PostaviPopuste(Akcija sel)
        {
            SelektovaniPopusti.Clear();
            foreach(var p in sel.Popusti)
            {
                SelektovaniPopusti.Add(new Tuple<string, int>(p.Key, p.Value));
            }
        }

        public void ObrisiAkciju(Akcija akcija)
        {
            if(akcija != null)
            {
                Akcije.Remove(akcija);

                akcija.Aktivan = "Neaktivan";
                akcije.Add(akcija);
            }
        }


        public event PropertyChangedEventHandler PropertyChanged;
    }
}
