using rs12_2011.model;
using System;
using System.Collections.Generic;

namespace rs12_2011
{
    public class Administracija
    {
        private Salon salon = null;
        private AdministracijaNamestaja namestaji = null;
        private AdministracijaKorisnika korisnici = null;
        private AdministracijaProdaje prodaje = null;
        private Korisnik korisnik = null;
        public Administracija()
        {
            salon = new Salon
            {
                Adresa = "Adresa1",
                Telefon = "telefon",
                Naziv = "Salon1"
            };
            korisnik = new Korisnik
            {
                Ime = "aleksandar",
                Prezime = "Dimitrov",
                Lozinka = "123",
                KorisnickoIme = "aca",
            };
            namestaji = new AdministracijaNamestaja(salon);
            korisnici = new AdministracijaKorisnika(salon);
            prodaje = new AdministracijaProdaje(salon);
            salon.Magacin = Util.GenericSerializer.Deserialize<List<Namestaj>>("namestaj.xml");
            salon.Korisnici = Util.GenericSerializer.Deserialize<List<Korisnik>>("korisnici.xml");

            if (salon.Magacin == null)
            {
                salon.Magacin = new List<Namestaj>();
            }

            if (salon.Korisnici == null || salon.Korisnici.Count == 0)
            {
                salon.Korisnici = new List<Korisnik>() { korisnik };
            }
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
                try
                {
                    switch (unos)
                    {
                        case "1": namestaji.Namestaji(); break;
                        case "3": korisnici.Korisnici(); break;
                        case "4": prodaje.Prodaja(); break;
                    }
                }
                catch(Exception e)
                {
                    Console.WriteLine("Dogodila se greska u sistemu, molimo pokusajte ponovo");
                    Console.WriteLine($"Detalji greske: {e.Message}");
                }

            }
        }  
        
        //public List<Namestaj> GetMagacin()
        //{
        //    return salon.Magacin;
        //}

        //public List<Korisnik> GetKorisnici()
        //{
        //    return salon.Korisnici;
        //}

        public Salon GetSalon()
        {
            return salon;
        }

        public void SnimiPodatke()
        {
            Util.GenericSerializer.Serialize("namestaj.xml", salon.Magacin);
            Util.GenericSerializer.Serialize("korisnici.xml", salon.Korisnici);
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
