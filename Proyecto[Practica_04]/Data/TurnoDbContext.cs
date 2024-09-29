using Data.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Data
{
    public class TurnoDbContext : DbContext
    {
        public TurnoDbContext() { }
        public TurnoDbContext(DbContextOptions<TurnoDbContext> options) : base(options) { }
        public DbSet<Turno> Turno { get; set; }
        public DbSet<DetalleTurno> Detalle { get; set; }
        public DbSet<Servicio> Servicio { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Turno>(entity =>
                {
                    entity.ToTable("T_Turnos");
                    entity.HasKey(e => e.Id);
                    entity.Property(e => e.Id).IsRequired(); // ValueGeneratedOnAdd()
                    //relacion 1 turno tiene varios detalles
                    entity.HasMany(e => e.DetallesTurno)
                          .WithOne(d => d.Turno)
                          .HasForeignKey(d => d.TurnoId);
                });
            modelBuilder.Entity<DetalleTurno>(entity =>
                {
                    entity.ToTable("T_Detalles");
                    entity.HasKey(e => e.Id);
                    entity.Property(e => e.Id).IsRequired();
                    //cada detalle tiene un servicio
                    entity.Property(e => e.ServicioId).HasColumnName("servicio_id");
                    entity.HasOne(e => e.Servicio)
                          .WithMany(s => s.DetalleTurnos)
                          .HasForeignKey(e => e.ServicioId);
                    //un detalle tiene un turno
                    entity.Property(e => e.TurnoId).HasColumnName("turno_id");
                    entity.HasOne(e => e.Turno)
                          .WithMany(t => t.DetallesTurno)
                          .HasForeignKey(e => e.TurnoId);

                });
            modelBuilder.Entity<Servicio>(entity =>
                {
                    entity.ToTable("T_Servicios");
                    entity.HasKey(e => e.Id);
                    entity.Property(e => e.Id).IsRequired();
                    //relacion 1 a varios
                    entity.HasMany(e => e.DetalleTurnos).WithOne(d => d.Servicio);
                });
        }
    }
}
