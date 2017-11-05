using rs12_2011.model;
using System;

namespace rs12_2011
{
    public class AdministracijaNamestaja
    {
        private Akcije akcija = Akcije.Pocetak;
        private Salon salon = null;

        public AdministracijaNamestaja(Salon s)
        {
            salon = s;
        }

        public void Namestaji()
        {
            Console.WriteLine(string.Empty);
            Console.WriteLine("1 - Novi namestaj");
            Console.WriteLine("2 - Promeni postojeci namestaj");
            Console.WriteLine("3 - Obrisi namestaj");
            Console.WriteLine("4 - Prikazi stanje u magacinu");

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
                case Akcije.SviNamestaji:
                    StanjeUMagacinu();
                    break;
                case Akcije.KreiranjeNamestaja:
                    NoviNamestaj();
                    break;
                case Akcije.BrisanjeNamestaja:
                    BrisanjeNamestaja();
                    break;
                case Akcije.IzmenaNamestaja:
                    IzmenaNamestaja();
                    break;
            }
        }

        public void StanjeUMagacinu()
        {
            Console.WriteLine($"------ MAGACIN SALONA - {salon.Naziv} ------");
            foreach (var namestaj in salon.Magacin)
            {
                Console.WriteLine($" Naziv Namestaja: {namestaj.Naziv}\n Sifra Namestaja: {namestaj.Sifra}\n Tip Namestaja: {namestaj.TipNamestaja}\n Jedinicna Cena: {namestaj.JedinicnaCena}\n Kolicina u magacinu: {namestaj.KolicinaUMagacinu}\n Aktivan-Neaktivan: {namestaj.Aktivan}");
            }
            Console.WriteLine($"------ MAGACIN ------");
        }

        public void NoviNamestaj()
        {
            Console.WriteLine($"------ Novi namestaj ------");

            Console.WriteLine("Naziv: ");
            var naziv = Console.ReadLine();
            Console.WriteLine("Sifra: ");
            var sifra = Console.ReadLine();
            Console.WriteLine("Tip: ");
            var tip = Console.ReadLine();
            Console.WriteLine("Cena: ");
            var cena = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Kolicina u magacinu: ");
            var kolicina = long.Parse(Console.ReadLine());

            var namestaj = new Namestaj
            {
                Aktivan = "Aktivan",
                JedinicnaCena = cena,
                KolicinaUMagacinu = kolicina,
                Naziv = naziv,
                Sifra = sifra,
                TipNamestaja = (TipNamestaja)Enum.Parse(typeof(TipNamestaja), tip)
            };

            salon.Magacin.Add(namestaj);

            Console.WriteLine($"------ Kraj ------");
        }

        private void BrisanjeNamestaja()
        {
            Console.WriteLine($"------ Brisanje namsetaja ------");
            StanjeUMagacinu();
            Console.WriteLine($"Unesite sifru namestaja koji zelite da obrisete:");
            var sifra = Console.ReadLine();

            Namestaj n = null;
            foreach (var namestaj in salon.Magacin)
            {
                if (namestaj.Sifra == sifra)
                {
                    n = namestaj;
                }
            }

            if (n == null)
            {
                Console.WriteLine($"Namestaj sa sifrom {sifra} nije pronadjen");
                Console.WriteLine($"------ Kraj ------");
            }
            Console.WriteLine($"Namestaj sa sifrom {sifra} je obrisan.");
            salon.Magacin.Remove(n);

            Console.WriteLine($"------ Kraj ------");
        }

        private void IzmenaNamestaja()
        {
            Console.WriteLine($"------ Izmena namestaja ------");
            StanjeUMagacinu();
            Console.WriteLine($"Unesite sifru namestaja koji zelite da Izmenite:");
            var sifra = Console.ReadLine();
            Console.WriteLine("Novi naziv: ");
            var naziv = Console.ReadLine();
            Console.WriteLine("Novi tip: ");
            var tip = Console.ReadLine();
            Console.WriteLine("Nova cena: ");
            var cena = Console.ReadLine();
            Console.WriteLine("Nova kolicina u magacinu: ");
            var kolicina = Console.ReadLine();

            var nadjen = false;
            foreach (var namestaj in salon.Magacin)
            {
                if (namestaj.Sifra == sifra)
                {
                    nadjen = true;
                    namestaj.Naziv = naziv != string.Empty ? naziv : namestaj.Naziv;
                    namestaj.JedinicnaCena = cena != string.Empty ? decimal.Parse(cena) : namestaj.JedinicnaCena;
                    namestaj.KolicinaUMagacinu = kolicina != string.Empty ? long.Parse(kolicina) : namestaj.KolicinaUMagacinu;
                    namestaj.TipNamestaja = tip != string.Empty ? (TipNamestaja)Enum.Parse(typeof(TipNamestaja), tip) : namestaj.TipNamestaja;
                }
            }

            if (!nadjen)
            {
                Console.WriteLine($"Namestaj sa sifrom {sifra} nije pronadjen");
                Console.WriteLine($"------ Kraj ------");
            }

            Console.WriteLine($"------ Kraj ------");
        }
    }
}
