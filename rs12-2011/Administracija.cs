using rs12_2011.model;
using System;

namespace rs12_2011
{
    public class Administracija
    {
        private Salon salon = null;
        private AdministracijaNamestaja namestaji = null;
        private AdministracijaKorisnika korisnici = null;

        public Administracija()
        {
            salon = new Salon
            {
                Adresa = "Adresa1",
                Telefon = "telefon",
                Naziv = "Salon1"
            };

            namestaji = new AdministracijaNamestaja(salon);
            korisnici = new AdministracijaKorisnika(salon);
        }

        public void Start()
        {
            string unos = string.Empty;
            while (unos != "0")
            {
                Console.WriteLine("Glavni Meni:");
                Console.WriteLine("1 - Namestaji");
                Console.WriteLine("2 - Akcije");
                Console.WriteLine("3 - Korisnici");
                Console.WriteLine("4 - Prodaja");
                Console.WriteLine("0 - Izlaz");

                unos = Console.ReadLine();
                switch (unos)
                {
                    case "1": namestaji.Namestaji(); break;
                    case "3": korisnici.Korisnici(); break;
                }

            }
        }        
    }

    enum Akcije
    {
        KreiranjeNamestaja = 1, IzmenaNamestaja, BrisanjeNamestaja, SviNamestaji,
        KreiranjeAkcije, IzmenaAkcije, BrisanjeAkcije, SveAkcije,
        KreiranjeKorisnika, IzmenaKorisnika, BrisanjeKorisnika, SviKorisnici,
        ProdajaNamestaja,
        Izlaz, Pocetak
    }
}
