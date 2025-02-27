using GestionPrestamos.Models;
using Microsoft.EntityFrameworkCore;

namespace GestionPrestamos.Context;

public class Contexto : DbContext
{
    public Contexto(DbContextOptions<Contexto> options) : base(options) { }

    public virtual DbSet<Deudores> Deudores { get; set; }
    public virtual DbSet<Prestamos> Prestamos { get; set; }
    public virtual DbSet<Cobros> Cobros { get; set; }
    public virtual DbSet<CobrosDetalle> CobrosDetalle { get; set; }
    public virtual DbSet<PrestamosDetalle> PrestamoDetalle { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Deudores>().HasData(
            new List<Deudores>()
            {
                new()
                {
                    DeudorId = 1,
                    Nombres = "Jose Lopez",
                },
                new()
                {
                    DeudorId = 2,
                    Nombres = "Maria Perez",
                }
            }
        );
        base.OnModelCreating(modelBuilder);
    }
}
