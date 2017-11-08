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
            prodaje = new AdministracijaProdaje(salon);

            salon.Magacin = Util.GenericSerializer.Deserialize<List<Namestaj>>("namestaj.xml");
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
        
        public List<Namestaj> GetMagacin()
        {
            return salon.Magacin;
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
