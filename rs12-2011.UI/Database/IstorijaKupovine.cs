namespace rs12_2011.UI.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("IstorijaKupovine")]
    public partial class IstorijaKupovine
    {
        public int Id { get; set; }

        public int KorisnikId { get; set; }

        public int NamestajId { get; set; }

        public int Kolicina { get; set; }

        public DateTime DatumKupovine { get; set; }

        public virtual Korisnik Korisnik { get; set; }

        public virtual Namestaj Namestaj { get; set; }
    }
}
