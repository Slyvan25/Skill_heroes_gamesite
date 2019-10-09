using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Spellenwinkel.Models
{
    public partial class skillheroesContext : DbContext
    {
        public skillheroesContext()
        {
        }

        public skillheroesContext(DbContextOptions<skillheroesContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Games> Games { get; set; }
        public virtual DbSet<Types> Types { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                Console.WriteLine("credentials where not found for database server in the startup.cs");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Games>(entity =>
            {
                entity.ToTable("games");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Duration)
                    .HasColumnName("duration")
                    .HasColumnType("int(11)");

                entity.Property(e => e.MaxPlayers)
                    .HasColumnName("max_players")
                    .HasColumnType("int(11)");

                entity.Property(e => e.MinPlayers)
                    .HasColumnName("min_players")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasColumnType("varchar(50)");
                entity.Property(e => e.Image)
                    .HasColumnName("image")
                    .HasColumnType("long(800)");

                entity.Property(e => e.Price).HasColumnName("price");

                entity.Property(e => e.Type)
                    .HasColumnName("type")
                    .HasColumnType("int(11)");

                entity.HasOne(d => d.IdNavigation)
                    .WithOne(p => p.Games)
                    .HasForeignKey<Games>(d => d.Id)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("games_types_id_fk");
            });

            modelBuilder.Entity<Types>(entity =>
            {
                entity.ToTable("types");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Typename)
                    .HasColumnName("typename")
                    .HasColumnType("varchar(20)");
            });
        }
    }
}
