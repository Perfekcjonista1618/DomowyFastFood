﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DomowyFastFood
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DomowyFastFoodContext : DbContext
    {
        public DomowyFastFoodContext()
            : base("name=DomowyFastFoodContext")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Klient> Klients { get; set; }
        public virtual DbSet<Restauracja> Restauracjas { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<Zamowienie> Zamowienies { get; set; }
        public virtual DbSet<Pracownik> Pracowniks { get; set; }
    }
}