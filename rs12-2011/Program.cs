using rs12_2011.model;

namespace rs12_2011
{
    class Program
    {

        static void Main(string[] args)
        {
            var admin = new Administracija();
            admin.Start();

            var tp1 = new Namestaj()
            {
                Sifra = "1",
                Naziv = "Podna Lampa",

            };
            var n1 = new Namestaj()
            {
                Sifra = "2",
                Naziv = "Socijalno osvetljenje",
                TipNamestaja = "Predsoblje",
            };
            Util.GenericSerializer.Serialize<Namestaj>("namestaj.xml");
        }
    }
}
