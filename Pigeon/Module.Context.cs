﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Pigeon
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class Module : DbContext
    {
        public Module()
            : base("name=Module")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Podmiot> Podmioty { get; set; }
        public virtual DbSet<Kontakt> Kontakty { get; set; }
        public virtual DbSet<Adres> Adresy { get; set; }
        public virtual DbSet<Wiadomość> Wiadomości { get; set; }
        public virtual DbSet<AdresatDW> AdresaciDW { get; set; }
        public virtual DbSet<Zadanie> Zadania { get; set; }
        public virtual DbSet<Załącznik> Załączniki { get; set; }
    }
}
