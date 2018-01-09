namespace rs12_2011.UI.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Namestaj")]
    public partial class Namestaj
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Namestaj()
        {
            IstorijaKupovine = new HashSet<IstorijaKupovine>();
            Popusti = new HashSet<Popusti>();
        }

        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Naziv { get; set; }

        [Required]
        [StringLength(20)]
        public string Sifra { get; set; }

        public decimal JedinicnaCena { get; set; }

        public long? KolicinaUMagacinu { get; set; }

        public int TipNamestajaId { get; set; }

        public bool Aktivan { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IstorijaKupovine> IstorijaKupovine { get; set; }

        public virtual TipNamestaja TipNamestaja { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Popusti> Popusti { get; set; }
    }
}
