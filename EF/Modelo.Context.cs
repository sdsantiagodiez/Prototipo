﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EF
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class proyectoEntities : DbContext
    {
        public proyectoEntities()
            : base("name=proyectoEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<art_prov> art_prov { get; set; }
        public virtual DbSet<articulos> articulos { get; set; }
        public virtual DbSet<mail_pers> mail_pers { get; set; }
        public virtual DbSet<mail_prov> mail_prov { get; set; }
        public virtual DbSet<ped_art_prov> ped_art_prov { get; set; }
        public virtual DbSet<pedidos> pedidos { get; set; }
        public virtual DbSet<personas> personas { get; set; }
        public virtual DbSet<proveedores> proveedores { get; set; }
        public virtual DbSet<rol> rol { get; set; }
        public virtual DbSet<rol_pers> rol_pers { get; set; }
        public virtual DbSet<tel_pers> tel_pers { get; set; }
        public virtual DbSet<tel_prov> tel_prov { get; set; }
        public virtual DbSet<tipo_pedidos> tipo_pedidos { get; set; }
        public virtual DbSet<valor_com> valor_com { get; set; }
        public virtual DbSet<valor_ven> valor_ven { get; set; }
    }
}
