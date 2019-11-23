namespace FleaMarketApp
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class FleaMarketContext : DbContext
    {
        public FleaMarketContext()
            : base("name=FleaMarketContext")
        {
        }

        public virtual DbSet<category> category { get; set; }
        public virtual DbSet<item> item { get; set; }
        public virtual DbSet<item_order> item_order { get; set; }
        public virtual DbSet<status> status { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<category>()
                .Property(e => e.category_id)
                .HasPrecision(18, 0);

            modelBuilder.Entity<category>()
                .Property(e => e.category_name)
                .IsUnicode(false);

            modelBuilder.Entity<category>()
                .HasMany(e => e.item)
                .WithRequired(e => e.category)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<item>()
                .Property(e => e.item_id)
                .HasPrecision(18, 0);

            modelBuilder.Entity<item>()
                .Property(e => e.item_name)
                .IsUnicode(false);

            modelBuilder.Entity<item>()
                .Property(e => e.item_description)
                .IsUnicode(false);

            modelBuilder.Entity<item>()
                .Property(e => e.item_price)
                .HasPrecision(10, 2);

            modelBuilder.Entity<item>()
                .Property(e => e.status_id)
                .HasPrecision(18, 0);

            modelBuilder.Entity<item>()
                .Property(e => e.category_id)
                .HasPrecision(18, 0);

            modelBuilder.Entity<item>()
                .HasMany(e => e.item_order)
                .WithRequired(e => e.item)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<item_order>()
                .Property(e => e.order_id)
                .HasPrecision(18, 0);

            modelBuilder.Entity<item_order>()
                .Property(e => e.item_id)
                .HasPrecision(18, 0);

            modelBuilder.Entity<status>()
                .Property(e => e.status_id)
                .HasPrecision(18, 0);

            modelBuilder.Entity<status>()
                .Property(e => e.status_name)
                .IsUnicode(false);

            modelBuilder.Entity<status>()
                .HasMany(e => e.item)
                .WithRequired(e => e.status)
                .WillCascadeOnDelete(false);
        }
    }
}
