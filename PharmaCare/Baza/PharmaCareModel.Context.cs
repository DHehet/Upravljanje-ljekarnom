﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PharmaCare.Baza
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class PharmaCare_DBEntities : DbContext
    {
        public PharmaCare_DBEntities()
            : base("name=PharmaCare_DBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<klijent> klijent { get; set; }
        public virtual DbSet<korisnik> korisnik { get; set; }
        public virtual DbSet<lijek> lijek { get; set; }
        public virtual DbSet<proizvodac> proizvodac { get; set; }
        public virtual DbSet<racun> racun { get; set; }
        public virtual DbSet<stavka_racuna> stavka_racuna { get; set; }
        public virtual DbSet<uloga> uloga { get; set; }
    }
}