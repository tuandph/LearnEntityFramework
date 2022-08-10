using Microsoft.EntityFrameworkCore;
using TuanDPH.LearnEntityFramework.SeedData;

namespace TuanDPH.LearnEntityFramework.Models
{
    internal class LibraryContext : DbContext
    {
        public DbSet<Book> Book { get; set; }

        public DbSet<Publisher> Publisher { get; set; }

        public DbSet<Category> Category { get; set; }

        public DbSet<Location> Location { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Server=.\DESKTOP-OB8ASH4;Database=library;Trusted_Connection=True;
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-OB8ASH4;Database=Library;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Publisher>(entity =>
            {
                entity.HasKey(e => e.ID);
                entity.Property(e => e.Name).IsRequired();
            });

            modelBuilder.Entity<Book>(entity =>
            {
                entity.HasKey(e => e.ISBN);
                entity.Property(e => e.Title).IsRequired();
                // Add relationship
                entity.HasOne(d => d.Publisher)
                  .WithMany(p => p.Books);
            });

            modelBuilder.Entity<Category>(entity =>
            {
                entity.HasKey(e => e.ID);
                entity.Property(e => e.Name).IsRequired();
            });

            modelBuilder.Entity<Location>(entity =>
            {
                entity.HasKey(e => e.ID);
                entity.Property(e => e.Name).IsRequired();
            });

            modelBuilder.SeedLocationData();
        }
    }
}
