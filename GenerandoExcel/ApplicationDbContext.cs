using GenerandoExcel.Entidades;
using Microsoft.EntityFrameworkCore;

namespace GenerandoExcel
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Persona>()
                .HasData(new List<Persona> {
                new Persona { Id = 1, Nombre = "Felipe" },
                new Persona { Id = 2, Nombre = "Claudia" },
                new Persona { Id = 3, Nombre = "Roberto" }
                });

        }

        public DbSet<Persona> Personas { get; set; }
    }

}
