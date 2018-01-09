namespace rs12_2011.UI.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Salon")]
    public partial class Salon
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Naziv { get; set; }

        [Required]
        [StringLength(255)]
        public string Adresa { get; set; }

        [StringLength(50)]
        public string Telefon { get; set; }

        [StringLength(255)]
        public string Mail { get; set; }

        [StringLength(255)]
        public string Sajt { get; set; }

        [Required]
        [StringLength(50)]
        public string PIB { get; set; }

        [Required]
        [StringLength(50)]
        public string MaticniBr { get; set; }

        [Required]
        [StringLength(100)]
        public string ZiroRacun { get; set; }
    }
}
