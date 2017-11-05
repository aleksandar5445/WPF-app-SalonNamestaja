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
                Console.WriteLine("======= GLAVNI MENI =======");
                Console.WriteLine("1 - NAMESTAJI");
                Console.WriteLine("2 - AKCIJE");
                Console.WriteLine("3 - KORISNICI");
                Console.WriteLine("4 - PRODAJA");
                Console.WriteLine("0 - IZLAZ");

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
