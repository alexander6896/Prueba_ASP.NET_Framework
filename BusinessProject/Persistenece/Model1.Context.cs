//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BusinessProject.Persistenece
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class BDPasajeEntities : DbContext
    {
        public BDPasajeEntities()
            : base("name=BDPasajeEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Asiento> Asientoes { get; set; }
        public virtual DbSet<Bus> Buses { get; set; }
        public virtual DbSet<Cliente> Clientes { get; set; }
        public virtual DbSet<DETALLEVENTA> DETALLEVENTAs { get; set; }
        public virtual DbSet<Empleado> Empleadoes { get; set; }
        public virtual DbSet<Lugar> Lugars { get; set; }
        public virtual DbSet<Marca> Marcas { get; set; }
        public virtual DbSet<Modelo> Modeloes { get; set; }
        public virtual DbSet<Pagina> Paginas { get; set; }
        public virtual DbSet<Rol> Rols { get; set; }
        public virtual DbSet<RolPagina> RolPaginas { get; set; }
        public virtual DbSet<Sexo> Sexoes { get; set; }
        public virtual DbSet<Sucursal> Sucursals { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<TipoBu> TipoBus { get; set; }
        public virtual DbSet<TipoContrato> TipoContratoes { get; set; }
        public virtual DbSet<TipoUsuario> TipoUsuarios { get; set; }
        public virtual DbSet<TIPOUSUARIOREGISTRO> TIPOUSUARIOREGISTROes { get; set; }
        public virtual DbSet<Usuario> Usuarios { get; set; }
        public virtual DbSet<VENTA> VENTAs { get; set; }
        public virtual DbSet<Viaje> Viajes { get; set; }
    }
}
