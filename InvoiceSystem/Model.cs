namespace InvoiceSystem
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model : DbContext
    {
        public Model()
            : base("name=ModelInvoice")
        {
        }

        public virtual DbSet<Details> Details { get; set; }
        public virtual DbSet<Invoice> Invoice { get; set; }
        public virtual DbSet<Items> Items { get; set; }
        public virtual DbSet<Store> Store { get; set; }
        public virtual DbSet<Unit> Unit { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Details>()
                .Property(e => e.Price)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Details>()
                .Property(e => e.TotalperItem)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Details>()
                .Property(e => e.Discount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Details>()
                .Property(e => e.NetperItem)
                .HasPrecision(19, 4);


            modelBuilder.Entity<Invoice>()
                .HasMany(e => e.Details)
                .WithRequired(e => e.Invoice)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Items>()
                .Property(e => e.Item)
                .IsUnicode(false);

            modelBuilder.Entity<Items>()
                .HasMany(e => e.Details)
                .WithRequired(e => e.Items)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Store>()
                .Property(e => e.StoreName)
                .IsUnicode(false);

            modelBuilder.Entity<Unit>()
                .Property(e => e.UnitName)
                .IsUnicode(false);
        }
    }
}
