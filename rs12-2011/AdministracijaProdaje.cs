using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using rs12_2011.model;

namespace rs12_2011
{
    class AdministracijaProdaje
    {
        public AdministracijaNamestaja administracijaNamestaja = null;
        private Salon salon = null;

        public AdministracijaProdaje(Salon s)
        {
            salon = s;
            administracijaNamestaja = new AdministracijaNamestaja(s);
        }

        public void Prodaja()
        {
            Console.WriteLine("Kupovina namestaja");
            Console.WriteLine(string.Empty);
            Console.WriteLine("1- Nova kupovina");
            Console.WriteLine("2- Vasa Korpa");
            Console.WriteLine("3- Obrisite artikl iz korpe");
            Console.WriteLine("4- Ocistite korpu");
            Console.WriteLine("0- Izlaz");
            var unos = Console.ReadLine();
            switch (unos)
            {
                case "1":
                    NovaKupovina();
                    break;
                case "2":
                    Korpa();
                    break;
                case "3":
                    IzbaciIzKorpe();
                    break;
                case "4":
                    OcistiKorpu();
                    break;
            }
        }

        public void Korpa()
        {
            Console.WriteLine("Trenutni artikli u korpi");
            decimal cena = 0;
            foreach (var n in salon.Korpa)
            {
                Console.WriteLine($"Naziv: {n.Item1.Naziv}   Cena: {n.Item1.JedinicnaCena}    Kolicina: {n.Item2}");
                cena = n.Item1.JedinicnaCena * n.Item2;
            }

            var cenaSaPdv = cena + (cena * (decimal)0.2);
            Console.WriteLine($"Ukupna cena: {cenaSaPdv}");
        }

        private void NovaKupovina()
        {
            administracijaNamestaja.StanjeUMagacinu();
            Console.WriteLine("unesite sifru namestaja kojeg zelite da kupite: ");
            var sifra = Console.ReadLine();

            Namestaj namestaj = null;
            foreach (var n in salon.Magacin)
            {
                if (n.Sifra == sifra)
                {
                    namestaj = n;
                }
            }

            if (namestaj == null)
            {
                Console.WriteLine($"Ne postoji namestaj sa {sifra} tom sifrom,pokusajte ponovo");
                return;
            }

            Console.WriteLine($"Unesite kolicinu za {namestaj.Naziv} koju zelite da kupite");
            var kolicina = Console.ReadLine();

            salon.Korpa.Add(new Tuple<Namestaj, int>(namestaj, int.Parse(kolicina)));
        }

        public void IzbaciIzKorpe()
        {
            Console.WriteLine("unesite sifru namestaja kojeg zelite da izbacite: ");
            var sifra = Console.ReadLine();

            Tuple<Namestaj, int> namestaj = null;
            foreach (var n in salon.Korpa)
            {
                if (n.Item1.Sifra == sifra)
                {
                    namestaj = n;
                }
            }

            if (namestaj == null)
            {
                Console.WriteLine($"Ne postoji namestaj sa {sifra} tom sifrom,pokusajte ponovo");
                return;
            }

            salon.Korpa.Remove(namestaj);
        }

        public void OcistiKorpu()
        {
            salon.Korpa.Clear();

            Console.WriteLine($"Korpa uspesno ociscenja");
        }
    }
}
