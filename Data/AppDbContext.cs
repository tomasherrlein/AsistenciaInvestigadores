using Microsoft.EntityFrameworkCore;
using Models;

namespace Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        
        public DbSet<AsistenciaModel> Asistencias { get; set; }
        public DbSet<InvestigadorModel> Investigadores { get; set;}
        public DbSet<DepartamentoModel> Departamentos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<InvestigadorModel>().ToTable("Investigadores");
            modelBuilder.Entity<DepartamentoModel>().ToTable("Departamentos");
            modelBuilder.Entity<AsistenciaModel>().ToTable("Asistencias");
        }
    }
}

