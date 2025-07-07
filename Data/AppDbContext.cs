using Microsoft.EntityFrameworkCore;
using Models;

namespace Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<AsistenciaModel> Asistencias { get; set; }
        public DbSet<InvestigadorModel> Investigadores { get; set; }
        public DbSet<DepartamentoModel> Departamentos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        
            modelBuilder.Entity<AsistenciaModel>(entity =>
            {
                entity.HasKey(e => e.Idasistencia).HasName("PK_Asistencia");

                entity.Property(e => e.Idasistencia).HasColumnName("IDAsistencia");
                entity.Property(e => e.Idinvestigador).HasColumnName("IDInvestigador");

                entity.HasOne(d => d.IdinvestigadorNavigation).WithMany(p => p.Asistencia)
                    .HasForeignKey(d => d.Idinvestigador)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Asistencia_Investigador");
            });

            modelBuilder.Entity<DepartamentoModel>(entity =>
            {
                entity.HasKey(e => e.Iddepartamento).HasName("PK_Departamento");

                entity.Property(e => e.Iddepartamento).HasColumnName("IDDepartamento");
                entity.Property(e => e.Nombre)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<InvestigadorModel>(entity =>
            {
                entity.HasKey(e => e.Idinvestigador).HasName("PK_Investigador");

                entity.Property(e => e.Idinvestigador).HasColumnName("IDInvestigador");
                entity.Property(e => e.Nombre)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasMany(d => d.Iddepartamentos).WithMany(p => p.Idinvestigadores)
                    .UsingEntity<Dictionary<string, object>>(
                        "InvestigadoresDepartamento",
                        r => r.HasOne<DepartamentoModel>().WithMany()
                            .HasForeignKey("Iddepartamento")
                            .OnDelete(DeleteBehavior.ClientSetNull)
                            .HasConstraintName("FK_InvestigadorDepartamento_Departamento"),
                        l => l.HasOne<InvestigadorModel>().WithMany()
                            .HasForeignKey("Idinvestigador")
                            .OnDelete(DeleteBehavior.ClientSetNull)
                            .HasConstraintName("FK_InvestigadorDepartamento_Investigador"),
                        j =>
                        {
                            j.HasKey("Idinvestigador", "Iddepartamento");
                            j.ToTable("InvestigadoresDepartamentos");
                            j.IndexerProperty<int>("Idinvestigador").HasColumnName("IDInvestigador");
                            j.IndexerProperty<int>("Iddepartamento").HasColumnName("IDDepartamento");
                        });
            });

        }
    }
}

