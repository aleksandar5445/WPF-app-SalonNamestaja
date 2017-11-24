using rs12_2011.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rs12_2011
{
    public class Login
    {
        private Administracija administracija = new Administracija();
        private Salon salon = null;

        public void ProveraKorisnika()
        {
            Console.WriteLine("Unesite vase korisnicko Ime: ");
            var korisnickoIme=Console.ReadLine();
            Console.WriteLine("Unesite vasu sifru: ");
            var sifra=Console.ReadLine();
            foreach (var korisnik in salon.Korisnici)
            {
                if (korisnik.KorisnickoIme == korisnickoIme || korisnik.Lozinka == sifra)
                {
                    administracija.Start();
                }
                else { Console.WriteLine("Pogresno korisnicko ime ili sifra molim pokusajte ponovo");
                }
                    

            }
        }
    }
    public class AdministracijaKorisnika
    {
        private Akcije akcija = Akcije.Pocetak;
        private Salon salon = null;

        public AdministracijaKorisnika(Salon s)
        {
            salon = s;
        }

        public void Korisnici()
        {
            Console.WriteLine(string.Empty);
            Console.WriteLine("9 - Novi korisnik");
            Console.WriteLine("10 - Promeni postojeceg korisnika");
            Console.WriteLine("11 - Obrisi korisnika");
            Console.WriteLine("12 - Prikazi sve korisnike");

            var unos = Console.ReadLine();
            try
            {
                akcija = (Akcije)Enum.Parse(typeof(Akcije), unos);
            }
            catch
            {
                Console.WriteLine("Neispravan unos! Pokusajte ponovo");
            }
            switch (akcija)
            {
                case Akcije.SviKorisnici:
                    StanjeKorisnika();
                    break;
                case Akcije.KreiranjeKorisnika:
                    NoviKorisnik();
                    break;
                case Akcije.BrisanjeKorisnika:
                    BrisanjeKorisnika();
                    break;
                case Akcije.IzmenaKorisnika:
                    IzmeniKorisnika();
                    break;
            }
        }
        public void StanjeKorisnika()
        {
            Console.WriteLine($"------- KORISNICI SALONA {salon.Naziv}----- -");
                foreach (var korisnik in salon.Korisnici)
                {
                    Console.WriteLine($"Ime Korisnika: {korisnik.Ime}\n Prezime: {korisnik.Prezime}\n KorisnickoIme: {korisnik.KorisnickoIme}\n Lozinka: {korisnik.Lozinka}\n TipKorisnika: {korisnik.TipKorisnika}\n");
                }
            Console.WriteLine($"------ KORISNIK ------");
        }
        public void NoviKorisnik()
        {
            Console.WriteLine($"------ Novi Korisnik ---------");
            Console.WriteLine(string.Empty);

            Console.WriteLine("Ime: ");
            var ime = Console.ReadLine();
            Console.WriteLine("Prezime: ");
            var prezime = Console.ReadLine();
            Console.WriteLine("Korisnicko Ime:");
            var korisnickoIme = Console.ReadLine();
            Console.WriteLine("Lozinka: ");
            var lozinka = Console.ReadLine();
            Console.WriteLine("Tip Korisnika: ");
            var tip = Console.ReadLine();

            var korisnik = new Korisnik
            {
                Ime = ime,
                Prezime = prezime,
                KorisnickoIme = korisnickoIme,
                Lozinka = lozinka,
                TipKorisnika = (TipKorisnika)Enum.Parse(typeof(TipKorisnika), tip)
            };
            salon.Korisnici.Add(korisnik);
            Console.WriteLine("---- Korisnik Dodat -------");
        }
        public void BrisanjeKorisnika()
        {
            Console.WriteLine("----------- Brisanje Korisnika -----------");
            Console.WriteLine(string.Empty);
            StanjeKorisnika();
            Console.WriteLine("Unesite sifru korisnika kojeg zelite da obrisete: ");
            var sifra = Console.ReadLine();

            Korisnik k = null;
            foreach(var korisnik in salon.Korisnici)
            {
                if (korisnik.Lozinka == sifra)
                {
                    k = korisnik;
                }
            }
            if (k == null)
            {
                Console.WriteLine($"Korisnik sa sifrom {sifra} nije pronadjen");
            }
            Console.WriteLine($"Korisnik sa sifrom {sifra} je obrisan.");
            salon.Korisnici.Remove(k);
        }
        public void IzmeniKorisnika()
        {
            Console.WriteLine("--------- Izmena Korisnika ---------");
            StanjeKorisnika();
            Console.WriteLine("Unesite Lozinku korisnika cije podatke zelite da izmenite:");
            var sifra = Console.ReadLine();

            foreach(var korisnik in salon.Korisnici)
            {
                if (korisnik.Lozinka == sifra)
                {
                    Console.WriteLine("Izmeni ime korisnika: ");
                    var ime = Console.ReadLine();
                    Console.WriteLine("Izmeni prezime korisnika: " );
                    var prezime = Console.ReadLine();
                    Console.WriteLine("Izmeni Korisnicko ime : ");
                    var korisnickoIme = Console.ReadLine();
                    Console.WriteLine("Izmeni Tip korisnika (Administrator-Prodavac):");
                    var tipKorisnika = Console.ReadLine();

                    korisnik.Ime = ime != string.Empty ? ime : korisnik.Ime;
                    korisnik.Prezime = prezime != string.Empty ? prezime : korisnik.Prezime;
                    korisnik.KorisnickoIme = korisnickoIme != string.Empty ? korisnickoIme : korisnik.KorisnickoIme;
                    korisnik.TipKorisnika = tipKorisnika != string.Empty ? (TipKorisnika)Enum.Parse(typeof(TipKorisnika), tipKorisnika) : korisnik.TipKorisnika;
                    Console.WriteLine("Uspesno Promenjeni Podaci Korisnika");
                }
                else
                    Console.WriteLine($"Ne postoji korisnik sa {sifra} tom lozinkom");

            }
        }

    }
}
