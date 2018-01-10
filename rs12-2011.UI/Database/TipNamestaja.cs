namespace rs12_2011.UI.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TipNamestaja")]
    public partial class TipNamestaja
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TipNamestaja()
        {
            Namestaj = new HashSet<Namestaj>();
        }

        public int Id { get; set; }

        [Required]
        [StringLength(80)]
        public string Naziv { get; set; }

        public bool? Obrisan { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Namestaj> Namestaj { get; set; }
    }
}
