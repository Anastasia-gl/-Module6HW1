using Microsoft.EntityFrameworkCore;
using Module6HW1.Model;
namespace Module6HW1
{
    public class MovieContext : DbContext
    {
        public DbSet<Movie> Movie { get; set; }

        public DbSet<Genre> Genre { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source=DESKTOP-EP3R97J;Initial Catalog=MovieAPI;Integrated Security=True;MultipleActiveResultSets=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Movie Entity

            modelBuilder.Entity<Movie>()
                .ToTable("Movie")
                .HasKey(k => k.Id);

            modelBuilder.Entity<Movie>()
                .Property(p => p.Title)
                .IsRequired()
                .HasMaxLength(20);

            modelBuilder.Entity<Movie>()
                .Property(p => p.Year)
                .IsRequired();

            //Genre Entity

            modelBuilder.Entity<Genre>()
                .ToTable("Genre")
                .HasKey(k => k.Id);

            modelBuilder.Entity<Genre>()
                .Property(p => p.Title)
                .IsRequired()
                .HasMaxLength(20);
        }

    }
}
