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
    class SalonEditViewModel : INotifyPropertyChanged
    {
        private Salon _salon;
        private DatabaseAccess dbaccess;

        public event PropertyChangedEventHandler PropertyChanged;

        public void IzmeniPodatkeSalona()
        {
            _salon.Naziv = Naziv;
            _salon.Adresa = Adresa;
            _salon.Telefon = Telefon;
            _salon.Mail = Mail;
            _salon.Sajt = Sajt;
            _salon.PIB = PIB;
            _salon.MaticniBr = MaticniBr;
            _salon.ZiroRacun = ZiroRacun;

            dbaccess.UpdateSalon(_salon);
        }

        public SalonEditViewModel() { }

        public SalonEditViewModel(Salon salon)
        {
            _salon = salon;
            dbaccess = new DatabaseAccess();

            Naziv = salon.Naziv;
            Adresa = salon.Adresa;
            Telefon = salon.Telefon;
            Mail = salon.Mail;
            Sajt = salon.Sajt;
            PIB = salon.PIB;
            MaticniBr = salon.MaticniBr;
            ZiroRacun = salon.ZiroRacun;
        }

        public string Naziv { get; set; }
        public string Adresa { get; set; }
        public string Telefon { get; set; }
        public string Mail { get; set; }
        public string Sajt { get; set; }
        public string PIB { get; set; }
        public string MaticniBr { get; set; }
        public string ZiroRacun { get; set; }
    }
}
