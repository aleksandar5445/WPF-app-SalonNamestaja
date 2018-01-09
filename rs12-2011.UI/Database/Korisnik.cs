namespace rs12_2011.UI.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Korisnik")]
    public partial class Korisnik
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Korisnik()
        {
            IstorijaKupovine = new HashSet<IstorijaKupovine>();
        }

        public int Id { get; set; }

        [Required]
        [StringLength(25)]
        public string Ime { get; set; }

        [Required]
        [StringLength(25)]
        public string Prezime { get; set; }

        [Required]
        [StringLength(25)]
        public string KorisnickoIme { get; set; }

        [Required]
        [StringLength(25)]
        public string Lozinka { get; set; }

        public int TipKorisnikaId { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IstorijaKupovine> IstorijaKupovine { get; set; }

        public virtual TipKorisnika TipKorisnika { get; set; }
    }
}
