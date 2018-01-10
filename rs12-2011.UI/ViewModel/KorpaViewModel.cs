using rs12_2011.model;
using rs12_2011.UI.DataAccess;
using System;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace rs12_2011.UI.ViewModel
{
    public class KorpaViewModel : INotifyPropertyChanged
    {
        private Salon salon;
        private DatabaseAccess dbaccess;

        public KorpaViewModel() { }

        public KorpaViewModel(Salon s)
        {
            salon = s;
            dbaccess = new DatabaseAccess();

            Stavke = new ObservableCollection<Tuple<Namestaj, int>>(s.Korpa);
        }

        public ObservableCollection<Tuple<Namestaj, int>> Stavke { get; set; }

        public decimal Total
        {
            get
            {
                return GetTotal();
            }
        }

        public decimal GrandTotal
        {
            get
            {
                return GetTotalSaPopustomIPorezom(20);
            }
        }

        public decimal TotalSaPopustom
        {
            get
            {
                return GetTotalSaPopustomIPorezom(0);
            }
        }

        public void IzbaciIzKorpe(Namestaj namestaj)
        {
            Tuple<Namestaj, int> s = null;
            foreach(var stavka in Stavke)
            {
                if(stavka.Item1.Sifra == namestaj.Sifra)
                {
                    s = stavka;
                }
            }

            if (s != null)
            {
                Stavke.Remove(s);
            }

            RaisePropertyChanged("Total");
            RaisePropertyChanged("TotalSaPopustom");
            RaisePropertyChanged("GrandTotal");
        }

        private decimal GetTotal()
        {
            decimal total = 0;
            foreach (var stavka in Stavke)
            {
                total += stavka.Item1.JedinicnaCena * stavka.Item2;
            }

            return total;
        }

        private decimal GetTotalSaPopustomIPorezom(int porez)
        {
            decimal d = new Decimal(100.0);
            decimal total = 0;
            foreach (var stavka in Stavke)
            {
                total += GetCenaSaPopustom(stavka.Item1) * stavka.Item2;
            }

            if (porez > 0)
            {
                total += (total * (porez / d));
            }

            return total;
        }

        private decimal GetCenaSaPopustom(Namestaj namestaj)
        {
            int popust = 0;
            foreach(var ak in salon.Akcije)
            {
                if(ak.DatumPocetka <= DateTime.Now && ak.DatumKraja >= DateTime.Now)
                {
                    foreach(var p in ak.Popusti)
                    {
                        if(p.Key == namestaj.Sifra)
                        {
                            popust = p.Value;
                        }
                    }
                }
            }
            var cena = namestaj.JedinicnaCena;
            return cena - (cena * new decimal((popust/100.0)));
        }

        public void Kupi()
        {
            foreach(var stavka in Stavke)
            {
                var namestaj = stavka.Item1;
                //namestaj.KolicinaUMagacinu -= stavka.Item2;
                dbaccess.UpdateNamestaj(namestaj);

                var istorija = new IstorijaKupovine
                {
                    DatumKupovine = DateTime.Now,
                    Kolicina = stavka.Item2,
                    Korisnik = salon.UlogovaniKorisnik,
                    Namestaj = namestaj
                };

                dbaccess.InsertIstorijaKupovine(istorija);
            }

            Stavke.Clear();
            salon.Korpa.Clear();
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void RaisePropertyChanged(string property)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(property));
            }
        }
    }
}
