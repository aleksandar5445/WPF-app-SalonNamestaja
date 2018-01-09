namespace rs12_2011.UI.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Popusti")]
    public partial class Popusti
    {
        public int Id { get; set; }

        public int NamestajId { get; set; }

        public int Popust { get; set; }

        public int? AkcijaId { get; set; }

        public virtual Akcija Akcija { get; set; }

        public virtual Namestaj Namestaj { get; set; }
    }
}
