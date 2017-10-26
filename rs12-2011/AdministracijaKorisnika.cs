using rs12_2011.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rs12_2011
{
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
        }
    }
}
