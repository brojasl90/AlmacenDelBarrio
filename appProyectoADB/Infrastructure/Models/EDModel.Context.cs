﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Infrastructure.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class AlmacenDelBarrioEntities : DbContext
    {
        public AlmacenDelBarrioEntities()
            : base("name=AlmacenDelBarrioEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Bodega> Bodega { get; set; }
        public virtual DbSet<Categoria> Categoria { get; set; }
        public virtual DbSet<GestionInventario> GestionInventario { get; set; }
        public virtual DbSet<Producto> Producto { get; set; }
        public virtual DbSet<Proveedor> Proveedor { get; set; }
        public virtual DbSet<Rol> Rol { get; set; }
        public virtual DbSet<TipoMovimiento> TipoMovimiento { get; set; }
        public virtual DbSet<Ubicacion> Ubicacion { get; set; }
        public virtual DbSet<Usuario> Usuario { get; set; }
    }
}