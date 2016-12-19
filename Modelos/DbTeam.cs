namespace Modelos
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class DbTeam : DbContext
    {
        public DbTeam()
            : base("name=DbTeam")
        {
        }

        public virtual DbSet<Almacenes> Almacenes { get; set; }
        public virtual DbSet<CentroCosto> CentroCosto { get; set; }
        public virtual DbSet<Cliente> Cliente { get; set; }
        public virtual DbSet<Empresa> Empresa { get; set; }
        public virtual DbSet<Familias> Familias { get; set; }
        public virtual DbSet<Obras> Obras { get; set; }
        public virtual DbSet<Opciones> Opciones { get; set; }
        public virtual DbSet<Proveedor> Proveedor { get; set; }
        public virtual DbSet<Prueba> Prueba { get; set; }
        public virtual DbSet<Subfamilia> Subfamilia { get; set; }
        public virtual DbSet<UnidadMedida> UnidadMedida { get; set; }
        public virtual DbSet<Usuario> Usuario { get; set; }
        public virtual DbSet<UsuarioPermiso> UsuarioPermiso { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            Database.SetInitializer<DbTeam>(null);
        }
    }
}
