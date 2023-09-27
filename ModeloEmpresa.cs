using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace WebAppEmpresa
{
    public partial class ModeloEmpresa : DbContext
    {
        public ModeloEmpresa()
            : base("name=ModeloEmpresa")
        {
        }

        public virtual DbSet<Direccion> Direccions { get; set; }
        public virtual DbSet<Empresa> Empresas { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Direccion>()
                .Property(e => e.Direccion1)
                .IsUnicode(false);

            modelBuilder.Entity<Empresa>()
                .Property(e => e.RUC)
                .IsUnicode(false);

            modelBuilder.Entity<Empresa>()
                .Property(e => e.RazonSocial)
                .IsUnicode(false);

            modelBuilder.Entity<Empresa>()
                .Property(e => e.Estado)
                .IsRequired();

            modelBuilder.Entity<Empresa>()
                .HasMany(e => e.Direccions)
                .WithRequired(e => e.Empresa)
                .HasForeignKey(e => e.IDEmpresa)
                .WillCascadeOnDelete(false);
        }
    }
}
