using Microsoft.EntityFrameworkCore;
using ProjetoDDD.Domain.Domain;

namespace ProjetoDomain.Repository.Context
{
    public partial class ProjetoDDDContext : DbContext
    {
        public ProjetoDDDContext()
        {
        }

        public ProjetoDDDContext(DbContextOptions<ProjetoDDDContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Customer> Customer { get; set; }
        public virtual DbSet<Endereco> Endereco { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=localhost;Database=ProjetoDDD;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ZipCode)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Endereco>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Descricao)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CustomerId)
                    .IsRequired();
            });
        }
    }
}
