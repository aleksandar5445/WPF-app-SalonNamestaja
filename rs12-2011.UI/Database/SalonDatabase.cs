namespace rs12_2011.UI.Database
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class SalonDatabase : DbContext
    {
        public SalonDatabase()
            : base("name=SalonDatabase")
        {
        }

        public virtual DbSet<Akcija> Akcija { get; set; }
        public virtual DbSet<IstorijaKupovine> IstorijaKupovine { get; set; }
        public virtual DbSet<Korisnik> Korisnik { get; set; }
        public virtual DbSet<Namestaj> Namestaj { get; set; }
        public virtual DbSet<Popusti> Popusti { get; set; }
        public virtual DbSet<Salon> Salon { get; set; }
        public virtual DbSet<TipKorisnika> TipKorisnika { get; set; }
        public virtual DbSet<TipNamestaja> TipNamestaja { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Korisnik>()
                .HasMany(e => e.IstorijaKupovine)
                .WithRequired(e => e.Korisnik)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Namestaj>()
                .Property(e => e.JedinicnaCena)
                .HasPrecision(6, 3);

            modelBuilder.Entity<Namestaj>()
                .HasMany(e => e.IstorijaKupovine)
                .WithRequired(e => e.Namestaj)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Namestaj>()
                .HasMany(e => e.Popusti)
                .WithRequired(e => e.Namestaj)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TipKorisnika>()
                .HasMany(e => e.Korisnik)
                .WithRequired(e => e.TipKorisnika)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TipNamestaja>()
                .HasMany(e => e.Namestaj)
                .WithRequired(e => e.TipNamestaja)
                .WillCascadeOnDelete(false);
        }
    }
}
